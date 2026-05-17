using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Uc_12_Stephane_EstudaFácil
{
    public partial class frm_Atendentes : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=OSA0716366W11-1\\SQLEXPRESS;Initial Catalog=PROJETO05;Integrated Security=True;Encrypt=False");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
        public frm_Atendentes()
        {
            InitializeComponent();
            comando.Connection = conn;
            CarregarLista();
        }
        private DataTable ExecutarQuery(string sql)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection("Data Source=OSA0716366W11-1\\SQLEXPRESS;Initial Catalog=PROJETO05;Integrated Security=True;Encrypt=False"))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }

            return dt;

        }

        private void frm_Atendentes_Load(object sender, EventArgs e)
        {
            cbx_Pesquisas.Items.Add("1 - Atendentes com seus atendimentos");
            cbx_Pesquisas.SelectedIndex = 0;
        }

        private void CarregarLista()
        {
            ltb_Atendente.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Sobrenome.Items.Clear();
            ltb_RG.Items.Clear();
            ltb_CPF.Items.Clear();
            ltb_Nascimento.Items.Clear();
            ltb_Genero.Items.Clear();
            ltb_CEP.Items.Clear();
            ltb_Email.Items.Clear();
            ltb_Telefone.Items.Clear();
            ltb_Senha.Items.Clear();

            conn.Open();
            comando.CommandText = "select * from Atendente";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Atendente.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Nascimento.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Senha.Items.Add(dr[10].ToString());

                }
            }
            conn.Close();

        }

        private void ltb_Atendente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Atendente.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;

                txt_Id.Text = ltb_Atendente.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();


            }
        }

        private void ltb_Nome_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Atendente.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;

                txt_Id.Text = ltb_Atendente.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();


            }
        }

        private void ltb_Sobrenome_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Atendente.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;

                txt_Id.Text = ltb_Atendente.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();


            }
        }

        private void ltb_RG_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Atendente.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;

                txt_Id.Text = ltb_Atendente.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();


            }
        }

        private void ltb_CPF_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Atendente.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;

                txt_Id.Text = ltb_Atendente.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();


            }
        }

        private void ltb_Nascimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Atendente.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;

                txt_Id.Text = ltb_Atendente.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();


            }
        }

        private void ltb_Genero_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Atendente.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;

                txt_Id.Text = ltb_Atendente.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();


            }
        }

        private void ltb_CEP_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Atendente.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;

                txt_Id.Text = ltb_Atendente.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();


            }
        }

        private void ltb_Email_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Atendente.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;

                txt_Id.Text = ltb_Atendente.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();


            }
        }

        private void ltb_Telefone_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Atendente.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;

                txt_Id.Text = ltb_Atendente.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();


            }
        }

        private void ltb_Senha_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Atendente.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;

                txt_Id.Text = ltb_Atendente.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();


            }
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            txt_Id.Clear();
            txt_Nome.Clear();
            txt_Sobrenome.Clear();
            txt_RG.Clear();
            txt_CPF.Clear();
            txt_Data.Clear();
            txt_Genero.Clear();
            txt_CEP.Clear();
            txt_Email.Clear();
            txt_Telefone.Clear();
            txt_Senha.Clear();
            txt_Nome.Focus();
            CarregarLista();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            conn.Open();
            comando.CommandText = "insert into Atendente(Nome, Sobrenome, RG, CPF, Data_nascimento, genero, CEP, email, telefone, Senha) values ('" + txt_Nome.Text + "','" + txt_Sobrenome.Text + "','" + txt_RG.Text + "','" + txt_CPF.Text + "','" + dtp_Nascimento.Value.ToString("yyyy-MM-dd") + "','" + txt_Genero.Text + "','" + txt_CEP.Text + "','" + txt_Email.Text + "','" + txt_Telefone.Text + "','" + txt_Senha.Text + "')";
            comando.ExecuteNonQuery();
            conn.Close();
            CarregarLista();
            txt_Id.Clear();
            txt_Nome.Clear();
            txt_Sobrenome.Clear();
            txt_RG.Clear();
            txt_CPF.Clear();
            txt_Senha.Clear();
            txt_Genero.Clear();
            txt_CEP.Clear();
            txt_Email.Clear();
            txt_Telefone.Clear();
            txt_Data.Clear();
            txt_Nome.Focus();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            int.Parse(txt_Id.Text);
            DateTime.Parse(txt_Data.Text);

            conn.Open();
            comando.CommandText = "UPDATE Atendente SET " + "Nome = '" + txt_Nome.Text + "', " + "Sobrenome = '" + txt_Sobrenome.Text + "', " + "RG = '" + txt_RG.Text + "', " + "CPF = '" + txt_CPF.Text + "', " + "Data_nascimento = '" + dtp_Nascimento.Value.ToString("yyyy-MM-dd") + "', " + "genero = '" + txt_Genero.Text + "', " + "CEP = '" + txt_CEP.Text + "', " + "email = '" + txt_Email.Text + "', " + "telefone = '" + txt_Telefone.Text + "', " + "Senha = '" + txt_Senha.Text + "' " + "WHERE Id_Atendente = " + int.Parse(txt_Id.Text);

            comando.ExecuteNonQuery();
            conn.Close();
            CarregarLista();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            conn.Open();
            comando.CommandText = "delete from Atendente where Id_Atendente = '" + txt_Id.Text + "'";
            comando.ExecuteNonQuery();
            conn.Close();
            CarregarLista();
            txt_Id.Clear();
            txt_Nome.Clear();
            txt_Sobrenome.Clear();
            txt_RG.Clear();
            txt_CPF.Clear();
            txt_Senha.Clear();
            txt_Genero.Clear();
            txt_CEP.Clear();
            txt_Email.Clear();
            txt_Telefone.Clear();
            txt_Data.Clear();
            txt_Nome.Focus();
        }

        private void dtp_Nascimento_ValueChanged(object sender, EventArgs e)
        {
            txt_Data.Text = dtp_Nascimento.Value.ToString("yyyy-MM-dd");
        }

        private void rdb_Feminino_CheckedChanged(object sender, EventArgs e)
        {
            txt_Genero.Text = "F";
        }

        private void rdb_Masculino_CheckedChanged(object sender, EventArgs e)
        {
            txt_Genero.Text = "M";
        }

        private void txt_PAtendente_TextChanged(object sender, EventArgs e)
        {
            ltb_Atendente.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Sobrenome.Items.Clear();
            ltb_RG.Items.Clear();
            ltb_CPF.Items.Clear();
            ltb_Nascimento.Items.Clear();
            ltb_Genero.Items.Clear();
            ltb_CEP.Items.Clear();
            ltb_Email.Items.Clear();
            ltb_Telefone.Items.Clear();
            ltb_Senha.Items.Clear();


            conn.Open();
            comando.CommandText = "select * from Atendente where Id_Atendente like '%" + txt_PAtendente.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Atendente.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Nascimento.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Senha.Items.Add(dr[10].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PNome_TextChanged(object sender, EventArgs e)
        {
            ltb_Atendente.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Sobrenome.Items.Clear();
            ltb_RG.Items.Clear();
            ltb_CPF.Items.Clear();
            ltb_Nascimento.Items.Clear();
            ltb_Genero.Items.Clear();
            ltb_CEP.Items.Clear();
            ltb_Email.Items.Clear();
            ltb_Telefone.Items.Clear();
            ltb_Senha.Items.Clear();


            conn.Open();
            comando.CommandText = "select * from Atendente where Nome like '%" + txt_PNome.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Atendente.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Nascimento.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Senha.Items.Add(dr[10].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PSobrenome_TextChanged(object sender, EventArgs e)
        {
            ltb_Atendente.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Sobrenome.Items.Clear();
            ltb_RG.Items.Clear();
            ltb_CPF.Items.Clear();
            ltb_Nascimento.Items.Clear();
            ltb_Genero.Items.Clear();
            ltb_CEP.Items.Clear();
            ltb_Email.Items.Clear();
            ltb_Telefone.Items.Clear();
            ltb_Senha.Items.Clear();


            conn.Open();
            comando.CommandText = "select * from Atendente where Sobrenome like '%" + txt_PSobrenome.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Atendente.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Nascimento.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Senha.Items.Add(dr[10].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PRG_TextChanged(object sender, EventArgs e)
        {
            ltb_Atendente.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Sobrenome.Items.Clear();
            ltb_RG.Items.Clear();
            ltb_CPF.Items.Clear();
            ltb_Nascimento.Items.Clear();
            ltb_Genero.Items.Clear();
            ltb_CEP.Items.Clear();
            ltb_Email.Items.Clear();
            ltb_Telefone.Items.Clear();
            ltb_Senha.Items.Clear();


            conn.Open();
            comando.CommandText = "select * from Atendente where RG like '%" + txt_PRG.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Atendente.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Nascimento.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Senha.Items.Add(dr[10].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PCPF_TextChanged(object sender, EventArgs e)
        {
            ltb_Atendente.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Sobrenome.Items.Clear();
            ltb_RG.Items.Clear();
            ltb_CPF.Items.Clear();
            ltb_Nascimento.Items.Clear();
            ltb_Genero.Items.Clear();
            ltb_CEP.Items.Clear();
            ltb_Email.Items.Clear();
            ltb_Telefone.Items.Clear();
            ltb_Senha.Items.Clear();


            conn.Open();
            comando.CommandText = "select * from Atendente where CPF like '%" + txt_PCPF.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Atendente.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Nascimento.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Senha.Items.Add(dr[10].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PData_TextChanged(object sender, EventArgs e)
        {
            ltb_Atendente.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Sobrenome.Items.Clear();
            ltb_RG.Items.Clear();
            ltb_CPF.Items.Clear();
            ltb_Nascimento.Items.Clear();
            ltb_Genero.Items.Clear();
            ltb_CEP.Items.Clear();
            ltb_Email.Items.Clear();
            ltb_Telefone.Items.Clear();
            ltb_Senha.Items.Clear();


            conn.Open();
            comando.CommandText = "select * from Atendente where Data_nascimento like '%" + txt_PData.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Atendente.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Nascimento.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Senha.Items.Add(dr[10].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PGenero_TextChanged(object sender, EventArgs e)
        {
            ltb_Atendente.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Sobrenome.Items.Clear();
            ltb_RG.Items.Clear();
            ltb_CPF.Items.Clear();
            ltb_Nascimento.Items.Clear();
            ltb_Genero.Items.Clear();
            ltb_CEP.Items.Clear();
            ltb_Email.Items.Clear();
            ltb_Telefone.Items.Clear();
            ltb_Senha.Items.Clear();


            conn.Open();
            comando.CommandText = "select * from Atendente where genero like '%" + txt_PGenero.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Atendente.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Nascimento.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Senha.Items.Add(dr[10].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PCEP_TextChanged(object sender, EventArgs e)
        {
            ltb_Atendente.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Sobrenome.Items.Clear();
            ltb_RG.Items.Clear();
            ltb_CPF.Items.Clear();
            ltb_Nascimento.Items.Clear();
            ltb_Genero.Items.Clear();
            ltb_CEP.Items.Clear();
            ltb_Email.Items.Clear();
            ltb_Telefone.Items.Clear();
            ltb_Senha.Items.Clear();


            conn.Open();
            comando.CommandText = "select * from Atendente where CEP like '%" + txt_PCEP.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Atendente.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Nascimento.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Senha.Items.Add(dr[10].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PEmail_TextChanged(object sender, EventArgs e)
        {
            ltb_Atendente.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Sobrenome.Items.Clear();
            ltb_RG.Items.Clear();
            ltb_CPF.Items.Clear();
            ltb_Nascimento.Items.Clear();
            ltb_Genero.Items.Clear();
            ltb_CEP.Items.Clear();
            ltb_Email.Items.Clear();
            ltb_Telefone.Items.Clear();
            ltb_Senha.Items.Clear();


            conn.Open();
            comando.CommandText = "select * from Atendente where email like '%" + txt_PEmail.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Atendente.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Nascimento.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Senha.Items.Add(dr[10].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PTelefone_TextChanged(object sender, EventArgs e)
        {
            ltb_Atendente.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Sobrenome.Items.Clear();
            ltb_RG.Items.Clear();
            ltb_CPF.Items.Clear();
            ltb_Nascimento.Items.Clear();
            ltb_Genero.Items.Clear();
            ltb_CEP.Items.Clear();
            ltb_Email.Items.Clear();
            ltb_Telefone.Items.Clear();
            ltb_Senha.Items.Clear();


            conn.Open();
            comando.CommandText = "select * from Atendente where telefone like '%" + txt_PTelefone.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Atendente.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Nascimento.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Senha.Items.Add(dr[10].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PSenha_TextChanged(object sender, EventArgs e)
        {
            ltb_Atendente.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Sobrenome.Items.Clear();
            ltb_RG.Items.Clear();
            ltb_CPF.Items.Clear();
            ltb_Nascimento.Items.Clear();
            ltb_Genero.Items.Clear();
            ltb_CEP.Items.Clear();
            ltb_Email.Items.Clear();
            ltb_Telefone.Items.Clear();
            ltb_Senha.Items.Clear();


            conn.Open();
            comando.CommandText = "select * from Atendente where Senha like '%" + txt_PSenha.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Atendente.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Nascimento.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Senha.Items.Add(dr[10].ToString());

                }
            }
            conn.Close();
        }

        private void btn_Pesquisas_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ExecutarQuery(GetSql(cbx_Pesquisas.SelectedIndex));
        }
        private string GetSql(int opcao)
        {
            switch (opcao)
            {
                case 0:
                    return @"SELECT a.Id_Atendente,
                            a.Nome,
                            a.Sobrenome,
                            s.Tipo_de_Solicitação,
                            s.Status_do_atendimento
                     FROM Atendente a
                     INNER JOIN Atendimento_Secretaria s 
                     ON a.Id_Atendente = s.Id_Atendente";

                default:
                    return "";
            }
        }
    
    }
}
