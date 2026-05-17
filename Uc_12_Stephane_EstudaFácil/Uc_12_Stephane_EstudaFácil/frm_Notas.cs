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
    public partial class frm_Notas : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=OSA0716366W11-1\\SQLEXPRESS;Initial Catalog=PROJETO05;Integrated Security=True;Encrypt=False");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;

        public frm_Notas()
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

        private void frm_Notas_Load(object sender, EventArgs e)
        {
            cbx_Pesquisas.Items.Add("1 - Alunos com frequência baixa");
            cbx_Pesquisas.SelectedIndex = 0;
        }
        private void CarregarLista()
        {
            ltb_Matricula.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Carga.Items.Clear();
            ltb_FreqObrigatoria.Items.Clear();
            ltb_Horas.Items.Clear();
            ltb_Aproveitamento.Items.Clear();
            

            conn.Open();
            comando.CommandText = "select * from Notas_Frequencia";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Matricula.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Carga.Items.Add(dr[2].ToString());
                    ltb_FreqObrigatoria.Items.Add(dr[3].ToString());
                    ltb_Horas.Items.Add(dr[4].ToString());
                    ltb_Aproveitamento.Items.Add(dr[5].ToString());
                    
                }
            }
            conn.Close();

        }

        private void ltb_Matricula_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Matricula.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Carga.SelectedIndex = l.SelectedIndex;
                ltb_FreqObrigatoria.SelectedIndex = l.SelectedIndex;
                ltb_Horas.SelectedIndex = l.SelectedIndex;
                ltb_Aproveitamento.SelectedIndex = l.SelectedIndex;

                txt_Id.Text = ltb_Matricula.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Carga.Text = ltb_Carga.SelectedItem.ToString();
                txt_FreqObrigatoria.Text = ltb_FreqObrigatoria.SelectedItem.ToString();
                txt_Horas.Text = ltb_Horas.SelectedItem.ToString();
                txt_Aproveitamento.Text = ltb_Aproveitamento.SelectedItem.ToString();
                
            }
        }

        private void ltb_Nome_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Matricula.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Carga.SelectedIndex = l.SelectedIndex;
                ltb_FreqObrigatoria.SelectedIndex = l.SelectedIndex;
                ltb_Horas.SelectedIndex = l.SelectedIndex;
                ltb_Aproveitamento.SelectedIndex = l.SelectedIndex;

                txt_Id.Text = ltb_Matricula.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Carga.Text = ltb_Carga.SelectedItem.ToString();
                txt_FreqObrigatoria.Text = ltb_FreqObrigatoria.SelectedItem.ToString();
                txt_Horas.Text = ltb_Horas.SelectedItem.ToString();
                txt_Aproveitamento.Text = ltb_Aproveitamento.SelectedItem.ToString();

            }
        }

        private void ltb_Carga_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Matricula.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Carga.SelectedIndex = l.SelectedIndex;
                ltb_FreqObrigatoria.SelectedIndex = l.SelectedIndex;
                ltb_Horas.SelectedIndex = l.SelectedIndex;
                ltb_Aproveitamento.SelectedIndex = l.SelectedIndex;

                txt_Id.Text = ltb_Matricula.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Carga.Text = ltb_Carga.SelectedItem.ToString();
                txt_FreqObrigatoria.Text = ltb_FreqObrigatoria.SelectedItem.ToString();
                txt_Horas.Text = ltb_Horas.SelectedItem.ToString();
                txt_Aproveitamento.Text = ltb_Aproveitamento.SelectedItem.ToString();

            }
        }

        private void ltb_FreqObrigatoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Matricula.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Carga.SelectedIndex = l.SelectedIndex;
                ltb_FreqObrigatoria.SelectedIndex = l.SelectedIndex;
                ltb_Horas.SelectedIndex = l.SelectedIndex;
                ltb_Aproveitamento.SelectedIndex = l.SelectedIndex;

                txt_Id.Text = ltb_Matricula.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Carga.Text = ltb_Carga.SelectedItem.ToString();
                txt_FreqObrigatoria.Text = ltb_FreqObrigatoria.SelectedItem.ToString();
                txt_Horas.Text = ltb_Horas.SelectedItem.ToString();
                txt_Aproveitamento.Text = ltb_Aproveitamento.SelectedItem.ToString();

            }
        }

        private void ltb_Horas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Matricula.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Carga.SelectedIndex = l.SelectedIndex;
                ltb_FreqObrigatoria.SelectedIndex = l.SelectedIndex;
                ltb_Horas.SelectedIndex = l.SelectedIndex;
                ltb_Aproveitamento.SelectedIndex = l.SelectedIndex;

                txt_Id.Text = ltb_Matricula.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Carga.Text = ltb_Carga.SelectedItem.ToString();
                txt_FreqObrigatoria.Text = ltb_FreqObrigatoria.SelectedItem.ToString();
                txt_Horas.Text = ltb_Horas.SelectedItem.ToString();
                txt_Aproveitamento.Text = ltb_Aproveitamento.SelectedItem.ToString();

            }
        }

        private void ltb_Aproveitamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Matricula.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Carga.SelectedIndex = l.SelectedIndex;
                ltb_FreqObrigatoria.SelectedIndex = l.SelectedIndex;
                ltb_Horas.SelectedIndex = l.SelectedIndex;
                ltb_Aproveitamento.SelectedIndex = l.SelectedIndex;

                txt_Id.Text = ltb_Matricula.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Carga.Text = ltb_Carga.SelectedItem.ToString();
                txt_FreqObrigatoria.Text = ltb_FreqObrigatoria.SelectedItem.ToString();
                txt_Horas.Text = ltb_Horas.SelectedItem.ToString();
                txt_Aproveitamento.Text = ltb_Aproveitamento.SelectedItem.ToString();

            }
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            txt_Id.Clear();
            txt_Nome.Clear();
            txt_Carga.Clear();
            txt_FreqObrigatoria.Clear();
            txt_Horas.Clear();
            txt_Aproveitamento.Clear();
            txt_Nome.Focus();
            CarregarLista();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            conn.Open();
            comando.CommandText = "insert into Notas_Frequencia(Id_Matricula, nome_curso, Carga_Horaria, frequencia_obrigatoria, Horas_assistidas, Aproveitamento) values ('" + txt_Id.Text + "','" + txt_Nome.Text + "','" + txt_Carga.Text + "','" + txt_FreqObrigatoria.Text + "','" + txt_Horas.Text + "','" + txt_Aproveitamento.Text + "')";
            comando.ExecuteNonQuery();
            conn.Close();
            CarregarLista();
            txt_Id.Clear();
            txt_Nome.Clear();
            txt_Carga.Clear();
            txt_FreqObrigatoria.Clear();
            txt_Horas.Clear();
            txt_Aproveitamento.Clear();
            txt_Nome.Focus();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            conn.Open();
            comando.CommandText = "UPDATE Notas_Frequencia SET " + "nome_curso = '" + txt_Nome.Text + "', " + "Carga_Horaria = '" + txt_Carga.Text + "', " + "frequencia_obrigatoria = '" + txt_FreqObrigatoria.Text + "', " + "Horas_assistidas = '" + txt_Horas.Text + "', " + "Aproveitamento = '" + txt_Aproveitamento.Text + "' " + "WHERE Id_Matricula = " + int.Parse(txt_Id.Text);

            comando.ExecuteNonQuery();
            conn.Close();
            CarregarLista();
            txt_Id.Clear();
            txt_Nome.Clear();
            txt_Carga.Clear();
            txt_FreqObrigatoria.Clear();
            txt_Horas.Clear();
            txt_Aproveitamento.Clear();
            txt_Nome.Focus();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            conn.Open();
            comando.CommandText = "delete from Notas_Frequencia where Id_Matricula = '" + txt_Id.Text + "'";
            comando.ExecuteNonQuery();
            conn.Close();
            CarregarLista();
            txt_Id.Clear();
            txt_Nome.Clear();
            txt_Carga.Clear();
            txt_FreqObrigatoria.Clear();
            txt_Horas.Clear();
            txt_Aproveitamento.Clear();
            txt_Nome.Focus();
        }

        private void txt_PMatricula_TextChanged(object sender, EventArgs e)
        {
            ltb_Matricula.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Carga.Items.Clear();
            ltb_FreqObrigatoria.Items.Clear();
            ltb_Horas.Items.Clear();
            ltb_Aproveitamento.Items.Clear();
            


            conn.Open();
            comando.CommandText = "select * from Notas_frequencia where Id_Matricula like '%" + txt_PMatricula.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Matricula.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Carga.Items.Add(dr[2].ToString());
                    ltb_FreqObrigatoria.Items.Add(dr[3].ToString());
                    ltb_Horas.Items.Add(dr[4].ToString());
                    ltb_Aproveitamento.Items.Add(dr[5].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PNome_TextChanged(object sender, EventArgs e)
        {
            ltb_Matricula.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Carga.Items.Clear();
            ltb_FreqObrigatoria.Items.Clear();
            ltb_Horas.Items.Clear();
            ltb_Aproveitamento.Items.Clear();



            conn.Open();
            comando.CommandText = "select * from Notas_frequencia where nome_curso like '%" + txt_PNome.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Matricula.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Carga.Items.Add(dr[2].ToString());
                    ltb_FreqObrigatoria.Items.Add(dr[3].ToString());
                    ltb_Horas.Items.Add(dr[4].ToString());
                    ltb_Aproveitamento.Items.Add(dr[5].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PCurso_TextChanged(object sender, EventArgs e)
        {
            ltb_Matricula.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Carga.Items.Clear();
            ltb_FreqObrigatoria.Items.Clear();
            ltb_Horas.Items.Clear();
            ltb_Aproveitamento.Items.Clear();



            conn.Open();
            comando.CommandText = "select * from Notas_frequencia where Carga_Horaria like '%" + txt_PCarga.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Matricula.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Carga.Items.Add(dr[2].ToString());
                    ltb_FreqObrigatoria.Items.Add(dr[3].ToString());
                    ltb_Horas.Items.Add(dr[4].ToString());
                    ltb_Aproveitamento.Items.Add(dr[5].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PFreq_TextChanged(object sender, EventArgs e)
        {
            ltb_Matricula.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Carga.Items.Clear();
            ltb_FreqObrigatoria.Items.Clear();
            ltb_Horas.Items.Clear();
            ltb_Aproveitamento.Items.Clear();



            conn.Open();
            comando.CommandText = "select * from Notas_frequencia where frequencia_obrigatoria like '%" + txt_PFreq.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Matricula.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Carga.Items.Add(dr[2].ToString());
                    ltb_FreqObrigatoria.Items.Add(dr[3].ToString());
                    ltb_Horas.Items.Add(dr[4].ToString());
                    ltb_Aproveitamento.Items.Add(dr[5].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PHoras_TextChanged(object sender, EventArgs e)
        {
            ltb_Matricula.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Carga.Items.Clear();
            ltb_FreqObrigatoria.Items.Clear();
            ltb_Horas.Items.Clear();
            ltb_Aproveitamento.Items.Clear();



            conn.Open();
            comando.CommandText = "select * from Notas_frequencia where Horas_assistidas like '%" + txt_PHoras.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Matricula.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Carga.Items.Add(dr[2].ToString());
                    ltb_FreqObrigatoria.Items.Add(dr[3].ToString());
                    ltb_Horas.Items.Add(dr[4].ToString());
                    ltb_Aproveitamento.Items.Add(dr[5].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PAproveitamento_TextChanged(object sender, EventArgs e)
        {
            ltb_Matricula.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Carga.Items.Clear();
            ltb_FreqObrigatoria.Items.Clear();
            ltb_Horas.Items.Clear();
            ltb_Aproveitamento.Items.Clear();



            conn.Open();
            comando.CommandText = "select * from Notas_frequencia where Aproveitamento like '%" + txt_PAproveitamento.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Matricula.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Carga.Items.Add(dr[2].ToString());
                    ltb_FreqObrigatoria.Items.Add(dr[3].ToString());
                    ltb_Horas.Items.Add(dr[4].ToString());
                    ltb_Aproveitamento.Items.Add(dr[5].ToString());

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
                    return @"SELECT a.Nome AS Aluno,
                            n.Horas_assistidas,
                            c.carga_horaria
                     FROM Notas_Frequencia n
                     INNER JOIN Matricula m ON n.Id_Matricula = m.Id_Matricula
                     INNER JOIN Aluno a ON m.Id_Aluno = a.id_aluno
                     INNER JOIN Curso c ON m.Id_Curso = c.Id_Curso
                     WHERE n.Horas_assistidas < c.frequencia_obrigatoria";

                default:
                    return "";
            }
        }
    }
}
