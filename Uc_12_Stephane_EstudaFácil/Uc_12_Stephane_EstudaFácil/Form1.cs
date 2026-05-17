using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uc_12_Stephane_EstudaFácil
{
    public partial class frm_Index : Form
    {
        public frm_Index()
        {
            InitializeComponent();
        }

        private void frm_Index_Load(object sender, EventArgs e)
        {

        }

        private void btn_Alunos_Click(object sender, EventArgs e)
        {
            frm_Alunos frm_Alunos = new frm_Alunos();
            frm_Alunos.Show();
        }

        private void btn_Professores_Click(object sender, EventArgs e)
        {
            frm_Professores frm_Professores = new frm_Professores();
            frm_Professores.Show();
        }

        private void btn_Cursos_Click(object sender, EventArgs e)
        {
            frm_Cursos frm_Cursos = new frm_Cursos();
            frm_Cursos.Show();
        }

        private void btn_Matriculas_Click(object sender, EventArgs e)
        {
            frm_Matriculas frm_Matriculas = new frm_Matriculas();
            frm_Matriculas.Show();
        }

        private void btn_Notas_Click(object sender, EventArgs e)
        {
            frm_Notas frm_Notas = new frm_Notas();
            frm_Notas.Show();

        }

        private void btn_Materiais_Click(object sender, EventArgs e)
        {
            frm_Materiais frm_Materiais = new frm_Materiais();
            frm_Materiais.Show();
        }

        private void btn_Atendentes_Click(object sender, EventArgs e)
        {
            frm_Atendentes frm_Atendentes = new frm_Atendentes();
            frm_Atendentes.Show();
           
        }

        private void btn_Secretaria_Click(object sender, EventArgs e)
        {
            frm_Secretaria frm_Secretaria = new frm_Secretaria();
            frm_Secretaria.Show();
        }
    }
}
