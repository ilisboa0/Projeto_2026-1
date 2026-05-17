namespace Uc_12_Stephane_EstudaFácil
{
    partial class frm_Matriculas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ltb_Matricula = new System.Windows.Forms.ListBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.ltb_IdAluno = new System.Windows.Forms.ListBox();
            this.txt_IdAluno = new System.Windows.Forms.TextBox();
            this.lbl_IdAluno = new System.Windows.Forms.Label();
            this.ltb_IdCurso = new System.Windows.Forms.ListBox();
            this.txt_IdCurso = new System.Windows.Forms.TextBox();
            this.lbl_IdCurso = new System.Windows.Forms.Label();
            this.ltb_IdProfessor = new System.Windows.Forms.ListBox();
            this.txt_IdProfessor = new System.Windows.Forms.TextBox();
            this.lbl_IdProfessor = new System.Windows.Forms.Label();
            this.cbx_Status = new System.Windows.Forms.ComboBox();
            this.ltb_Status = new System.Windows.Forms.ListBox();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.lbl_Matriculas = new System.Windows.Forms.Label();
            this.txt_PMatricula = new System.Windows.Forms.TextBox();
            this.txt_PIdAluno = new System.Windows.Forms.TextBox();
            this.txt_PIdCurso = new System.Windows.Forms.TextBox();
            this.txt_PIdProfessor = new System.Windows.Forms.TextBox();
            this.txt_PStatus = new System.Windows.Forms.TextBox();
            this.btn_Pesquisas = new System.Windows.Forms.Button();
            this.cbx_Pesquisas = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ltb_Matricula
            // 
            this.ltb_Matricula.FormattingEnabled = true;
            this.ltb_Matricula.Location = new System.Drawing.Point(27, 138);
            this.ltb_Matricula.Name = "ltb_Matricula";
            this.ltb_Matricula.Size = new System.Drawing.Size(150, 277);
            this.ltb_Matricula.TabIndex = 103;
            this.ltb_Matricula.SelectedIndexChanged += new System.EventHandler(this.ltb_Matricula_SelectedIndexChanged);
            // 
            // txt_Id
            // 
            this.txt_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Id.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Id.Location = new System.Drawing.Point(27, 119);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(150, 13);
            this.txt_Id.TabIndex = 102;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Id.Location = new System.Drawing.Point(24, 99);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(104, 18);
            this.lbl_Id.TabIndex = 101;
            this.lbl_Id.Text = "Id_Matricula:";
            // 
            // ltb_IdAluno
            // 
            this.ltb_IdAluno.FormattingEnabled = true;
            this.ltb_IdAluno.Location = new System.Drawing.Point(183, 138);
            this.ltb_IdAluno.Name = "ltb_IdAluno";
            this.ltb_IdAluno.Size = new System.Drawing.Size(150, 277);
            this.ltb_IdAluno.TabIndex = 106;
            this.ltb_IdAluno.SelectedIndexChanged += new System.EventHandler(this.ltb_IdAluno_SelectedIndexChanged);
            // 
            // txt_IdAluno
            // 
            this.txt_IdAluno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_IdAluno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_IdAluno.Location = new System.Drawing.Point(183, 119);
            this.txt_IdAluno.Name = "txt_IdAluno";
            this.txt_IdAluno.Size = new System.Drawing.Size(150, 13);
            this.txt_IdAluno.TabIndex = 105;
            // 
            // lbl_IdAluno
            // 
            this.lbl_IdAluno.AutoSize = true;
            this.lbl_IdAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_IdAluno.Location = new System.Drawing.Point(180, 98);
            this.lbl_IdAluno.Name = "lbl_IdAluno";
            this.lbl_IdAluno.Size = new System.Drawing.Size(77, 18);
            this.lbl_IdAluno.TabIndex = 104;
            this.lbl_IdAluno.Text = "Id_Aluno:";
            // 
            // ltb_IdCurso
            // 
            this.ltb_IdCurso.FormattingEnabled = true;
            this.ltb_IdCurso.Location = new System.Drawing.Point(339, 138);
            this.ltb_IdCurso.Name = "ltb_IdCurso";
            this.ltb_IdCurso.Size = new System.Drawing.Size(150, 277);
            this.ltb_IdCurso.TabIndex = 109;
            this.ltb_IdCurso.SelectedIndexChanged += new System.EventHandler(this.ltb_IdCurso_SelectedIndexChanged);
            // 
            // txt_IdCurso
            // 
            this.txt_IdCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_IdCurso.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_IdCurso.Location = new System.Drawing.Point(339, 119);
            this.txt_IdCurso.Name = "txt_IdCurso";
            this.txt_IdCurso.Size = new System.Drawing.Size(150, 13);
            this.txt_IdCurso.TabIndex = 108;
            // 
            // lbl_IdCurso
            // 
            this.lbl_IdCurso.AutoSize = true;
            this.lbl_IdCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdCurso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_IdCurso.Location = new System.Drawing.Point(336, 98);
            this.lbl_IdCurso.Name = "lbl_IdCurso";
            this.lbl_IdCurso.Size = new System.Drawing.Size(81, 18);
            this.lbl_IdCurso.TabIndex = 107;
            this.lbl_IdCurso.Text = "Id_Curso:";
            // 
            // ltb_IdProfessor
            // 
            this.ltb_IdProfessor.FormattingEnabled = true;
            this.ltb_IdProfessor.Location = new System.Drawing.Point(495, 138);
            this.ltb_IdProfessor.Name = "ltb_IdProfessor";
            this.ltb_IdProfessor.Size = new System.Drawing.Size(150, 277);
            this.ltb_IdProfessor.TabIndex = 112;
            this.ltb_IdProfessor.SelectedIndexChanged += new System.EventHandler(this.ltb_IdProfessor_SelectedIndexChanged);
            // 
            // txt_IdProfessor
            // 
            this.txt_IdProfessor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_IdProfessor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_IdProfessor.Location = new System.Drawing.Point(495, 119);
            this.txt_IdProfessor.Name = "txt_IdProfessor";
            this.txt_IdProfessor.Size = new System.Drawing.Size(150, 13);
            this.txt_IdProfessor.TabIndex = 111;
            // 
            // lbl_IdProfessor
            // 
            this.lbl_IdProfessor.AutoSize = true;
            this.lbl_IdProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdProfessor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_IdProfessor.Location = new System.Drawing.Point(492, 98);
            this.lbl_IdProfessor.Name = "lbl_IdProfessor";
            this.lbl_IdProfessor.Size = new System.Drawing.Size(110, 18);
            this.lbl_IdProfessor.TabIndex = 110;
            this.lbl_IdProfessor.Text = "Id_Professor:";
            // 
            // cbx_Status
            // 
            this.cbx_Status.FormattingEnabled = true;
            this.cbx_Status.Items.AddRange(new object[] {
            "Ativo",
            "Trancado",
            "Em Andamento"});
            this.cbx_Status.Location = new System.Drawing.Point(651, 111);
            this.cbx_Status.Name = "cbx_Status";
            this.cbx_Status.Size = new System.Drawing.Size(150, 21);
            this.cbx_Status.TabIndex = 116;
            this.cbx_Status.SelectedIndexChanged += new System.EventHandler(this.cbx_Disciplina_SelectedIndexChanged);
            // 
            // ltb_Status
            // 
            this.ltb_Status.FormattingEnabled = true;
            this.ltb_Status.Location = new System.Drawing.Point(651, 138);
            this.ltb_Status.Name = "ltb_Status";
            this.ltb_Status.Size = new System.Drawing.Size(150, 277);
            this.ltb_Status.TabIndex = 115;
            this.ltb_Status.SelectedIndexChanged += new System.EventHandler(this.ltb_Status_SelectedIndexChanged);
            // 
            // txt_Status
            // 
            this.txt_Status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Status.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Status.Location = new System.Drawing.Point(651, 91);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(150, 13);
            this.txt_Status.TabIndex = 114;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Status.Location = new System.Drawing.Point(648, 70);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(61, 18);
            this.lbl_Status.TabIndex = 113;
            this.lbl_Status.Text = "Status:";
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Salvar.Location = new System.Drawing.Point(739, 475);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(200, 50);
            this.btn_Salvar.TabIndex = 120;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Excluir.Location = new System.Drawing.Point(497, 475);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(200, 50);
            this.btn_Excluir.TabIndex = 119;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Alterar.Location = new System.Drawing.Point(255, 475);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(200, 50);
            this.btn_Alterar.TabIndex = 118;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Novo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Novo.Location = new System.Drawing.Point(25, 475);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(200, 50);
            this.btn_Novo.TabIndex = 117;
            this.btn_Novo.Text = "Nova Matrícula";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // lbl_Matriculas
            // 
            this.lbl_Matriculas.AutoSize = true;
            this.lbl_Matriculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Matriculas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Matriculas.Location = new System.Drawing.Point(21, 39);
            this.lbl_Matriculas.Name = "lbl_Matriculas";
            this.lbl_Matriculas.Size = new System.Drawing.Size(148, 31);
            this.lbl_Matriculas.TabIndex = 121;
            this.lbl_Matriculas.Text = "Matrículas";
            // 
            // txt_PMatricula
            // 
            this.txt_PMatricula.Location = new System.Drawing.Point(27, 421);
            this.txt_PMatricula.Name = "txt_PMatricula";
            this.txt_PMatricula.Size = new System.Drawing.Size(150, 20);
            this.txt_PMatricula.TabIndex = 122;
            this.txt_PMatricula.TextChanged += new System.EventHandler(this.txt_PMatricula_TextChanged);
            // 
            // txt_PIdAluno
            // 
            this.txt_PIdAluno.Location = new System.Drawing.Point(183, 421);
            this.txt_PIdAluno.Name = "txt_PIdAluno";
            this.txt_PIdAluno.Size = new System.Drawing.Size(150, 20);
            this.txt_PIdAluno.TabIndex = 123;
            this.txt_PIdAluno.TextChanged += new System.EventHandler(this.txt_PIdAluno_TextChanged);
            // 
            // txt_PIdCurso
            // 
            this.txt_PIdCurso.Location = new System.Drawing.Point(339, 421);
            this.txt_PIdCurso.Name = "txt_PIdCurso";
            this.txt_PIdCurso.Size = new System.Drawing.Size(150, 20);
            this.txt_PIdCurso.TabIndex = 124;
            this.txt_PIdCurso.TextChanged += new System.EventHandler(this.txt_PIdCurso_TextChanged);
            // 
            // txt_PIdProfessor
            // 
            this.txt_PIdProfessor.Location = new System.Drawing.Point(495, 421);
            this.txt_PIdProfessor.Name = "txt_PIdProfessor";
            this.txt_PIdProfessor.Size = new System.Drawing.Size(150, 20);
            this.txt_PIdProfessor.TabIndex = 125;
            this.txt_PIdProfessor.TextChanged += new System.EventHandler(this.txt_PIdProfessor_TextChanged);
            // 
            // txt_PStatus
            // 
            this.txt_PStatus.Location = new System.Drawing.Point(653, 421);
            this.txt_PStatus.Name = "txt_PStatus";
            this.txt_PStatus.Size = new System.Drawing.Size(150, 20);
            this.txt_PStatus.TabIndex = 126;
            this.txt_PStatus.TextChanged += new System.EventHandler(this.txt_PStatus_TextChanged);
            // 
            // btn_Pesquisas
            // 
            this.btn_Pesquisas.Location = new System.Drawing.Point(1296, 138);
            this.btn_Pesquisas.Name = "btn_Pesquisas";
            this.btn_Pesquisas.Size = new System.Drawing.Size(75, 23);
            this.btn_Pesquisas.TabIndex = 158;
            this.btn_Pesquisas.Text = "Pesquisar";
            this.btn_Pesquisas.UseVisualStyleBackColor = true;
            this.btn_Pesquisas.Click += new System.EventHandler(this.btn_Pesquisas_Click);
            // 
            // cbx_Pesquisas
            // 
            this.cbx_Pesquisas.FormattingEnabled = true;
            this.cbx_Pesquisas.Location = new System.Drawing.Point(823, 138);
            this.cbx_Pesquisas.Name = "cbx_Pesquisas";
            this.cbx_Pesquisas.Size = new System.Drawing.Size(457, 21);
            this.cbx_Pesquisas.TabIndex = 157;
            this.cbx_Pesquisas.SelectedIndexChanged += new System.EventHandler(this.cbx_Pesquisas_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(823, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(457, 231);
            this.dataGridView1.TabIndex = 156;
            // 
            // frm_Matriculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1476, 779);
            this.Controls.Add(this.btn_Pesquisas);
            this.Controls.Add(this.cbx_Pesquisas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_PStatus);
            this.Controls.Add(this.txt_PIdProfessor);
            this.Controls.Add(this.txt_PIdCurso);
            this.Controls.Add(this.txt_PIdAluno);
            this.Controls.Add(this.txt_PMatricula);
            this.Controls.Add(this.lbl_Matriculas);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.cbx_Status);
            this.Controls.Add(this.ltb_Status);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.ltb_IdProfessor);
            this.Controls.Add(this.txt_IdProfessor);
            this.Controls.Add(this.lbl_IdProfessor);
            this.Controls.Add(this.ltb_IdCurso);
            this.Controls.Add(this.txt_IdCurso);
            this.Controls.Add(this.lbl_IdCurso);
            this.Controls.Add(this.ltb_IdAluno);
            this.Controls.Add(this.txt_IdAluno);
            this.Controls.Add(this.lbl_IdAluno);
            this.Controls.Add(this.ltb_Matricula);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.lbl_Id);
            this.Name = "frm_Matriculas";
            this.Text = "Matriculas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Matriculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ltb_Matricula;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.ListBox ltb_IdAluno;
        private System.Windows.Forms.TextBox txt_IdAluno;
        private System.Windows.Forms.Label lbl_IdAluno;
        private System.Windows.Forms.ListBox ltb_IdCurso;
        private System.Windows.Forms.TextBox txt_IdCurso;
        private System.Windows.Forms.Label lbl_IdCurso;
        private System.Windows.Forms.ListBox ltb_IdProfessor;
        private System.Windows.Forms.TextBox txt_IdProfessor;
        private System.Windows.Forms.Label lbl_IdProfessor;
        private System.Windows.Forms.ComboBox cbx_Status;
        private System.Windows.Forms.ListBox ltb_Status;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Label lbl_Matriculas;
        private System.Windows.Forms.TextBox txt_PMatricula;
        private System.Windows.Forms.TextBox txt_PIdAluno;
        private System.Windows.Forms.TextBox txt_PIdCurso;
        private System.Windows.Forms.TextBox txt_PIdProfessor;
        private System.Windows.Forms.TextBox txt_PStatus;
        private System.Windows.Forms.Button btn_Pesquisas;
        private System.Windows.Forms.ComboBox cbx_Pesquisas;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}