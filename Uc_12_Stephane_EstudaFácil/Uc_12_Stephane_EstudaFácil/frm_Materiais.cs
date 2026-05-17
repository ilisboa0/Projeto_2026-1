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
    public partial class frm_Materiais : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=OSA0716366W11-1\\SQLEXPRESS;Initial Catalog=PROJETO05;Integrated Security=True;Encrypt=False");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;

        public frm_Materiais()
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


        private void CarregarLista()
        {
            ltb_Material.Items.Clear();
            ltb_Curso.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Horas.Items.Clear();
            ltb_FileMaterial.Items.Clear();
            ltb_FileAtividade.Items.Clear();
           

            conn.Open();
            comando.CommandText = "select * from Materiais";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Material.Items.Add(dr[0].ToString());
                    ltb_Curso.Items.Add(dr[1].ToString());
                    ltb_Nome.Items.Add(dr[2].ToString());
                    ltb_Horas.Items.Add(dr[3].ToString());
                    ltb_FileMaterial.Items.Add(dr[4].ToString());
                    ltb_FileAtividade.Items.Add(dr[5].ToString());
                    
                }
            }
            conn.Close();

        }
        private void btn_Arquivo_Click(object sender, EventArgs e)
        {

        }

        private void frm_Materiais_Load(object sender, EventArgs e)
        {
            cbx_Pesquisas.Items.Add("1 - Materiais com curso");
            cbx_Pesquisas.SelectedIndex = 0;
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            conn.Open();
            comando.CommandText = "insert into Materiais(Id_Curso, Nome_do_Material, Horas) values ('" + txt_Curso.Text + "','" + txt_Nome.Text + "','" + txt_Horas.Text + "')";
            comando.ExecuteNonQuery();
            conn.Close();
            CarregarLista();
            txt_Id.Clear();
            txt_Curso.Clear();
            txt_Nome.Clear();
            txt_Horas.Clear();
            txt_FileMaterial.Clear();
            txt_FileAtividade.Clear();
            txt_Nome.Focus();
        }

        private void ltb_Material_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Material.SelectedIndex = l.SelectedIndex;
                ltb_Curso.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Horas.SelectedIndex = l.SelectedIndex;
                ltb_FileMaterial.SelectedIndex = l.SelectedIndex;
                ltb_FileAtividade.SelectedIndex = l.SelectedIndex;


                txt_Id.Text = ltb_Material.SelectedItem.ToString();
                txt_Curso.Text = ltb_Curso.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Horas.Text = ltb_Horas.SelectedItem.ToString();
                txt_FileMaterial.Text = ltb_FileMaterial.SelectedItem.ToString();
                txt_FileAtividade.Text = ltb_FileAtividade.SelectedItem.ToString();


            }
        }

        private void ltb_Curso_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Material.SelectedIndex = l.SelectedIndex;
                ltb_Curso.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Horas.SelectedIndex = l.SelectedIndex;
                ltb_FileMaterial.SelectedIndex = l.SelectedIndex;
                ltb_FileAtividade.SelectedIndex = l.SelectedIndex;


                txt_Id.Text = ltb_Material.SelectedItem.ToString();
                txt_Curso.Text = ltb_Curso.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Horas.Text = ltb_Horas.SelectedItem.ToString();
                txt_FileMaterial.Text = ltb_FileMaterial.SelectedItem.ToString();
                txt_FileAtividade.Text = ltb_FileAtividade.SelectedItem.ToString();


            }
        }

        private void ltb_Nome_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Material.SelectedIndex = l.SelectedIndex;
                ltb_Curso.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Horas.SelectedIndex = l.SelectedIndex;
                ltb_FileMaterial.SelectedIndex = l.SelectedIndex;
                ltb_FileAtividade.SelectedIndex = l.SelectedIndex;


                txt_Id.Text = ltb_Material.SelectedItem.ToString();
                txt_Curso.Text = ltb_Curso.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Horas.Text = ltb_Horas.SelectedItem.ToString();
                txt_FileMaterial.Text = ltb_FileMaterial.SelectedItem.ToString();
                txt_FileAtividade.Text = ltb_FileAtividade.SelectedItem.ToString();


            }
        }

        private void ltb_Horas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Material.SelectedIndex = l.SelectedIndex;
                ltb_Curso.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Horas.SelectedIndex = l.SelectedIndex;
                ltb_FileMaterial.SelectedIndex = l.SelectedIndex;
                ltb_FileAtividade.SelectedIndex = l.SelectedIndex;


                txt_Id.Text = ltb_Material.SelectedItem.ToString();
                txt_Curso.Text = ltb_Curso.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Horas.Text = ltb_Horas.SelectedItem.ToString();
                txt_FileMaterial.Text = ltb_FileMaterial.SelectedItem.ToString();
                txt_FileAtividade.Text = ltb_FileAtividade.SelectedItem.ToString();


            }
        }

        private void ltb_FileMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Material.SelectedIndex = l.SelectedIndex;
                ltb_Curso.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Horas.SelectedIndex = l.SelectedIndex;
                ltb_FileMaterial.SelectedIndex = l.SelectedIndex;
                ltb_FileAtividade.SelectedIndex = l.SelectedIndex;


                txt_Id.Text = ltb_Material.SelectedItem.ToString();
                txt_Curso.Text = ltb_Curso.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Horas.Text = ltb_Horas.SelectedItem.ToString();
                txt_FileMaterial.Text = ltb_FileMaterial.SelectedItem.ToString();
                txt_FileAtividade.Text = ltb_FileAtividade.SelectedItem.ToString();


            }
        }

        private void ltb_FileAtividade_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ltb_Material.SelectedIndex = l.SelectedIndex;
                ltb_Curso.SelectedIndex = l.SelectedIndex;
                ltb_Nome.SelectedIndex = l.SelectedIndex;
                ltb_Horas.SelectedIndex = l.SelectedIndex;
                ltb_FileMaterial.SelectedIndex = l.SelectedIndex;
                ltb_FileAtividade.SelectedIndex = l.SelectedIndex;


                txt_Id.Text = ltb_Material.SelectedItem.ToString();
                txt_Curso.Text = ltb_Curso.SelectedItem.ToString();
                txt_Nome.Text = ltb_Nome.SelectedItem.ToString();
                txt_Horas.Text = ltb_Horas.SelectedItem.ToString();
                txt_FileMaterial.Text = ltb_FileMaterial.SelectedItem.ToString();
                txt_FileAtividade.Text = ltb_FileAtividade.SelectedItem.ToString();


            }
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            txt_Id.Clear();
            txt_Curso.Clear();
            txt_Nome.Clear();
            txt_Horas.Clear();
            txt_FileMaterial.Clear();
            txt_FileAtividade.Clear();
            txt_Nome.Focus();
            CarregarLista();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            conn.Open();
            comando.CommandText = "UPDATE Materiais SET " + "Id_Curso = '" + txt_Curso.Text + "', " + "Nome_do_Material = '" + txt_Nome.Text + "', " + "Horas = '" + txt_Horas.Text + "' " + "WHERE Id_Material = " + int.Parse(txt_Id.Text);

            comando.ExecuteNonQuery();
            conn.Close();
            CarregarLista();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            conn.Open();
            comando.CommandText = "delete from Materiais where Id_Material = '" + txt_Id.Text + "'";
            comando.ExecuteNonQuery();
            conn.Close();
            CarregarLista();
            txt_Id.Clear();
            txt_Curso.Clear();
            txt_Nome.Clear();
            txt_Horas.Clear();
            txt_FileMaterial.Clear();
            txt_FileAtividade.Clear();
            txt_Nome.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ltb_Material.Items.Clear();
            ltb_Curso.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Horas.Items.Clear();
            ltb_FileMaterial.Items.Clear();
            ltb_FileAtividade.Items.Clear();


            conn.Open();
            comando.CommandText = "select * from Materiais where Id_Material like '%" + txt_PMaterial.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Material.Items.Add(dr[0].ToString());
                    ltb_Curso.Items.Add(dr[1].ToString());
                    ltb_Nome.Items.Add(dr[2].ToString());
                    ltb_Horas.Items.Add(dr[3].ToString());
                    ltb_FileMaterial.Items.Add(dr[4].ToString());
                    ltb_FileAtividade.Items.Add(dr[5].ToString());
                    
                }
            }
            conn.Close();
        }

        private void txt_PIdCurso_TextChanged(object sender, EventArgs e)
        {
            ltb_Material.Items.Clear();
            ltb_Curso.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Horas.Items.Clear();
            ltb_FileMaterial.Items.Clear();
            ltb_FileAtividade.Items.Clear();


            conn.Open();
            comando.CommandText = "select * from Materiais where Id_Curso like '%" + txt_PIdCurso.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Material.Items.Add(dr[0].ToString());
                    ltb_Curso.Items.Add(dr[1].ToString());
                    ltb_Nome.Items.Add(dr[2].ToString());
                    ltb_Horas.Items.Add(dr[3].ToString());
                    ltb_FileMaterial.Items.Add(dr[4].ToString());
                    ltb_FileAtividade.Items.Add(dr[5].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PNome_TextChanged(object sender, EventArgs e)
        {
            ltb_Material.Items.Clear();
            ltb_Curso.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Horas.Items.Clear();
            ltb_FileMaterial.Items.Clear();
            ltb_FileAtividade.Items.Clear();


            conn.Open();
            comando.CommandText = "select * from Materiais where Nome_do_Material like '%" + txt_PNome.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Material.Items.Add(dr[0].ToString());
                    ltb_Curso.Items.Add(dr[1].ToString());
                    ltb_Nome.Items.Add(dr[2].ToString());
                    ltb_Horas.Items.Add(dr[3].ToString());
                    ltb_FileMaterial.Items.Add(dr[4].ToString());
                    ltb_FileAtividade.Items.Add(dr[5].ToString());

                }
            }
            conn.Close();
        }

        private void txt_PHoras_TextChanged(object sender, EventArgs e)
        {
            ltb_Material.Items.Clear();
            ltb_Curso.Items.Clear();
            ltb_Nome.Items.Clear();
            ltb_Horas.Items.Clear();
            ltb_FileMaterial.Items.Clear();
            ltb_FileAtividade.Items.Clear();


            conn.Open();
            comando.CommandText = "select * from Materiais where Horas like '%" + txt_PHoras.Text + "%' ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ltb_Material.Items.Add(dr[0].ToString());
                    ltb_Curso.Items.Add(dr[1].ToString());
                    ltb_Nome.Items.Add(dr[2].ToString());
                    ltb_Horas.Items.Add(dr[3].ToString());
                    ltb_FileMaterial.Items.Add(dr[4].ToString());
                    ltb_FileAtividade.Items.Add(dr[5].ToString());

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
                    return @"SELECT m.Id_Material,
                            m.Nome_do_Material,
                            c.Nome,
                            m.Horas
                     FROM Materiais m
                     INNER JOIN Curso c ON m.Id_Curso = c.Id_Curso";

                default:
                    return "";
            }
        }

    }
}
