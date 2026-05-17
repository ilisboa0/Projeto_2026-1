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
    public partial class frm_Secretaria : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=OSA0716366W11-1\\SQLEXPRESS;Initial Catalog=PROJETO05;Integrated Security=True;Encrypt=False");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;

        public frm_Secretaria()
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

        private void frm_Secretaria_Load(object sender, EventArgs e)
        {
            cbx_Pesquisas.Items.Add("1 - Todos os atendimentos ");
            cbx_Pesquisas.SelectedIndex = 0;
        }
        private void CarregarLista()
        {
            ltb_Atendimento.Items.Clear();
            ltb_IdAtendente.Items.Clear();
            ltb_IdAluno.Items.Clear();
            ltb_Tipo.Items.Clear();
            ltb_Descricao.Items.Clear();
            ltb_Arquivos.Items.Clear();
            ltb_Status.Items.Clear();
            

            conn.Open();
            comando.CommandText = "select * from Atendimento_Secretaria";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Atendimento.Items.Add(dr[0].ToString());
                    ltb_IdAtendente.Items.Add(dr[1].ToString());
                    ltb_IdAluno.Items.Add(dr[2].ToString());
                    ltb_Tipo.Items.Add(dr[3].ToString());
                    ltb_Descricao.Items.Add(dr[4].ToString());
                    ltb_Arquivos.Items.Add(dr[5].ToString());
                    ltb_Status.Items.Add(dr[6].ToString());
                }
            }
            conn.Close();

        }

        private void ltb_Atendimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Atendimento.SelectedIndex = l.SelectedIndex;
                ltb_IdAtendente.SelectedIndex = l.SelectedIndex;
                ltb_IdAluno.SelectedIndex = l.SelectedIndex;
                ltb_Tipo.SelectedIndex = l.SelectedIndex;
                ltb_Descricao.SelectedIndex = l.SelectedIndex;
                ltb_Arquivos.SelectedIndex = l.SelectedIndex;
                ltb_Status.SelectedIndex = l.SelectedIndex;

                txt_Atendimento.Text = ltb_Atendimento.SelectedItem.ToString();
                txt_IdAtendente.Text = ltb_IdAtendente.SelectedItem.ToString();
                txt_IdAluno.Text = ltb_IdAluno.SelectedItem.ToString();
                txt_Tipo.Text = ltb_Tipo.SelectedItem.ToString();
                txt_Descricao.Text = ltb_Descricao.SelectedItem.ToString();
                txt_Arquivos.Text = ltb_Arquivos.SelectedItem.ToString();
                txt_Status.Text = ltb_Status.SelectedItem.ToString();


            }
        }

        private void ltb_IdAtendente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Atendimento.SelectedIndex = l.SelectedIndex;
                ltb_IdAtendente.SelectedIndex = l.SelectedIndex;
                ltb_IdAluno.SelectedIndex = l.SelectedIndex;
                ltb_Tipo.SelectedIndex = l.SelectedIndex;
                ltb_Descricao.SelectedIndex = l.SelectedIndex;
                ltb_Arquivos.SelectedIndex = l.SelectedIndex;
                ltb_Status.SelectedIndex = l.SelectedIndex;

                txt_Atendimento.Text = ltb_Atendimento.SelectedItem.ToString();
                txt_IdAtendente.Text = ltb_IdAtendente.SelectedItem.ToString();
                txt_IdAluno.Text = ltb_IdAluno.SelectedItem.ToString();
                txt_Tipo.Text = ltb_Tipo.SelectedItem.ToString();
                txt_Descricao.Text = ltb_Descricao.SelectedItem.ToString();
                txt_Arquivos.Text = ltb_Arquivos.SelectedItem.ToString();
                txt_Status.Text = ltb_Status.SelectedItem.ToString();


            }
        }

        private void ltb_IdAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Atendimento.SelectedIndex = l.SelectedIndex;
                ltb_IdAtendente.SelectedIndex = l.SelectedIndex;
                ltb_IdAluno.SelectedIndex = l.SelectedIndex;
                ltb_Tipo.SelectedIndex = l.SelectedIndex;
                ltb_Descricao.SelectedIndex = l.SelectedIndex;
                ltb_Arquivos.SelectedIndex = l.SelectedIndex;
                ltb_Status.SelectedIndex = l.SelectedIndex;

                txt_Atendimento.Text = ltb_Atendimento.SelectedItem.ToString();
                txt_IdAtendente.Text = ltb_IdAtendente.SelectedItem.ToString();
                txt_IdAluno.Text = ltb_IdAluno.SelectedItem.ToString();
                txt_Tipo.Text = ltb_Tipo.SelectedItem.ToString();
                txt_Descricao.Text = ltb_Descricao.SelectedItem.ToString();
                txt_Arquivos.Text = ltb_Arquivos.SelectedItem.ToString();
                txt_Status.Text = ltb_Status.SelectedItem.ToString();


            }
        }

        private void ltb_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Atendimento.SelectedIndex = l.SelectedIndex;
                ltb_IdAtendente.SelectedIndex = l.SelectedIndex;
                ltb_IdAluno.SelectedIndex = l.SelectedIndex;
                ltb_Tipo.SelectedIndex = l.SelectedIndex;
                ltb_Descricao.SelectedIndex = l.SelectedIndex;
                ltb_Arquivos.SelectedIndex = l.SelectedIndex;
                ltb_Status.SelectedIndex = l.SelectedIndex;

                txt_Atendimento.Text = ltb_Atendimento.SelectedItem.ToString();
                txt_IdAtendente.Text = ltb_IdAtendente.SelectedItem.ToString();
                txt_IdAluno.Text = ltb_IdAluno.SelectedItem.ToString();
                txt_Tipo.Text = ltb_Tipo.SelectedItem.ToString();
                txt_Descricao.Text = ltb_Descricao.SelectedItem.ToString();
                txt_Arquivos.Text = ltb_Arquivos.SelectedItem.ToString();
                txt_Status.Text = ltb_Status.SelectedItem.ToString();


            }
        }

        private void ltb_Descricao_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Atendimento.SelectedIndex = l.SelectedIndex;
                ltb_IdAtendente.SelectedIndex = l.SelectedIndex;
                ltb_IdAluno.SelectedIndex = l.SelectedIndex;
                ltb_Tipo.SelectedIndex = l.SelectedIndex;
                ltb_Descricao.SelectedIndex = l.SelectedIndex;
                ltb_Arquivos.SelectedIndex = l.SelectedIndex;
                ltb_Status.SelectedIndex = l.SelectedIndex;

                txt_Atendimento.Text = ltb_Atendimento.SelectedItem.ToString();
                txt_IdAtendente.Text = ltb_IdAtendente.SelectedItem.ToString();
                txt_IdAluno.Text = ltb_IdAluno.SelectedItem.ToString();
                txt_Tipo.Text = ltb_Tipo.SelectedItem.ToString();
                txt_Descricao.Text = ltb_Descricao.SelectedItem.ToString();
                txt_Arquivos.Text = ltb_Arquivos.SelectedItem.ToString();
                txt_Status.Text = ltb_Status.SelectedItem.ToString();


            }
        }

        private void ltb_Arquivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Atendimento.SelectedIndex = l.SelectedIndex;
                ltb_IdAtendente.SelectedIndex = l.SelectedIndex;
                ltb_IdAluno.SelectedIndex = l.SelectedIndex;
                ltb_Tipo.SelectedIndex = l.SelectedIndex;
                ltb_Descricao.SelectedIndex = l.SelectedIndex;
                ltb_Arquivos.SelectedIndex = l.SelectedIndex;
                ltb_Status.SelectedIndex = l.SelectedIndex;

                txt_Atendimento.Text = ltb_Atendimento.SelectedItem.ToString();
                txt_IdAtendente.Text = ltb_IdAtendente.SelectedItem.ToString();
                txt_IdAluno.Text = ltb_IdAluno.SelectedItem.ToString();
                txt_Tipo.Text = ltb_Tipo.SelectedItem.ToString();
                txt_Descricao.Text = ltb_Descricao.SelectedItem.ToString();
                txt_Arquivos.Text = ltb_Arquivos.SelectedItem.ToString();
                txt_Status.Text = ltb_Status.SelectedItem.ToString();


            }
        }

        private void ltb_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Atendimento.SelectedIndex = l.SelectedIndex;
                ltb_IdAtendente.SelectedIndex = l.SelectedIndex;
                ltb_IdAluno.SelectedIndex = l.SelectedIndex;
                ltb_Tipo.SelectedIndex = l.SelectedIndex;
                ltb_Descricao.SelectedIndex = l.SelectedIndex;
                ltb_Arquivos.SelectedIndex = l.SelectedIndex;
                ltb_Status.SelectedIndex = l.SelectedIndex;

                txt_Atendimento.Text = ltb_Atendimento.SelectedItem.ToString();
                txt_IdAtendente.Text = ltb_IdAtendente.SelectedItem.ToString();
                txt_IdAluno.Text = ltb_IdAluno.SelectedItem.ToString();
                txt_Tipo.Text = ltb_Tipo.SelectedItem.ToString();
                txt_Descricao.Text = ltb_Descricao.SelectedItem.ToString();
                txt_Arquivos.Text = ltb_Arquivos.SelectedItem.ToString();
                txt_Status.Text = ltb_Status.SelectedItem.ToString();


            }
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            txt_Atendimento.Clear();
            txt_IdAtendente.Clear();
            txt_IdAluno.Clear();
            txt_Tipo.Clear();
            txt_Descricao.Clear();
            txt_Arquivos.Clear();
            txt_Status.Clear();
            txt_Atendimento.Focus();
            CarregarLista();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            conn.Open();
            comando.CommandText = "insert into Atendimento_Secretaria( Id_Atendente, Id_Aluno, Tipo_de_Solicitação, Descrição_pedido, Status_do_Atendimento) values ('" + txt_IdAtendente.Text + "','" + txt_IdAluno.Text + "','" + txt_Tipo.Text + "','" + txt_Descricao.Text + "','" + txt_Status.Text + "')";
            comando.ExecuteNonQuery();
            conn.Close();
            CarregarLista();
            txt_Atendimento.Clear();
            txt_IdAtendente.Clear();
            txt_IdAluno.Clear();
            txt_Tipo.Clear();
            txt_Descricao.Clear();
            txt_Arquivos.Clear();
            txt_Status.Clear();
            txt_Atendimento.Focus();
        }

        private void cbx_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            txt_Tipo.Text = cbx_Tipo.Text;
        }

        private void cbx_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Status.Text = cbx_Status.Text;
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            int.Parse(txt_Atendimento.Text);


            conn.Open();
            comando.CommandText = "UPDATE Atendimento_Secretaria SET " + "Id_Atendente = '" + txt_IdAtendente.Text + "', " + "Id_Aluno = '" + txt_IdAluno.Text + "', " + "Tipo_de_Solicitação = '" + txt_Tipo.Text + "', " + "Descrição_pedido = '" + txt_Descricao.Text + "', " + "Status_do_Atendimento = '" + txt_Status.Text + "' " + "WHERE Id_Atendimento = " + int.Parse(txt_Atendimento.Text);
            comando.ExecuteNonQuery();
            conn.Close();
            CarregarLista();
            txt_Atendimento.Clear();
            txt_IdAtendente.Clear();
            txt_IdAluno.Clear();
            txt_Tipo.Clear();
            txt_Descricao.Clear();
            txt_Arquivos.Clear();
            txt_Status.Clear();
            txt_Atendimento.Focus();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            conn.Open();
            comando.CommandText = "delete from Atendimento_Secretaria where Id_Atendimento = '" + txt_Atendimento.Text + "'";
            comando.ExecuteNonQuery();
            conn.Close();
            CarregarLista();
            txt_Atendimento.Clear();
            txt_IdAtendente.Clear();
            txt_IdAluno.Clear();
            txt_Tipo.Clear();
            txt_Descricao.Clear();
            txt_Arquivos.Clear();
            txt_Status.Clear();
            txt_Atendimento.Focus();
        }

        private void txt_PAtendimento_TextChanged(object sender, EventArgs e)
        {
            ltb_Atendimento.Items.Clear();
            ltb_IdAtendente.Items.Clear();
            ltb_IdAluno.Items.Clear();
            ltb_Tipo.Items.Clear();
            ltb_Descricao.Items.Clear();
            ltb_Status.Items.Clear();


            conn.Open();
            comando.CommandText = "select * from Atendimento_Secretaria where Id_Atendimento like '%" + txt_PAtendimento.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Atendimento.Items.Add(dr[0].ToString());
                    ltb_IdAtendente.Items.Add(dr[1].ToString());
                    ltb_IdAluno.Items.Add(dr[2].ToString());
                    ltb_Tipo.Items.Add(dr[3].ToString());
                    ltb_Descricao.Items.Add(dr[4].ToString());
                    ltb_Status.Items.Add(dr[6].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PIdAtendente_TextChanged(object sender, EventArgs e)
        {
            ltb_Atendimento.Items.Clear();
            ltb_IdAtendente.Items.Clear();
            ltb_IdAluno.Items.Clear();
            ltb_Tipo.Items.Clear();
            ltb_Descricao.Items.Clear();
            ltb_Status.Items.Clear();


            conn.Open();
            comando.CommandText = "select * from Atendimento_Secretaria where Id_Atendente like '%" + txt_PIdAtendente.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Atendimento.Items.Add(dr[0].ToString());
                    ltb_IdAtendente.Items.Add(dr[1].ToString());
                    ltb_IdAluno.Items.Add(dr[2].ToString());
                    ltb_Tipo.Items.Add(dr[3].ToString());
                    ltb_Descricao.Items.Add(dr[4].ToString());
                    ltb_Status.Items.Add(dr[6].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PIdAluno_TextChanged(object sender, EventArgs e)
        {
            ltb_Atendimento.Items.Clear();
            ltb_IdAtendente.Items.Clear();
            ltb_IdAluno.Items.Clear();
            ltb_Tipo.Items.Clear();
            ltb_Descricao.Items.Clear();
            ltb_Status.Items.Clear();


            conn.Open();
            comando.CommandText = "select * from Atendimento_Secretaria where Id_Aluno like '%" + txt_PIdAluno.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Atendimento.Items.Add(dr[0].ToString());
                    ltb_IdAtendente.Items.Add(dr[1].ToString());
                    ltb_IdAluno.Items.Add(dr[2].ToString());
                    ltb_Tipo.Items.Add(dr[3].ToString());
                    ltb_Descricao.Items.Add(dr[4].ToString());
                    ltb_Status.Items.Add(dr[6].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PTipo_TextChanged(object sender, EventArgs e)
        {
            ltb_Atendimento.Items.Clear();
            ltb_IdAtendente.Items.Clear();
            ltb_IdAluno.Items.Clear();
            ltb_Tipo.Items.Clear();
            ltb_Descricao.Items.Clear();
            ltb_Status.Items.Clear();


            conn.Open();
            comando.CommandText = "select * from Atendimento_Secretaria where Tipo_de_Solicitação like '%" + txt_PTipo.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Atendimento.Items.Add(dr[0].ToString());
                    ltb_IdAtendente.Items.Add(dr[1].ToString());
                    ltb_IdAluno.Items.Add(dr[2].ToString());
                    ltb_Tipo.Items.Add(dr[3].ToString());
                    ltb_Descricao.Items.Add(dr[4].ToString());
                    ltb_Status.Items.Add(dr[6].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PDescricao_TextChanged(object sender, EventArgs e)
        {
            ltb_Atendimento.Items.Clear();
            ltb_IdAtendente.Items.Clear();
            ltb_IdAluno.Items.Clear();
            ltb_Tipo.Items.Clear();
            ltb_Descricao.Items.Clear();
            ltb_Status.Items.Clear();


            conn.Open();
            comando.CommandText = "select * from Atendimento_Secretaria where Descrição_pedido like '%" + txt_PDescricao.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Atendimento.Items.Add(dr[0].ToString());
                    ltb_IdAtendente.Items.Add(dr[1].ToString());
                    ltb_IdAluno.Items.Add(dr[2].ToString());
                    ltb_Tipo.Items.Add(dr[3].ToString());
                    ltb_Descricao.Items.Add(dr[4].ToString());
                    ltb_Status.Items.Add(dr[6].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PStatus_TextChanged(object sender, EventArgs e)
        {
            ltb_Atendimento.Items.Clear();
            ltb_IdAtendente.Items.Clear();
            ltb_IdAluno.Items.Clear();
            ltb_Tipo.Items.Clear();
            ltb_Descricao.Items.Clear();
            ltb_Status.Items.Clear();


            conn.Open();
            comando.CommandText = "select * from Atendimento_Secretaria where Status_do_atendimento like '%" + txt_PStatus.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Atendimento.Items.Add(dr[0].ToString());
                    ltb_IdAtendente.Items.Add(dr[1].ToString());
                    ltb_IdAluno.Items.Add(dr[2].ToString());
                    ltb_Tipo.Items.Add(dr[3].ToString());
                    ltb_Descricao.Items.Add(dr[4].ToString());
                    ltb_Status.Items.Add(dr[6].ToString());

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
                    return @"SELECT a.Nome AS Atendente,
                            al.nome AS Aluno,
                            s.Tipo_de_Solicitação
                     FROM Atendimento_Secretaria s
                     INNER JOIN Atendente a 
                        ON s.Id_Atendente = a.Id_Atendente
                     INNER JOIN Aluno al 
                        ON s.Id_Aluno = al.id_aluno
                     WHERE s.Status_do_atendimento = 'Concluído'";

                default:
                    return "";
            }
        }
    
    }
}
