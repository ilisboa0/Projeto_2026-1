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
    public partial class frm_Matriculas : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=OSA0716366W11-1\\SQLEXPRESS;Initial Catalog=PROJETO05;Integrated Security=True;Encrypt=False");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;

        public frm_Matriculas()
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
        private void frm_Matriculas_Load(object sender, EventArgs e)
        {
            cbx_Pesquisas.Items.Add("1 - Matrículas com Aluno e Curso");
            cbx_Pesquisas.SelectedIndex = 0;
        }
        private void CarregarLista()
        {
            ltb_Matricula.Items.Clear();
            ltb_IdAluno.Items.Clear();
            ltb_IdCurso.Items.Clear();
            ltb_IdProfessor.Items.Clear();
            ltb_Status.Items.Clear();
       

            conn.Open();
            comando.CommandText = "select * from Matricula";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Matricula.Items.Add(dr[0].ToString());
                    ltb_IdAluno.Items.Add(dr[1].ToString());
                    ltb_IdCurso.Items.Add(dr[2].ToString());
                    ltb_IdProfessor.Items.Add(dr[3].ToString());
                    ltb_Status.Items.Add(dr[4].ToString());
                    

                }
            }
            conn.Close();

        }

        private void cbx_Disciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Status.Text = cbx_Status.Text;
        }

        private void ltb_Matricula_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Matricula.SelectedIndex = l.SelectedIndex;
                ltb_IdAluno.SelectedIndex = l.SelectedIndex;
                ltb_IdCurso.SelectedIndex = l.SelectedIndex;
                ltb_IdProfessor.SelectedIndex = l.SelectedIndex;
                ltb_Status.SelectedIndex = l.SelectedIndex;
                


                txt_Id.Text = ltb_Matricula.SelectedItem.ToString();
                txt_IdAluno.Text = ltb_IdAluno.SelectedItem.ToString();
                txt_IdCurso.Text = ltb_IdCurso.SelectedItem.ToString();
                txt_IdProfessor.Text = ltb_IdProfessor.SelectedItem.ToString();
                txt_Status.Text = ltb_Status.SelectedItem.ToString();
                


            }
        }

        private void ltb_IdAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Matricula.SelectedIndex = l.SelectedIndex;
                ltb_IdAluno.SelectedIndex = l.SelectedIndex;
                ltb_IdCurso.SelectedIndex = l.SelectedIndex;
                ltb_IdProfessor.SelectedIndex = l.SelectedIndex;
                ltb_Status.SelectedIndex = l.SelectedIndex;



                txt_Id.Text = ltb_Matricula.SelectedItem.ToString();
                txt_IdAluno.Text = ltb_IdAluno.SelectedItem.ToString();
                txt_IdCurso.Text = ltb_IdCurso.SelectedItem.ToString();
                txt_IdProfessor.Text = ltb_IdProfessor.SelectedItem.ToString();
                txt_Status.Text = ltb_Status.SelectedItem.ToString();



            }
        }

        private void ltb_IdCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Matricula.SelectedIndex = l.SelectedIndex;
                ltb_IdAluno.SelectedIndex = l.SelectedIndex;
                ltb_IdCurso.SelectedIndex = l.SelectedIndex;
                ltb_IdProfessor.SelectedIndex = l.SelectedIndex;
                ltb_Status.SelectedIndex = l.SelectedIndex;



                txt_Id.Text = ltb_Matricula.SelectedItem.ToString();
                txt_IdAluno.Text = ltb_IdAluno.SelectedItem.ToString();
                txt_IdCurso.Text = ltb_IdCurso.SelectedItem.ToString();
                txt_IdProfessor.Text = ltb_IdProfessor.SelectedItem.ToString();
                txt_Status.Text = ltb_Status.SelectedItem.ToString();



            }
        }

        private void ltb_IdProfessor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Matricula.SelectedIndex = l.SelectedIndex;
                ltb_IdAluno.SelectedIndex = l.SelectedIndex;
                ltb_IdCurso.SelectedIndex = l.SelectedIndex;
                ltb_IdProfessor.SelectedIndex = l.SelectedIndex;
                ltb_Status.SelectedIndex = l.SelectedIndex;



                txt_Id.Text = ltb_Matricula.SelectedItem.ToString();
                txt_IdAluno.Text = ltb_IdAluno.SelectedItem.ToString();
                txt_IdCurso.Text = ltb_IdCurso.SelectedItem.ToString();
                txt_IdProfessor.Text = ltb_IdProfessor.SelectedItem.ToString();
                txt_Status.Text = ltb_Status.SelectedItem.ToString();



            }
        }

        private void ltb_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Matricula.SelectedIndex = l.SelectedIndex;
                ltb_IdAluno.SelectedIndex = l.SelectedIndex;
                ltb_IdCurso.SelectedIndex = l.SelectedIndex;
                ltb_IdProfessor.SelectedIndex = l.SelectedIndex;
                ltb_Status.SelectedIndex = l.SelectedIndex;



                txt_Id.Text = ltb_Matricula.SelectedItem.ToString();
                txt_IdAluno.Text = ltb_IdAluno.SelectedItem.ToString();
                txt_IdCurso.Text = ltb_IdCurso.SelectedItem.ToString();
                txt_IdProfessor.Text = ltb_IdProfessor.SelectedItem.ToString();
                txt_Status.Text = ltb_Status.SelectedItem.ToString();



            }
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            txt_Id.Clear();
            txt_IdAluno.Clear();
            txt_IdCurso.Clear();
            txt_IdProfessor.Clear();
            txt_Status.Clear();
            txt_IdAluno.Focus();
            CarregarLista();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            conn.Open();
            comando.CommandText = "insert into Matricula(Id_Aluno, Id_Curso, id_Professor, Status) values ('" + txt_IdAluno.Text + "','" + txt_IdCurso.Text + "','" + txt_IdProfessor.Text + "','" + txt_Status.Text + "')";
            comando.ExecuteNonQuery();
            conn.Close();
            CarregarLista();
            txt_Id.Clear();
            txt_IdAluno.Clear();
            txt_IdCurso.Clear();
            txt_IdProfessor.Clear();
            txt_Status.Clear();
            txt_IdAluno.Focus();
            
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            conn.Open();
            comando.CommandText = "UPDATE Matricula SET " + "Id_Aluno = '" + txt_IdAluno.Text + "', " + "Id_Curso = '" + txt_IdCurso.Text + "', " + "id_Professor = '" + txt_IdProfessor.Text + "', " + "Status = '" + txt_Status.Text + "' " + "WHERE Id_Matricula = " + int.Parse(txt_Id.Text);

            comando.ExecuteNonQuery();
            conn.Close();
            CarregarLista();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            conn.Open();
            comando.CommandText = "delete from Matricula where Id_Matricula = '" + txt_Id.Text + "'";
            comando.ExecuteNonQuery();
            conn.Close();
            CarregarLista();
            txt_Id.Clear();
            txt_IdAluno.Clear();
            txt_IdCurso.Clear();
            txt_IdProfessor.Clear();
            txt_Status.Clear();
            txt_IdAluno.Focus();
        }

        private void txt_PMatricula_TextChanged(object sender, EventArgs e)
        {
            ltb_Matricula.Items.Clear();
            ltb_IdAluno.Items.Clear();
            ltb_IdCurso.Items.Clear();
            ltb_IdProfessor.Items.Clear();
            ltb_Status.Items.Clear();


            conn.Open();
            comando.CommandText = "select * from Matricula where Id_Matricula like '%" + txt_PMatricula.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Matricula.Items.Add(dr[0].ToString());
                    ltb_IdAluno.Items.Add(dr[1].ToString());
                    ltb_IdCurso.Items.Add(dr[2].ToString());
                    ltb_IdProfessor.Items.Add(dr[3].ToString());
                    ltb_Status.Items.Add(dr[4].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PIdAluno_TextChanged(object sender, EventArgs e)
        {
            ltb_Matricula.Items.Clear();
            ltb_IdAluno.Items.Clear();
            ltb_IdCurso.Items.Clear();
            ltb_IdProfessor.Items.Clear();
            ltb_Status.Items.Clear();


            conn.Open();
            comando.CommandText = "select * from Matricula where Id_Aluno like '%" + txt_PIdAluno.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Matricula.Items.Add(dr[0].ToString());
                    ltb_IdAluno.Items.Add(dr[1].ToString());
                    ltb_IdCurso.Items.Add(dr[2].ToString());
                    ltb_IdProfessor.Items.Add(dr[3].ToString());
                    ltb_Status.Items.Add(dr[4].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PIdCurso_TextChanged(object sender, EventArgs e)
        {
            ltb_Matricula.Items.Clear();
            ltb_IdAluno.Items.Clear();
            ltb_IdCurso.Items.Clear();
            ltb_IdProfessor.Items.Clear();
            ltb_Status.Items.Clear();


            conn.Open();
            comando.CommandText = "select * from Matricula where Id_Curso like '%" + txt_PIdCurso.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Matricula.Items.Add(dr[0].ToString());
                    ltb_IdAluno.Items.Add(dr[1].ToString());
                    ltb_IdCurso.Items.Add(dr[2].ToString());
                    ltb_IdProfessor.Items.Add(dr[3].ToString());
                    ltb_Status.Items.Add(dr[4].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PIdProfessor_TextChanged(object sender, EventArgs e)
        {
            ltb_Matricula.Items.Clear();
            ltb_IdAluno.Items.Clear();
            ltb_IdCurso.Items.Clear();
            ltb_IdProfessor.Items.Clear();
            ltb_Status.Items.Clear();


            conn.Open();
            comando.CommandText = "select * from Matricula where id_Professor like '%" + txt_PIdProfessor.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Matricula.Items.Add(dr[0].ToString());
                    ltb_IdAluno.Items.Add(dr[1].ToString());
                    ltb_IdCurso.Items.Add(dr[2].ToString());
                    ltb_IdProfessor.Items.Add(dr[3].ToString());
                    ltb_Status.Items.Add(dr[4].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PStatus_TextChanged(object sender, EventArgs e)
        {
            ltb_Matricula.Items.Clear();
            ltb_IdAluno.Items.Clear();
            ltb_IdCurso.Items.Clear();
            ltb_IdProfessor.Items.Clear();
            ltb_Status.Items.Clear();


            conn.Open();
            comando.CommandText = "select * from Matricula where Status like '%" + txt_PStatus.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Matricula.Items.Add(dr[0].ToString());
                    ltb_IdAluno.Items.Add(dr[1].ToString());
                    ltb_IdCurso.Items.Add(dr[2].ToString());
                    ltb_IdProfessor.Items.Add(dr[3].ToString());
                    ltb_Status.Items.Add(dr[4].ToString());

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
                    return @"SELECT m.Id_Matricula,
                    a.Nome AS Aluno,
                    c.Nome AS Curso,
                    m.Status
             FROM Matricula m
             INNER JOIN Aluno a ON m.Id_Aluno = a.id_aluno
             INNER JOIN Curso c ON m.Id_Curso = c.Id_Curso";

                

                default:
                    return "";
            }
        }

        private void cbx_Pesquisas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
