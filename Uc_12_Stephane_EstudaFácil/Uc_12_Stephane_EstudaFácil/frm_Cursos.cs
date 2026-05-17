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
    public partial class frm_Cursos : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=OSA0716366W11-1\\SQLEXPRESS;Initial Catalog=PROJETO05;Integrated Security=True;Encrypt=False");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;

        public frm_Cursos()
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
        private void lbl_Professores_Click(object sender, EventArgs e)
        {

        }

        private void frm_Cursos_Load(object sender, EventArgs e)
        {
            cbx_Pesquisas.Items.Add("1 - Cursos com seus Professores");
            cbx_Pesquisas.SelectedIndex = 0;
        }
        private void CarregarLista()
        {
            ltb_Curso.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Carga.Items.Clear();
            ltb_FreqObrigatoria.Items.Clear();
            ltb_IdProfessor.Items.Clear();

            conn.Open();
            comando.CommandText = "select * from Curso";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Curso.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Carga.Items.Add(dr[2].ToString());
                    ltb_FreqObrigatoria.Items.Add(dr[3].ToString());
                    ltb_IdProfessor.Items.Add(dr[4].ToString());
                    

                }
            }
            conn.Close();

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            conn.Open();
            comando.CommandText = "insert into Curso(Nome, carga_horaria, frequencia_obrigatoria, id_Professor) values ('" + txt_Nome.Text + "','" + txt_Carga.Text + "','" + txt_FreqObrigatoria.Text + "','" + txt_IdProfessor.Text + "')";
            comando.ExecuteNonQuery();
            conn.Close();
            CarregarLista();
            txt_Id.Clear();
            txt_Nome.Clear();
            txt_Carga.Clear();
            txt_FreqObrigatoria.Clear();
            txt_IdProfessor.Clear();
            txt_Nome.Focus();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            conn.Open();
            comando.CommandText = "delete from Curso where id_curso = '" + txt_Id.Text + "'";
            comando.ExecuteNonQuery();
            conn.Close();
            CarregarLista();
            txt_Id.Clear();
            txt_Nome.Clear();
            txt_Carga.Clear();
            txt_FreqObrigatoria.Clear();
            txt_IdProfessor.Clear();
            txt_Nome.Focus();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            conn.Open();
            comando.CommandText = "UPDATE Curso SET " + "Nome = '" + txt_Nome.Text + "', " + "carga_horaria = '" + txt_Carga.Text + "', " + "frequencia_obrigatoria = '" + txt_FreqObrigatoria.Text + "', " + "id_Professor = '" + txt_IdProfessor.Text + "' " + "WHERE id_curso = " + int.Parse(txt_Id.Text);

            comando.ExecuteNonQuery();
            conn.Close();
            CarregarLista();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            txt_Id.Clear();
            txt_Nome.Clear();
            txt_Carga.Clear();
            txt_FreqObrigatoria.Clear();
            txt_IdProfessor.Clear();
            txt_Nome.Focus();
            CarregarLista();
        }

        private void ltb_Curso_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Curso.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Carga.SelectedIndex = l.SelectedIndex;
                ltb_FreqObrigatoria.SelectedIndex = l.SelectedIndex;
                ltb_IdProfessor.SelectedIndex = l.SelectedIndex;
                

                txt_Id.Text = ltb_Curso.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Carga.Text = ltb_Carga.SelectedItem.ToString();
                txt_FreqObrigatoria.Text = ltb_FreqObrigatoria.SelectedItem.ToString();
                txt_IdProfessor.Text = ltb_IdProfessor.SelectedItem.ToString();
               


            }
        }

        private void ltb_Nome_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Curso.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Carga.SelectedIndex = l.SelectedIndex;
                ltb_FreqObrigatoria.SelectedIndex = l.SelectedIndex;
                ltb_IdProfessor.SelectedIndex = l.SelectedIndex;


                txt_Id.Text = ltb_Curso.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Carga.Text = ltb_Carga.SelectedItem.ToString();
                txt_FreqObrigatoria.Text = ltb_FreqObrigatoria.SelectedItem.ToString();
                txt_IdProfessor.Text = ltb_IdProfessor.SelectedItem.ToString();



            }
        }

        private void ltb_Carga_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Curso.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Carga.SelectedIndex = l.SelectedIndex;
                ltb_FreqObrigatoria.SelectedIndex = l.SelectedIndex;
                ltb_IdProfessor.SelectedIndex = l.SelectedIndex;


                txt_Id.Text = ltb_Curso.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Carga.Text = ltb_Carga.SelectedItem.ToString();
                txt_FreqObrigatoria.Text = ltb_FreqObrigatoria.SelectedItem.ToString();
                txt_IdProfessor.Text = ltb_IdProfessor.SelectedItem.ToString();



            }
        }

        private void ltb_FreqObrigatoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Curso.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Carga.SelectedIndex = l.SelectedIndex;
                ltb_FreqObrigatoria.SelectedIndex = l.SelectedIndex;
                ltb_IdProfessor.SelectedIndex = l.SelectedIndex;


                txt_Id.Text = ltb_Curso.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Carga.Text = ltb_Carga.SelectedItem.ToString();
                txt_FreqObrigatoria.Text = ltb_FreqObrigatoria.SelectedItem.ToString();
                txt_IdProfessor.Text = ltb_IdProfessor.SelectedItem.ToString();



            }
        }

        private void ltb_IdProfessor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Curso.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Carga.SelectedIndex = l.SelectedIndex;
                ltb_FreqObrigatoria.SelectedIndex = l.SelectedIndex;
                ltb_IdProfessor.SelectedIndex = l.SelectedIndex;


                txt_Id.Text = ltb_Curso.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Carga.Text = ltb_Carga.SelectedItem.ToString();
                txt_FreqObrigatoria.Text = ltb_FreqObrigatoria.SelectedItem.ToString();
                txt_IdProfessor.Text = ltb_IdProfessor.SelectedItem.ToString();



            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            ltb_Curso.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Carga.Items.Clear();
            ltb_FreqObrigatoria.Items.Clear();
            ltb_IdProfessor.Items.Clear();



            conn.Open();
            comando.CommandText = "select * from Curso where frequencia_obrigatoria like '%" + txt_PFreq.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Curso.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Carga.Items.Add(dr[2].ToString());
                    ltb_FreqObrigatoria.Items.Add(dr[3].ToString());
                    ltb_IdProfessor.Items.Add(dr[4].ToString());

                }
            }
            conn.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            ltb_Curso.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Carga.Items.Clear();
            ltb_FreqObrigatoria.Items.Clear();
            ltb_IdProfessor.Items.Clear();



            conn.Open();
            comando.CommandText = "select * from Curso where id_Professor like '%" + txt_PIdProfessor.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Curso.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Carga.Items.Add(dr[2].ToString());
                    ltb_FreqObrigatoria.Items.Add(dr[3].ToString());
                    ltb_IdProfessor.Items.Add(dr[4].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PCurso_TextChanged(object sender, EventArgs e)
        {
            ltb_Curso.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Carga.Items.Clear();
            ltb_FreqObrigatoria.Items.Clear();
            ltb_IdProfessor.Items.Clear();
            


            conn.Open();
            comando.CommandText = "select * from Curso where Id_Curso like '%" + txt_PCurso.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Curso.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Carga.Items.Add(dr[2].ToString());
                    ltb_FreqObrigatoria.Items.Add(dr[3].ToString());
                    ltb_IdProfessor.Items.Add(dr[4].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PNome_TextChanged(object sender, EventArgs e)
        {
            ltb_Curso.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Carga.Items.Clear();
            ltb_FreqObrigatoria.Items.Clear();
            ltb_IdProfessor.Items.Clear();



            conn.Open();
            comando.CommandText = "select * from Curso where Nome like '%" + txt_PNome.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Curso.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Carga.Items.Add(dr[2].ToString());
                    ltb_FreqObrigatoria.Items.Add(dr[3].ToString());
                    ltb_IdProfessor.Items.Add(dr[4].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PCarga_TextChanged(object sender, EventArgs e)
        {
            ltb_Curso.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Carga.Items.Clear();
            ltb_FreqObrigatoria.Items.Clear();
            ltb_IdProfessor.Items.Clear();



            conn.Open();
            comando.CommandText = "select * from Curso where carga_horaria like '%" + txt_PCarga.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Curso.Items.Add(dr[0].ToString());
                    ltb_Nome.Items.Add(dr[1].ToString());
                    ltb_Carga.Items.Add(dr[2].ToString());
                    ltb_FreqObrigatoria.Items.Add(dr[3].ToString());
                    ltb_IdProfessor.Items.Add(dr[4].ToString());

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
                    return @"SELECT c.Nome AS Curso,
                    p.Nome AS Professor,
                    p.Disciplina
             FROM Curso c
             INNER JOIN Professor p 
             ON c.id_Professor = p.id_professor";

                default:
                    return "";
            }
        }
    }
}
