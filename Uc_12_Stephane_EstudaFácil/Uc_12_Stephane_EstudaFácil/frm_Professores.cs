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

namespace Uc_12_Stephane_EstudaFácil
{
    public partial class frm_Professores : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=OSA0716366W11-1\\SQLEXPRESS;Initial Catalog=PROJETO05;Integrated Security=True;Encrypt=False");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;

        public frm_Professores()
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

        private void frm_Professores_Load(object sender, EventArgs e)
        {
            cbx_Pesquisas.Items.Add("1 - Professores com seus Cursos");
            cbx_Pesquisas.SelectedIndex = 0;
        }
        private void CarregarLista()
        {
            ltb_Professor.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Sobrenome.Items.Clear();
            ltb_RG.Items.Clear();
            ltb_CPF.Items.Clear();
            ltb_Nascimento.Items.Clear();
            ltb_Genero.Items.Clear();
            ltb_CEP.Items.Clear();
            ltb_Email.Items.Clear();
            ltb_Telefone.Items.Clear();
            ltb_Educacao.Items.Clear();
            ltb_Disciplina.Items.Clear();
            ltb_Senha.Items.Clear();


            conn.Open();
            comando.CommandText = "select * from Professor";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Professor.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Nascimento.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Educacao.Items.Add(dr[10].ToString());
                    ltb_Disciplina.Items.Add(dr[11].ToString());
                    ltb_Senha.Items.Add(dr[12].ToString());


                }
            }
            conn.Close();

        }
        private void cbx_Educacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Educacao.Text = cbx_Educacao.Text;
        }

        private void dtp_Nascimento_ValueChanged(object sender, EventArgs e)
        {
            txt_Data.Text = dtp_Nascimento.Value.ToString("yyyy-MM-dd");
        }

        private void cbx_Disciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Disciplina.Text = cbx_Disciplina.Text;
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
            txt_Educacao.Clear();
            txt_Disciplina.Clear();
            txt_Senha.Clear();
            txt_Nome.Focus();
            CarregarLista();
        }

        private void ltb_Professor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Professor.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Educacao.SelectedIndex = l.SelectedIndex;
                ltb_Disciplina.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;


                txt_Id.Text = ltb_Professor.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Educacao.Text = ltb_Educacao.SelectedItem.ToString();
                txt_Disciplina.Text = ltb_Disciplina.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();


            }
        }

        private void ltb_Nome_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Professor.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Educacao.SelectedIndex = l.SelectedIndex;
                ltb_Disciplina.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;


                txt_Id.Text = ltb_Professor.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Educacao.Text = ltb_Educacao.SelectedItem.ToString();
                txt_Disciplina.Text = ltb_Disciplina.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();


            }
        }

        private void ltb_Sobrenome_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Professor.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Educacao.SelectedIndex = l.SelectedIndex;
                ltb_Disciplina.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;


                txt_Id.Text = ltb_Professor.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Educacao.Text = ltb_Educacao.SelectedItem.ToString();
                txt_Disciplina.Text = ltb_Disciplina.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();


            }
        }

        private void ltb_RG_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Professor.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Educacao.SelectedIndex = l.SelectedIndex;
                ltb_Disciplina.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;


                txt_Id.Text = ltb_Professor.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Educacao.Text = ltb_Educacao.SelectedItem.ToString();
                txt_Disciplina.Text = ltb_Disciplina.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();


            }
        }

        private void ltb_CPF_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Professor.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Educacao.SelectedIndex = l.SelectedIndex;
                ltb_Disciplina.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;


                txt_Id.Text = ltb_Professor.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Educacao.Text = ltb_Educacao.SelectedItem.ToString();
                txt_Disciplina.Text = ltb_Disciplina.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();


            }
        }

        private void ltb_Nascimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Professor.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Educacao.SelectedIndex = l.SelectedIndex;
                ltb_Disciplina.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;


                txt_Id.Text = ltb_Professor.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Educacao.Text = ltb_Educacao.SelectedItem.ToString();
                txt_Disciplina.Text = ltb_Disciplina.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();


            }
        }

        private void ltb_Genero_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Professor.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Educacao.SelectedIndex = l.SelectedIndex;
                ltb_Disciplina.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;


                txt_Id.Text = ltb_Professor.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Educacao.Text = ltb_Educacao.SelectedItem.ToString();
                txt_Disciplina.Text = ltb_Disciplina.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();


            }
        }

        private void ltb_CEP_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Professor.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Educacao.SelectedIndex = l.SelectedIndex;
                ltb_Disciplina.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;


                txt_Id.Text = ltb_Professor.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Educacao.Text = ltb_Educacao.SelectedItem.ToString();
                txt_Disciplina.Text = ltb_Disciplina.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();


            }
        }

        private void ltb_Email_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Professor.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Educacao.SelectedIndex = l.SelectedIndex;
                ltb_Disciplina.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;


                txt_Id.Text = ltb_Professor.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Educacao.Text = ltb_Educacao.SelectedItem.ToString();
                txt_Disciplina.Text = ltb_Disciplina.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();


            }
        }

        private void ltb_Telefone_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Professor.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Educacao.SelectedIndex = l.SelectedIndex;
                ltb_Disciplina.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;


                txt_Id.Text = ltb_Professor.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Educacao.Text = ltb_Educacao.SelectedItem.ToString();
                txt_Disciplina.Text = ltb_Disciplina.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();


            }
        }

        private void ltb_Educacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Professor.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Educacao.SelectedIndex = l.SelectedIndex;
                ltb_Disciplina.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;


                txt_Id.Text = ltb_Professor.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Educacao.Text = ltb_Educacao.SelectedItem.ToString();
                txt_Disciplina.Text = ltb_Disciplina.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();


            }
        }

        private void ltb_Disciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Professor.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Educacao.SelectedIndex = l.SelectedIndex;
                ltb_Disciplina.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;


                txt_Id.Text = ltb_Professor.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Educacao.Text = ltb_Educacao.SelectedItem.ToString();
                txt_Disciplina.Text = ltb_Disciplina.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();


            }
        }

        private void ltb_Senha_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Professor.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Sobrenome.SelectedIndex = l.SelectedIndex;
                ltb_RG.SelectedIndex = l.SelectedIndex;
                ltb_CPF.SelectedIndex = l.SelectedIndex;
                ltb_Nascimento.SelectedIndex = l.SelectedIndex;
                ltb_Genero.SelectedIndex = l.SelectedIndex;
                ltb_CEP.SelectedIndex = l.SelectedIndex;
                ltb_Email.SelectedIndex = l.SelectedIndex;
                ltb_Telefone.SelectedIndex = l.SelectedIndex;
                ltb_Educacao.SelectedIndex = l.SelectedIndex;
                ltb_Disciplina.SelectedIndex = l.SelectedIndex;
                ltb_Senha.SelectedIndex = l.SelectedIndex;


                txt_Id.Text = ltb_Professor.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Sobrenome.Text = ltb_Sobrenome.SelectedItem.ToString();
                txt_RG.Text = ltb_RG.SelectedItem.ToString();
                txt_CPF.Text = ltb_CPF.SelectedItem.ToString();
                txt_Data.Text = ltb_Nascimento.SelectedItem.ToString();
                txt_Genero.Text = ltb_Genero.SelectedItem.ToString();
                txt_CEP.Text = ltb_CEP.SelectedItem.ToString();
                txt_Email.Text = ltb_Email.SelectedItem.ToString();
                txt_Telefone.Text = ltb_Telefone.SelectedItem.ToString();
                txt_Educacao.Text = ltb_Educacao.SelectedItem.ToString();
                txt_Disciplina.Text = ltb_Disciplina.SelectedItem.ToString();
                txt_Senha.Text = ltb_Senha.SelectedItem.ToString();


            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            conn.Open();
            comando.CommandText = "insert into Professor(Nome, Sobrenome, RG, CPF, Data_nascimento, genero, CEP, email, telefone, Educação, Disciplina,Senha ) values ('" + txt_Nome.Text + "','" + txt_Sobrenome.Text + "','" + txt_RG.Text + "','" + txt_CPF.Text + "','" + dtp_Nascimento.Value.ToString("yyyy-MM-dd") + "','" + txt_Genero.Text + "','" + txt_CEP.Text + "','" + txt_Email.Text + "','" + txt_Telefone.Text + "','" + txt_Educacao.Text + "','" + txt_Disciplina.Text + "','" + txt_Senha.Text + "')";
            comando.ExecuteNonQuery();
            conn.Close();
            CarregarLista();
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
            txt_Educacao.Clear();
            txt_Disciplina.Clear();
            txt_Senha.Clear();
            txt_Nome.Focus();

        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            int.Parse(txt_Id.Text);
            DateTime.Parse(txt_Data.Text);

            conn.Open();
            comando.CommandText = "UPDATE Professor SET " + "nome = '" + txt_Nome.Text + "', " + "sobrenome = '" + txt_Sobrenome.Text + "', " + "RG = '" + txt_RG.Text + "', " + "CPF = '" + txt_CPF.Text + "'," + "Data_nascimento = '" + dtp_Nascimento.Value.ToString("yyyy-MM-dd") + "', " + "genero = '" + txt_Genero.Text + "', " + "CEP = '" + txt_CEP.Text + "', " + "email = '" + txt_Email.Text + "', " + "telefone = '" + txt_Telefone.Text + "', " + "Educação = '" + txt_Educacao.Text + "', " + "Disciplina = '" + txt_Disciplina.Text + "', " + "Senha = '" + txt_Senha.Text + "' " + "WHERE id_professor = " + int.Parse(txt_Id.Text);

            comando.ExecuteNonQuery();
            conn.Close();
            CarregarLista();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            conn.Open();
            comando.CommandText = "delete from Professor where id_professor = '" + txt_Id.Text + "'";
            comando.ExecuteNonQuery();
            conn.Close();
            CarregarLista();
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
            txt_Educacao.Clear();
            txt_Disciplina.Clear();
            txt_Senha.Clear();
            txt_Nome.Focus();
        }

        private void txt_Data_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Disciplina_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdb_Feminino_CheckedChanged(object sender, EventArgs e)
        {
            txt_Genero.Text = "F";
        }

        private void rdb_Masculino_CheckedChanged(object sender, EventArgs e)
        {
            txt_Genero.Text = "M";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ltb_Professor.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Sobrenome.Items.Clear();
            ltb_RG.Items.Clear();
            ltb_CPF.Items.Clear();
            ltb_Nascimento.Items.Clear();
            ltb_Genero.Items.Clear();
            ltb_CEP.Items.Clear();
            ltb_Email.Items.Clear();
            ltb_Telefone.Items.Clear();
            ltb_Educacao.Items.Clear();
            ltb_Disciplina.Items.Clear();
            ltb_Senha.Items.Clear();



            conn.Open();
            comando.CommandText = "select * from Professor where Data_nascimento like '%" + txt_PData.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Professor.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Nascimento.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Educacao.Items.Add(dr[10].ToString());
                    ltb_Disciplina.Items.Add(dr[11].ToString());
                    ltb_Senha.Items.Add(dr[12].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PProfessor_TextChanged(object sender, EventArgs e)
        {
            ltb_Professor.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Sobrenome.Items.Clear();
            ltb_RG.Items.Clear();
            ltb_CPF.Items.Clear();
            ltb_Nascimento.Items.Clear();
            ltb_Genero.Items.Clear();
            ltb_CEP.Items.Clear();
            ltb_Email.Items.Clear();
            ltb_Telefone.Items.Clear();
            ltb_Educacao.Items.Clear();
            ltb_Disciplina.Items.Clear();
            ltb_Senha.Items.Clear();



            conn.Open();
            comando.CommandText = "select * from Professor where id_professor like '%" + txt_PProfessor.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Professor.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Nascimento.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Educacao.Items.Add(dr[10].ToString());
                    ltb_Disciplina.Items.Add(dr[11].ToString());
                    ltb_Senha.Items.Add(dr[12].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PNome_TextChanged(object sender, EventArgs e)
        {
            ltb_Professor.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Sobrenome.Items.Clear();
            ltb_RG.Items.Clear();
            ltb_CPF.Items.Clear();
            ltb_Nascimento.Items.Clear();
            ltb_Genero.Items.Clear();
            ltb_CEP.Items.Clear();
            ltb_Email.Items.Clear();
            ltb_Telefone.Items.Clear();
            ltb_Educacao.Items.Clear();
            ltb_Disciplina.Items.Clear();
            ltb_Senha.Items.Clear();



            conn.Open();
            comando.CommandText = "select * from Professor where Nome like '%" + txt_PNome.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Professor.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Nascimento.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Educacao.Items.Add(dr[10].ToString());
                    ltb_Disciplina.Items.Add(dr[11].ToString());
                    ltb_Senha.Items.Add(dr[12].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PSobrenome_TextChanged(object sender, EventArgs e)
        {
            ltb_Professor.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Sobrenome.Items.Clear();
            ltb_RG.Items.Clear();
            ltb_CPF.Items.Clear();
            ltb_Nascimento.Items.Clear();
            ltb_Genero.Items.Clear();
            ltb_CEP.Items.Clear();
            ltb_Email.Items.Clear();
            ltb_Telefone.Items.Clear();
            ltb_Educacao.Items.Clear();
            ltb_Disciplina.Items.Clear();
            ltb_Senha.Items.Clear();



            conn.Open();
            comando.CommandText = "select * from Professor where Sobremome like '%" + txt_PSobrenome.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Professor.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Nascimento.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Educacao.Items.Add(dr[10].ToString());
                    ltb_Disciplina.Items.Add(dr[11].ToString());
                    ltb_Senha.Items.Add(dr[12].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PRG_TextChanged(object sender, EventArgs e)
        {
            ltb_Professor.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Sobrenome.Items.Clear();
            ltb_RG.Items.Clear();
            ltb_CPF.Items.Clear();
            ltb_Nascimento.Items.Clear();
            ltb_Genero.Items.Clear();
            ltb_CEP.Items.Clear();
            ltb_Email.Items.Clear();
            ltb_Telefone.Items.Clear();
            ltb_Educacao.Items.Clear();
            ltb_Disciplina.Items.Clear();
            ltb_Senha.Items.Clear();



            conn.Open();
            comando.CommandText = "select * from Professor where RG like '%" + txt_PRG.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Professor.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Nascimento.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Educacao.Items.Add(dr[10].ToString());
                    ltb_Disciplina.Items.Add(dr[11].ToString());
                    ltb_Senha.Items.Add(dr[12].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PCPF_TextChanged(object sender, EventArgs e)
        {
            ltb_Professor.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Sobrenome.Items.Clear();
            ltb_RG.Items.Clear();
            ltb_CPF.Items.Clear();
            ltb_Nascimento.Items.Clear();
            ltb_Genero.Items.Clear();
            ltb_CEP.Items.Clear();
            ltb_Email.Items.Clear();
            ltb_Telefone.Items.Clear();
            ltb_Educacao.Items.Clear();
            ltb_Disciplina.Items.Clear();
            ltb_Senha.Items.Clear();



            conn.Open();
            comando.CommandText = "select * from Professor where CPF like '%" + txt_PCPF.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Professor.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Nascimento.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Educacao.Items.Add(dr[10].ToString());
                    ltb_Disciplina.Items.Add(dr[11].ToString());
                    ltb_Senha.Items.Add(dr[12].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PGenero_TextChanged(object sender, EventArgs e)
        {
            ltb_Professor.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Sobrenome.Items.Clear();
            ltb_RG.Items.Clear();
            ltb_CPF.Items.Clear();
            ltb_Nascimento.Items.Clear();
            ltb_Genero.Items.Clear();
            ltb_CEP.Items.Clear();
            ltb_Email.Items.Clear();
            ltb_Telefone.Items.Clear();
            ltb_Educacao.Items.Clear();
            ltb_Disciplina.Items.Clear();
            ltb_Senha.Items.Clear();



            conn.Open();
            comando.CommandText = "select * from Professor where genero like '%" + txt_PGenero.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Professor.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Nascimento.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Educacao.Items.Add(dr[10].ToString());
                    ltb_Disciplina.Items.Add(dr[11].ToString());
                    ltb_Senha.Items.Add(dr[12].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PCEP_TextChanged(object sender, EventArgs e)
        {
            ltb_Professor.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Sobrenome.Items.Clear();
            ltb_RG.Items.Clear();
            ltb_CPF.Items.Clear();
            ltb_Nascimento.Items.Clear();
            ltb_Genero.Items.Clear();
            ltb_CEP.Items.Clear();
            ltb_Email.Items.Clear();
            ltb_Telefone.Items.Clear();
            ltb_Educacao.Items.Clear();
            ltb_Disciplina.Items.Clear();
            ltb_Senha.Items.Clear();



            conn.Open();
            comando.CommandText = "select * from Professor where CEP like '%" + txt_PCEP.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Professor.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Nascimento.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Educacao.Items.Add(dr[10].ToString());
                    ltb_Disciplina.Items.Add(dr[11].ToString());
                    ltb_Senha.Items.Add(dr[12].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PEmail_TextChanged(object sender, EventArgs e)
        {
            ltb_Professor.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Sobrenome.Items.Clear();
            ltb_RG.Items.Clear();
            ltb_CPF.Items.Clear();
            ltb_Nascimento.Items.Clear();
            ltb_Genero.Items.Clear();
            ltb_CEP.Items.Clear();
            ltb_Email.Items.Clear();
            ltb_Telefone.Items.Clear();
            ltb_Educacao.Items.Clear();
            ltb_Disciplina.Items.Clear();
            ltb_Senha.Items.Clear();



            conn.Open();
            comando.CommandText = "select * from Professor where email like '%" + txt_PEmail.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Professor.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Nascimento.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Educacao.Items.Add(dr[10].ToString());
                    ltb_Disciplina.Items.Add(dr[11].ToString());
                    ltb_Senha.Items.Add(dr[12].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PTelefone_TextChanged(object sender, EventArgs e)
        {
            ltb_Professor.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Sobrenome.Items.Clear();
            ltb_RG.Items.Clear();
            ltb_CPF.Items.Clear();
            ltb_Nascimento.Items.Clear();
            ltb_Genero.Items.Clear();
            ltb_CEP.Items.Clear();
            ltb_Email.Items.Clear();
            ltb_Telefone.Items.Clear();
            ltb_Educacao.Items.Clear();
            ltb_Disciplina.Items.Clear();
            ltb_Senha.Items.Clear();



            conn.Open();
            comando.CommandText = "select * from Professor where telefone like '%" + txt_PTelefone.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Professor.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Nascimento.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Educacao.Items.Add(dr[10].ToString());
                    ltb_Disciplina.Items.Add(dr[11].ToString());
                    ltb_Senha.Items.Add(dr[12].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PEducacao_TextChanged(object sender, EventArgs e)
        {
            ltb_Professor.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Sobrenome.Items.Clear();
            ltb_RG.Items.Clear();
            ltb_CPF.Items.Clear();
            ltb_Nascimento.Items.Clear();
            ltb_Genero.Items.Clear();
            ltb_CEP.Items.Clear();
            ltb_Email.Items.Clear();
            ltb_Telefone.Items.Clear();
            ltb_Educacao.Items.Clear();
            ltb_Disciplina.Items.Clear();
            ltb_Senha.Items.Clear();



            conn.Open();
            comando.CommandText = "select * from Professor where Educação like '%" + txt_PEducacao.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Professor.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Nascimento.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Educacao.Items.Add(dr[10].ToString());
                    ltb_Disciplina.Items.Add(dr[11].ToString());
                    ltb_Senha.Items.Add(dr[12].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PDisciplina_TextChanged(object sender, EventArgs e)
        {
            ltb_Professor.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Sobrenome.Items.Clear();
            ltb_RG.Items.Clear();
            ltb_CPF.Items.Clear();
            ltb_Nascimento.Items.Clear();
            ltb_Genero.Items.Clear();
            ltb_CEP.Items.Clear();
            ltb_Email.Items.Clear();
            ltb_Telefone.Items.Clear();
            ltb_Educacao.Items.Clear();
            ltb_Disciplina.Items.Clear();
            ltb_Senha.Items.Clear();



            conn.Open();
            comando.CommandText = "select * from Professor where Disciplina like '%" + txt_PDisciplina.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Professor.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Nascimento.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Educacao.Items.Add(dr[10].ToString());
                    ltb_Disciplina.Items.Add(dr[11].ToString());
                    ltb_Senha.Items.Add(dr[12].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PSenha_TextChanged(object sender, EventArgs e)
        {
            ltb_Professor.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Sobrenome.Items.Clear();
            ltb_RG.Items.Clear();
            ltb_CPF.Items.Clear();
            ltb_Nascimento.Items.Clear();
            ltb_Genero.Items.Clear();
            ltb_CEP.Items.Clear();
            ltb_Email.Items.Clear();
            ltb_Telefone.Items.Clear();
            ltb_Educacao.Items.Clear();
            ltb_Disciplina.Items.Clear();
            ltb_Senha.Items.Clear();



            conn.Open();
            comando.CommandText = "select * from Professor where Senha like '%" + txt_PSenha.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Professor.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Sobrenome.Items.Add(dr[2].ToString());
                    ltb_RG.Items.Add(dr[3].ToString());
                    ltb_CPF.Items.Add(dr[4].ToString());
                    ltb_Nascimento.Items.Add(dr[5].ToString());
                    ltb_Genero.Items.Add(dr[6].ToString());
                    ltb_CEP.Items.Add(dr[7].ToString());
                    ltb_Email.Items.Add(dr[8].ToString());
                    ltb_Telefone.Items.Add(dr[9].ToString());
                    ltb_Educacao.Items.Add(dr[10].ToString());
                    ltb_Disciplina.Items.Add(dr[11].ToString());
                    ltb_Senha.Items.Add(dr[12].ToString());

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
                    return @"SELECT p.Nome, p.Sobrenome, p.Disciplina, c.Nome
             FROM Professor p
             INNER JOIN Curso c ON p.Id_Professor = c.id_professor";

                default:
                    return "";
            }
        }

    }
}
