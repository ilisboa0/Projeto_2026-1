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
    public partial class frm_Alunos : Form
    {
        
        SqlConnection conn = new SqlConnection("Data Source=OSA0716366W11-1\\SQLEXPRESS;Initial Catalog=PROJETO05;Integrated Security=True;Encrypt=False");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;

        public frm_Alunos()
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

        private void frm_Alunos_Load(object sender, EventArgs e)
        {
            cbx_Pesquisas.Items.Add("1 - Alunos com seus Cursos");
                cbx_Pesquisas.SelectedIndex = 0;
        }
        private void CarregarLista()
        {
            ltb_Aluno.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Sobrenome.Items.Clear();
            ltb_RG.Items.Clear();
            ltb_CPF.Items.Clear();
            ltb_Senha.Items.Clear();
            ltb_Genero.Items.Clear();
            ltb_CEP.Items.Clear();
            ltb_Email.Items.Clear();
            ltb_Telefone.Items.Clear();
            ltb_Nascimento.Items.Clear();

            conn.Open();
            comando.CommandText = "select * from Aluno";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Aluno.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Senha.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Nascimento.Items.Add(dr[10].ToString());

                }
            }
            conn.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txt_Genero.Text = "F";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txt_Genero.Text = "M";
        }

        private void txt_CEP_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Alunos_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Aluno.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;

                txt_Id.Text = ltb_Aluno.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();


            }
        }

        private void dtp_Nascimento_ValueChanged(object sender, EventArgs e)
        {
            txt_Data.Text = dtp_Nascimento.Value.ToString("yyyy-MM-dd");
        }
        private void ltb_Aluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Aluno.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;

                txt_Id.Text = ltb_Aluno.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();


            }
        }
        private void lblTelefone_Click(object sender, EventArgs e)
        {

        }
        private void ltb_Nascimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Aluno.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;

                txt_Id.Text = ltb_Aluno.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();


            }
        }
        private void ltb_Telefone_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Aluno.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;

                txt_Id.Text = ltb_Aluno.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();


            }
        }

        private void ltb_Nome_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Aluno.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;

                txt_Id.Text = ltb_Aluno.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();


            }
        }

        private void ltb_Sobrenome_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Aluno.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;

                txt_Id.Text = ltb_Aluno.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();


            }
        }

        private void ltb_RG_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Aluno.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;

                txt_Id.Text = ltb_Aluno.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();


            }
        }

        private void ltb_CPF_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Aluno.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;

                txt_Id.Text = ltb_Aluno.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();


            }
        }

        private void ltb_Genero_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Aluno.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;

                txt_Id.Text = ltb_Aluno.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();


            }
        }

        private void ltb_CEP_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Aluno.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;

                txt_Id.Text = ltb_Aluno.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();


            }
        }

        private void ltb_Email_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Aluno.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;

                txt_Id.Text = ltb_Aluno.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();


            }
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
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
            CarregarLista();

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            conn.Open();
            comando.CommandText = "insert into Aluno(nome, sobrenome, RG, CPF, Senha, genero, CEP, email, telefone, Data_nascimento) values ('" + txt_Nome.Text + "','" + txt_Sobrenome.Text + "','" + txt_RG.Text + "','" + txt_CPF.Text + "','" + txt_Senha.Text + "','" + txt_Genero.Text + "','" + txt_CEP.Text + "','" + txt_Email.Text + "','" + txt_Telefone.Text + "','" + dtp_Nascimento.Value.ToString("yyyy-MM-dd") + "')";
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
            comando.CommandText = "UPDATE Aluno SET " + "nome = '" + txt_Nome.Text + "', " + "sobrenome = '" + txt_Sobrenome.Text + "', " + "RG = '" + txt_RG.Text + "', " + "CPF = '" + txt_CPF.Text + "', " + "Senha = '" + txt_Senha.Text + "', " + "genero = '" + txt_Genero.Text + "', " + "CEP = '" + txt_CEP.Text + "', " + "email = '" + txt_Email.Text + "', " + "telefone = '" + txt_Telefone.Text + "', " + "Data_nascimento = '" + dtp_Nascimento.Value.ToString("yyyy-MM-dd") + "' " + "WHERE id_aluno = " + int.Parse(txt_Id.Text);

            comando.ExecuteNonQuery();
            conn.Close();
            CarregarLista();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            conn.Open();
            comando.CommandText = "delete from Aluno where id_aluno = '" + txt_Id.Text + "'";
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

        private void txt_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Data_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_PAluno_TextChanged(object sender, EventArgs e)
        {
            ltb_Aluno.Items.Clear();
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
            comando.CommandText = "select * from Aluno where id_aluno like '%" + txt_PAluno.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Aluno.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Senha.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Nascimento.Items.Add(dr[10].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PNome_TextChanged(object sender, EventArgs e)
        {
            ltb_Aluno.Items.Clear();
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
            comando.CommandText = "select * from Aluno where nome like '%" + txt_PNome.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Aluno.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Senha.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Nascimento.Items.Add(dr[10].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PSobrenome_TextChanged(object sender, EventArgs e)
        {
            ltb_Aluno.Items.Clear();
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
            comando.CommandText = "select * from Aluno where sobrenome like '%" + txt_PSobrenome.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Aluno.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Senha.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Nascimento.Items.Add(dr[10].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PRG_TextChanged(object sender, EventArgs e)
        {
            ltb_Aluno.Items.Clear();
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
            comando.CommandText = "select * from Aluno where RG like '%" + txt_PRG.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Aluno.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Senha.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Nascimento.Items.Add(dr[10].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PCPF_TextChanged(object sender, EventArgs e)
        {
            ltb_Aluno.Items.Clear();
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
            comando.CommandText = "select * from Aluno where CPF like '%" + txt_PCPF.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Aluno.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Senha.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Nascimento.Items.Add(dr[10].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PSenha_TextChanged(object sender, EventArgs e)
        {
            ltb_Aluno.Items.Clear();
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
            comando.CommandText = "select * from Aluno where Senha like '%" + txt_PSenha.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Aluno.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Senha.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Nascimento.Items.Add(dr[10].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PGenero_TextChanged(object sender, EventArgs e)
        {
            ltb_Aluno.Items.Clear();
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
            comando.CommandText = "select * from Aluno where genero like '%" + txt_PGenero.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Aluno.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Senha.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Nascimento.Items.Add(dr[10].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PCEP_TextChanged(object sender, EventArgs e)
        {
            ltb_Aluno.Items.Clear();
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
            comando.CommandText = "select * from Aluno where CEP like '%" + txt_PCEP.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Aluno.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Senha.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Nascimento.Items.Add(dr[10].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PEmail_TextChanged(object sender, EventArgs e)
        {
            ltb_Aluno.Items.Clear();
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
            comando.CommandText = "select * from Aluno where email like '%" + txt_PEmail.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Aluno.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Senha.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Nascimento.Items.Add(dr[10].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PTelefone_TextChanged(object sender, EventArgs e)
        {
            ltb_Aluno.Items.Clear();
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
            comando.CommandText = "select * from Aluno where telefone like '%" + txt_PTelefone.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Aluno.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Senha.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Nascimento.Items.Add(dr[10].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PData_TextChanged(object sender, EventArgs e)
        {
            ltb_Aluno.Items.Clear();
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
            comando.CommandText = "select * from Aluno where Data_nascimento like '%" + txt_PData.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Aluno.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Senha.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Nascimento.Items.Add(dr[10].ToString());

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
                    return @"SELECT a.nome, a.sobrenome, c.Nome
             FROM Aluno a
             INNER JOIN Matricula m ON a.id_aluno = m.Id_Aluno
             INNER JOIN Curso c ON m.Id_Curso = c.Id_Curso";

                default:
                    return "";
            }
        }

        private void cbx_Pesquisas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
