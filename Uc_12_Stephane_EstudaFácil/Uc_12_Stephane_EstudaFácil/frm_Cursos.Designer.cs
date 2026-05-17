namespace Uc_12_Stephane_EstudaFácil
{
    partial class frm_Cursos
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
            this.lbl_Cursos = new System.Windows.Forms.Label();
            this.ltb_IdProfessor = new System.Windows.Forms.ListBox();
            this.ltb_FreqObrigatoria = new System.Windows.Forms.ListBox();
            this.ltb_Curso = new System.Windows.Forms.ListBox();
            this.ltb_Carga = new System.Windows.Forms.ListBox();
            this.ltb_Nome = new System.Windows.Forms.ListBox();
            this.txt_IdProfessor = new System.Windows.Forms.TextBox();
            this.txt_Carga = new System.Windows.Forms.TextBox();
            this.txt_FreqObrigatoria = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_IdProfessor = new System.Windows.Forms.Label();
            this.lbl_FreqObrigatoria = new System.Windows.Forms.Label();
            this.lbl_Carga = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.txt_PCurso = new System.Windows.Forms.TextBox();
            this.txt_PNome = new System.Windows.Forms.TextBox();
            this.txt_PCarga = new System.Windows.Forms.TextBox();
            this.txt_PFreq = new System.Windows.Forms.TextBox();
            this.txt_PIdProfessor = new System.Windows.Forms.TextBox();
            this.btn_Pesquisas = new System.Windows.Forms.Button();
            this.cbx_Pesquisas = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Cursos
            // 
            this.lbl_Cursos.AutoSize = true;
            this.lbl_Cursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cursos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Cursos.Location = new System.Drawing.Point(13, 13);
            this.lbl_Cursos.Name = "lbl_Cursos";
            this.lbl_Cursos.Size = new System.Drawing.Size(107, 31);
            this.lbl_Cursos.TabIndex = 103;
            this.lbl_Cursos.Text = "Cursos";
            this.lbl_Cursos.Click += new System.EventHandler(this.lbl_Professores_Click);
            // 
            // ltb_IdProfessor
            // 
            this.ltb_IdProfessor.FormattingEnabled = true;
            this.ltb_IdProfessor.Location = new System.Drawing.Point(682, 111);
            this.ltb_IdProfessor.Name = "ltb_IdProfessor";
            this.ltb_IdProfessor.Size = new System.Drawing.Size(150, 277);
            this.ltb_IdProfessor.TabIndex = 102;
            this.ltb_IdProfessor.SelectedIndexChanged += new System.EventHandler(this.ltb_IdProfessor_SelectedIndexChanged);
            // 
            // ltb_FreqObrigatoria
            // 
            this.ltb_FreqObrigatoria.FormattingEnabled = true;
            this.ltb_FreqObrigatoria.Location = new System.Drawing.Point(491, 110);
            this.ltb_FreqObrigatoria.Name = "ltb_FreqObrigatoria";
            this.ltb_FreqObrigatoria.Size = new System.Drawing.Size(182, 277);
            this.ltb_FreqObrigatoria.TabIndex = 101;
            this.ltb_FreqObrigatoria.SelectedIndexChanged += new System.EventHandler(this.ltb_FreqObrigatoria_SelectedIndexChanged);
            // 
            // ltb_Curso
            // 
            this.ltb_Curso.FormattingEnabled = true;
            this.ltb_Curso.Location = new System.Drawing.Point(23, 110);
            this.ltb_Curso.Name = "ltb_Curso";
            this.ltb_Curso.Size = new System.Drawing.Size(150, 277);
            this.ltb_Curso.TabIndex = 100;
            this.ltb_Curso.SelectedIndexChanged += new System.EventHandler(this.ltb_Curso_SelectedIndexChanged);
            // 
            // ltb_Carga
            // 
            this.ltb_Carga.FormattingEnabled = true;
            this.ltb_Carga.Location = new System.Drawing.Point(335, 110);
            this.ltb_Carga.Name = "ltb_Carga";
            this.ltb_Carga.Size = new System.Drawing.Size(150, 277);
            this.ltb_Carga.TabIndex = 99;
            this.ltb_Carga.SelectedIndexChanged += new System.EventHandler(this.ltb_Carga_SelectedIndexChanged);
            // 
            // ltb_Nome
            // 
            this.ltb_Nome.FormattingEnabled = true;
            this.ltb_Nome.Location = new System.Drawing.Point(179, 110);
            this.ltb_Nome.Name = "ltb_Nome";
            this.ltb_Nome.Size = new System.Drawing.Size(150, 277);
            this.ltb_Nome.TabIndex = 98;
            this.ltb_Nome.SelectedIndexChanged += new System.EventHandler(this.ltb_Nome_SelectedIndexChanged);
            // 
            // txt_IdProfessor
            // 
            this.txt_IdProfessor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_IdProfessor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_IdProfessor.Location = new System.Drawing.Point(682, 92);
            this.txt_IdProfessor.Name = "txt_IdProfessor";
            this.txt_IdProfessor.Size = new System.Drawing.Size(150, 13);
            this.txt_IdProfessor.TabIndex = 97;
            // 
            // txt_Carga
            // 
            this.txt_Carga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Carga.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Carga.Location = new System.Drawing.Point(335, 91);
            this.txt_Carga.Name = "txt_Carga";
            this.txt_Carga.Size = new System.Drawing.Size(150, 13);
            this.txt_Carga.TabIndex = 96;
            // 
            // txt_FreqObrigatoria
            // 
            this.txt_FreqObrigatoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_FreqObrigatoria.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_FreqObrigatoria.Location = new System.Drawing.Point(488, 91);
            this.txt_FreqObrigatoria.Name = "txt_FreqObrigatoria";
            this.txt_FreqObrigatoria.Size = new System.Drawing.Size(185, 13);
            this.txt_FreqObrigatoria.TabIndex = 95;
            // 
            // txt_Id
            // 
            this.txt_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Id.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Id.Location = new System.Drawing.Point(23, 91);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(150, 13);
            this.txt_Id.TabIndex = 94;
            // 
            // txt_Nome
            // 
            this.txt_Nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Nome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Nome.Location = new System.Drawing.Point(179, 91);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(150, 13);
            this.txt_Nome.TabIndex = 93;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Id.Location = new System.Drawing.Point(20, 71);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(81, 18);
            this.lbl_Id.TabIndex = 92;
            this.lbl_Id.Text = "Id_Curso:";
            // 
            // lbl_IdProfessor
            // 
            this.lbl_IdProfessor.AutoSize = true;
            this.lbl_IdProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdProfessor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_IdProfessor.Location = new System.Drawing.Point(679, 71);
            this.lbl_IdProfessor.Name = "lbl_IdProfessor";
            this.lbl_IdProfessor.Size = new System.Drawing.Size(110, 18);
            this.lbl_IdProfessor.TabIndex = 91;
            this.lbl_IdProfessor.Text = "Id_Professor:";
            // 
            // lbl_FreqObrigatoria
            // 
            this.lbl_FreqObrigatoria.AutoSize = true;
            this.lbl_FreqObrigatoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FreqObrigatoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_FreqObrigatoria.Location = new System.Drawing.Point(488, 70);
            this.lbl_FreqObrigatoria.Name = "lbl_FreqObrigatoria";
            this.lbl_FreqObrigatoria.Size = new System.Drawing.Size(185, 18);
            this.lbl_FreqObrigatoria.TabIndex = 90;
            this.lbl_FreqObrigatoria.Text = "Frequência Obrigatória:";
            // 
            // lbl_Carga
            // 
            this.lbl_Carga.AutoSize = true;
            this.lbl_Carga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Carga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Carga.Location = new System.Drawing.Point(332, 69);
            this.lbl_Carga.Name = "lbl_Carga";
            this.lbl_Carga.Size = new System.Drawing.Size(119, 18);
            this.lbl_Carga.TabIndex = 89;
            this.lbl_Carga.Text = "Carga Horária:";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Nome.Location = new System.Drawing.Point(176, 70);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(58, 18);
            this.lbl_Nome.TabIndex = 88;
            this.lbl_Nome.Text = "Nome:";
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Salvar.Location = new System.Drawing.Point(733, 476);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(200, 50);
            this.btn_Salvar.TabIndex = 107;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Excluir.Location = new System.Drawing.Point(496, 476);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(200, 50);
            this.btn_Excluir.TabIndex = 106;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Alterar.Location = new System.Drawing.Point(258, 476);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(200, 50);
            this.btn_Alterar.TabIndex = 105;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Novo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Novo.Location = new System.Drawing.Point(21, 476);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(200, 50);
            this.btn_Novo.TabIndex = 104;
            this.btn_Novo.Text = "Novo Curso";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // txt_PCurso
            // 
            this.txt_PCurso.Location = new System.Drawing.Point(23, 393);
            this.txt_PCurso.Name = "txt_PCurso";
            this.txt_PCurso.Size = new System.Drawing.Size(150, 20);
            this.txt_PCurso.TabIndex = 108;
            this.txt_PCurso.TextChanged += new System.EventHandler(this.txt_PCurso_TextChanged);
            // 
            // txt_PNome
            // 
            this.txt_PNome.Location = new System.Drawing.Point(179, 393);
            this.txt_PNome.Name = "txt_PNome";
            this.txt_PNome.Size = new System.Drawing.Size(150, 20);
            this.txt_PNome.TabIndex = 109;
            this.txt_PNome.TextChanged += new System.EventHandler(this.txt_PNome_TextChanged);
            // 
            // txt_PCarga
            // 
            this.txt_PCarga.Location = new System.Drawing.Point(335, 393);
            this.txt_PCarga.Name = "txt_PCarga";
            this.txt_PCarga.Size = new System.Drawing.Size(150, 20);
            this.txt_PCarga.TabIndex = 110;
            this.txt_PCarga.TextChanged += new System.EventHandler(this.txt_PCarga_TextChanged);
            // 
            // txt_PFreq
            // 
            this.txt_PFreq.Location = new System.Drawing.Point(491, 393);
            this.txt_PFreq.Name = "txt_PFreq";
            this.txt_PFreq.Size = new System.Drawing.Size(182, 20);
            this.txt_PFreq.TabIndex = 111;
            this.txt_PFreq.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txt_PIdProfessor
            // 
            this.txt_PIdProfessor.Location = new System.Drawing.Point(682, 394);
            this.txt_PIdProfessor.Name = "txt_PIdProfessor";
            this.txt_PIdProfessor.Size = new System.Drawing.Size(150, 20);
            this.txt_PIdProfessor.TabIndex = 112;
            this.txt_PIdProfessor.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btn_Pesquisas
            // 
            this.btn_Pesquisas.Location = new System.Drawing.Point(1335, 84);
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
            this.cbx_Pesquisas.Location = new System.Drawing.Point(862, 84);
            this.cbx_Pesquisas.Name = "cbx_Pesquisas";
            this.cbx_Pesquisas.Size = new System.Drawing.Size(457, 21);
            this.cbx_Pesquisas.TabIndex = 157;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(862, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(457, 231);
            this.dataGridView1.TabIndex = 156;
            // 
            // frm_Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1712, 931);
            this.Controls.Add(this.btn_Pesquisas);
            this.Controls.Add(this.cbx_Pesquisas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_PIdProfessor);
            this.Controls.Add(this.txt_PFreq);
            this.Controls.Add(this.txt_PCarga);
            this.Controls.Add(this.txt_PNome);
            this.Controls.Add(this.txt_PCurso);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.lbl_Cursos);
            this.Controls.Add(this.ltb_IdProfessor);
            this.Controls.Add(this.ltb_FreqObrigatoria);
            this.Controls.Add(this.ltb_Curso);
            this.Controls.Add(this.ltb_Carga);
            this.Controls.Add(this.ltb_Nome);
            this.Controls.Add(this.txt_IdProfessor);
            this.Controls.Add(this.txt_Carga);
            this.Controls.Add(this.txt_FreqObrigatoria);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_IdProfessor);
            this.Controls.Add(this.lbl_FreqObrigatoria);
            this.Controls.Add(this.lbl_Carga);
            this.Controls.Add(this.lbl_Nome);
            this.Name = "frm_Cursos";
            this.Text = "Cursos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Cursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Cursos;
        private System.Windows.Forms.ListBox ltb_IdProfessor;
        private System.Windows.Forms.ListBox ltb_FreqObrigatoria;
        private System.Windows.Forms.ListBox ltb_Curso;
        private System.Windows.Forms.ListBox ltb_Carga;
        private System.Windows.Forms.ListBox ltb_Nome;
        private System.Windows.Forms.TextBox txt_IdProfessor;
        private System.Windows.Forms.TextBox txt_Carga;
        private System.Windows.Forms.TextBox txt_FreqObrigatoria;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_IdProfessor;
        private System.Windows.Forms.Label lbl_FreqObrigatoria;
        private System.Windows.Forms.Label lbl_Carga;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.TextBox txt_PCurso;
        private System.Windows.Forms.TextBox txt_PNome;
        private System.Windows.Forms.TextBox txt_PCarga;
        private System.Windows.Forms.TextBox txt_PFreq;
        private System.Windows.Forms.TextBox txt_PIdProfessor;
        private System.Windows.Forms.Button btn_Pesquisas;
        private System.Windows.Forms.ComboBox cbx_Pesquisas;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}