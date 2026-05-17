namespace Uc_12_Stephane_EstudaFácil
{
    partial class frm_Materiais
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
            this.lbl_Materiais = new System.Windows.Forms.Label();
            this.ltb_Material = new System.Windows.Forms.ListBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.ltb_Curso = new System.Windows.Forms.ListBox();
            this.ltb_Nome = new System.Windows.Forms.ListBox();
            this.txt_Curso = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.txt_Horas = new System.Windows.Forms.TextBox();
            this.lbl_horas = new System.Windows.Forms.Label();
            this.btn_FileMaterial = new System.Windows.Forms.Button();
            this.ltb_Horas = new System.Windows.Forms.ListBox();
            this.ltb_FileMaterial = new System.Windows.Forms.ListBox();
            this.txt_FileMaterial = new System.Windows.Forms.TextBox();
            this.lbl_FileMaterial = new System.Windows.Forms.Label();
            this.ltb_FileAtividade = new System.Windows.Forms.ListBox();
            this.txt_FileAtividade = new System.Windows.Forms.TextBox();
            this.lbl_FileAtividade = new System.Windows.Forms.Label();
            this.btn_FileAtividade = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.txt_PMaterial = new System.Windows.Forms.TextBox();
            this.txt_PIdCurso = new System.Windows.Forms.TextBox();
            this.txt_PNome = new System.Windows.Forms.TextBox();
            this.txt_PHoras = new System.Windows.Forms.TextBox();
            this.txt_PFileMaterial = new System.Windows.Forms.TextBox();
            this.txt_PFileAtividade = new System.Windows.Forms.TextBox();
            this.btn_Pesquisas = new System.Windows.Forms.Button();
            this.cbx_Pesquisas = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Materiais
            // 
            this.lbl_Materiais.AutoSize = true;
            this.lbl_Materiais.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Materiais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Materiais.Location = new System.Drawing.Point(35, 33);
            this.lbl_Materiais.Name = "lbl_Materiais";
            this.lbl_Materiais.Size = new System.Drawing.Size(133, 31);
            this.lbl_Materiais.TabIndex = 123;
            this.lbl_Materiais.Text = "Materiais";
            // 
            // ltb_Material
            // 
            this.ltb_Material.FormattingEnabled = true;
            this.ltb_Material.Location = new System.Drawing.Point(41, 127);
            this.ltb_Material.Name = "ltb_Material";
            this.ltb_Material.Size = new System.Drawing.Size(150, 277);
            this.ltb_Material.TabIndex = 138;
            this.ltb_Material.SelectedIndexChanged += new System.EventHandler(this.ltb_Material_SelectedIndexChanged);
            // 
            // txt_Id
            // 
            this.txt_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Id.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Id.Location = new System.Drawing.Point(41, 109);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(150, 13);
            this.txt_Id.TabIndex = 137;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Id.Location = new System.Drawing.Point(38, 88);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(95, 18);
            this.lbl_Id.TabIndex = 136;
            this.lbl_Id.Text = "Id_Material:";
            // 
            // ltb_Curso
            // 
            this.ltb_Curso.FormattingEnabled = true;
            this.ltb_Curso.Location = new System.Drawing.Point(197, 127);
            this.ltb_Curso.Name = "ltb_Curso";
            this.ltb_Curso.Size = new System.Drawing.Size(150, 277);
            this.ltb_Curso.TabIndex = 144;
            this.ltb_Curso.SelectedIndexChanged += new System.EventHandler(this.ltb_Curso_SelectedIndexChanged);
            // 
            // ltb_Nome
            // 
            this.ltb_Nome.FormattingEnabled = true;
            this.ltb_Nome.Location = new System.Drawing.Point(353, 127);
            this.ltb_Nome.Name = "ltb_Nome";
            this.ltb_Nome.Size = new System.Drawing.Size(150, 277);
            this.ltb_Nome.TabIndex = 143;
            this.ltb_Nome.SelectedIndexChanged += new System.EventHandler(this.ltb_Nome_SelectedIndexChanged);
            // 
            // txt_Curso
            // 
            this.txt_Curso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Curso.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Curso.Location = new System.Drawing.Point(197, 108);
            this.txt_Curso.Name = "txt_Curso";
            this.txt_Curso.Size = new System.Drawing.Size(150, 13);
            this.txt_Curso.TabIndex = 142;
            // 
            // txt_Nome
            // 
            this.txt_Nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Nome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Nome.Location = new System.Drawing.Point(353, 108);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(150, 13);
            this.txt_Nome.TabIndex = 141;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(194, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 140;
            this.label1.Text = "Id_Curso:";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Nome.Location = new System.Drawing.Point(350, 87);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(147, 18);
            this.lbl_Nome.TabIndex = 139;
            this.lbl_Nome.Text = "Nome do material:";
            // 
            // txt_Horas
            // 
            this.txt_Horas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Horas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Horas.Location = new System.Drawing.Point(509, 108);
            this.txt_Horas.Name = "txt_Horas";
            this.txt_Horas.Size = new System.Drawing.Size(150, 13);
            this.txt_Horas.TabIndex = 146;
            // 
            // lbl_horas
            // 
            this.lbl_horas.AutoSize = true;
            this.lbl_horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_horas.Location = new System.Drawing.Point(506, 87);
            this.lbl_horas.Name = "lbl_horas";
            this.lbl_horas.Size = new System.Drawing.Size(59, 18);
            this.lbl_horas.TabIndex = 145;
            this.lbl_horas.Text = "Horas:";
            // 
            // btn_FileMaterial
            // 
            this.btn_FileMaterial.Location = new System.Drawing.Point(662, 82);
            this.btn_FileMaterial.Name = "btn_FileMaterial";
            this.btn_FileMaterial.Size = new System.Drawing.Size(150, 23);
            this.btn_FileMaterial.TabIndex = 147;
            this.btn_FileMaterial.Text = "Upload de Arquivos";
            this.btn_FileMaterial.UseVisualStyleBackColor = true;
            this.btn_FileMaterial.Click += new System.EventHandler(this.btn_Arquivo_Click);
            // 
            // ltb_Horas
            // 
            this.ltb_Horas.FormattingEnabled = true;
            this.ltb_Horas.Location = new System.Drawing.Point(509, 127);
            this.ltb_Horas.Name = "ltb_Horas";
            this.ltb_Horas.Size = new System.Drawing.Size(150, 277);
            this.ltb_Horas.TabIndex = 148;
            this.ltb_Horas.SelectedIndexChanged += new System.EventHandler(this.ltb_Horas_SelectedIndexChanged);
            // 
            // ltb_FileMaterial
            // 
            this.ltb_FileMaterial.FormattingEnabled = true;
            this.ltb_FileMaterial.Location = new System.Drawing.Point(662, 127);
            this.ltb_FileMaterial.Name = "ltb_FileMaterial";
            this.ltb_FileMaterial.Size = new System.Drawing.Size(150, 277);
            this.ltb_FileMaterial.TabIndex = 151;
            this.ltb_FileMaterial.SelectedIndexChanged += new System.EventHandler(this.ltb_FileMaterial_SelectedIndexChanged);
            // 
            // txt_FileMaterial
            // 
            this.txt_FileMaterial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_FileMaterial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_FileMaterial.Location = new System.Drawing.Point(662, 108);
            this.txt_FileMaterial.Name = "txt_FileMaterial";
            this.txt_FileMaterial.Size = new System.Drawing.Size(150, 13);
            this.txt_FileMaterial.TabIndex = 150;
            // 
            // lbl_FileMaterial
            // 
            this.lbl_FileMaterial.AutoSize = true;
            this.lbl_FileMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FileMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_FileMaterial.Location = new System.Drawing.Point(659, 61);
            this.lbl_FileMaterial.Name = "lbl_FileMaterial";
            this.lbl_FileMaterial.Size = new System.Drawing.Size(134, 18);
            this.lbl_FileMaterial.TabIndex = 149;
            this.lbl_FileMaterial.Text = "Arquivo Material:";
            // 
            // ltb_FileAtividade
            // 
            this.ltb_FileAtividade.FormattingEnabled = true;
            this.ltb_FileAtividade.Location = new System.Drawing.Point(818, 127);
            this.ltb_FileAtividade.Name = "ltb_FileAtividade";
            this.ltb_FileAtividade.Size = new System.Drawing.Size(150, 277);
            this.ltb_FileAtividade.TabIndex = 155;
            this.ltb_FileAtividade.SelectedIndexChanged += new System.EventHandler(this.ltb_FileAtividade_SelectedIndexChanged);
            // 
            // txt_FileAtividade
            // 
            this.txt_FileAtividade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_FileAtividade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_FileAtividade.Location = new System.Drawing.Point(818, 108);
            this.txt_FileAtividade.Name = "txt_FileAtividade";
            this.txt_FileAtividade.Size = new System.Drawing.Size(150, 13);
            this.txt_FileAtividade.TabIndex = 154;
            // 
            // lbl_FileAtividade
            // 
            this.lbl_FileAtividade.AutoSize = true;
            this.lbl_FileAtividade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FileAtividade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_FileAtividade.Location = new System.Drawing.Point(815, 61);
            this.lbl_FileAtividade.Name = "lbl_FileAtividade";
            this.lbl_FileAtividade.Size = new System.Drawing.Size(141, 18);
            this.lbl_FileAtividade.TabIndex = 153;
            this.lbl_FileAtividade.Text = "Arquivo Atividade:";
            // 
            // btn_FileAtividade
            // 
            this.btn_FileAtividade.Location = new System.Drawing.Point(815, 82);
            this.btn_FileAtividade.Name = "btn_FileAtividade";
            this.btn_FileAtividade.Size = new System.Drawing.Size(153, 23);
            this.btn_FileAtividade.TabIndex = 152;
            this.btn_FileAtividade.Text = "Upload de Arquivos";
            this.btn_FileAtividade.UseVisualStyleBackColor = true;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Salvar.Location = new System.Drawing.Point(756, 469);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(200, 50);
            this.btn_Salvar.TabIndex = 159;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Excluir.Location = new System.Drawing.Point(509, 469);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(200, 50);
            this.btn_Excluir.TabIndex = 158;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Alterar.Location = new System.Drawing.Point(267, 469);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(200, 50);
            this.btn_Alterar.TabIndex = 157;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Novo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Novo.Location = new System.Drawing.Point(37, 469);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(200, 50);
            this.btn_Novo.TabIndex = 156;
            this.btn_Novo.Text = "Novo Material";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // txt_PMaterial
            // 
            this.txt_PMaterial.Location = new System.Drawing.Point(41, 410);
            this.txt_PMaterial.Name = "txt_PMaterial";
            this.txt_PMaterial.Size = new System.Drawing.Size(150, 20);
            this.txt_PMaterial.TabIndex = 160;
            this.txt_PMaterial.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_PIdCurso
            // 
            this.txt_PIdCurso.Location = new System.Drawing.Point(197, 410);
            this.txt_PIdCurso.Name = "txt_PIdCurso";
            this.txt_PIdCurso.Size = new System.Drawing.Size(150, 20);
            this.txt_PIdCurso.TabIndex = 161;
            this.txt_PIdCurso.TextChanged += new System.EventHandler(this.txt_PIdCurso_TextChanged);
            // 
            // txt_PNome
            // 
            this.txt_PNome.Location = new System.Drawing.Point(353, 410);
            this.txt_PNome.Name = "txt_PNome";
            this.txt_PNome.Size = new System.Drawing.Size(150, 20);
            this.txt_PNome.TabIndex = 162;
            this.txt_PNome.TextChanged += new System.EventHandler(this.txt_PNome_TextChanged);
            // 
            // txt_PHoras
            // 
            this.txt_PHoras.Location = new System.Drawing.Point(509, 410);
            this.txt_PHoras.Name = "txt_PHoras";
            this.txt_PHoras.Size = new System.Drawing.Size(150, 20);
            this.txt_PHoras.TabIndex = 163;
            this.txt_PHoras.TextChanged += new System.EventHandler(this.txt_PHoras_TextChanged);
            // 
            // txt_PFileMaterial
            // 
            this.txt_PFileMaterial.Location = new System.Drawing.Point(662, 410);
            this.txt_PFileMaterial.Name = "txt_PFileMaterial";
            this.txt_PFileMaterial.Size = new System.Drawing.Size(150, 20);
            this.txt_PFileMaterial.TabIndex = 164;
            // 
            // txt_PFileAtividade
            // 
            this.txt_PFileAtividade.Location = new System.Drawing.Point(818, 410);
            this.txt_PFileAtividade.Name = "txt_PFileAtividade";
            this.txt_PFileAtividade.Size = new System.Drawing.Size(150, 20);
            this.txt_PFileAtividade.TabIndex = 165;
            // 
            // btn_Pesquisas
            // 
            this.btn_Pesquisas.Location = new System.Drawing.Point(1458, 81);
            this.btn_Pesquisas.Name = "btn_Pesquisas";
            this.btn_Pesquisas.Size = new System.Drawing.Size(75, 23);
            this.btn_Pesquisas.TabIndex = 168;
            this.btn_Pesquisas.Text = "Pesquisar";
            this.btn_Pesquisas.UseVisualStyleBackColor = true;
            this.btn_Pesquisas.Click += new System.EventHandler(this.btn_Pesquisas_Click);
            // 
            // cbx_Pesquisas
            // 
            this.cbx_Pesquisas.FormattingEnabled = true;
            this.cbx_Pesquisas.Location = new System.Drawing.Point(985, 81);
            this.cbx_Pesquisas.Name = "cbx_Pesquisas";
            this.cbx_Pesquisas.Size = new System.Drawing.Size(457, 21);
            this.cbx_Pesquisas.TabIndex = 167;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(985, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(457, 231);
            this.dataGridView1.TabIndex = 166;
            // 
            // frm_Materiais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1608, 669);
            this.Controls.Add(this.btn_Pesquisas);
            this.Controls.Add(this.cbx_Pesquisas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_PFileAtividade);
            this.Controls.Add(this.txt_PFileMaterial);
            this.Controls.Add(this.txt_PHoras);
            this.Controls.Add(this.txt_PNome);
            this.Controls.Add(this.txt_PIdCurso);
            this.Controls.Add(this.txt_PMaterial);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.ltb_FileAtividade);
            this.Controls.Add(this.txt_FileAtividade);
            this.Controls.Add(this.lbl_FileAtividade);
            this.Controls.Add(this.btn_FileAtividade);
            this.Controls.Add(this.ltb_FileMaterial);
            this.Controls.Add(this.txt_FileMaterial);
            this.Controls.Add(this.lbl_FileMaterial);
            this.Controls.Add(this.ltb_Horas);
            this.Controls.Add(this.btn_FileMaterial);
            this.Controls.Add(this.txt_Horas);
            this.Controls.Add(this.lbl_horas);
            this.Controls.Add(this.ltb_Curso);
            this.Controls.Add(this.ltb_Nome);
            this.Controls.Add(this.txt_Curso);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.ltb_Material);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_Materiais);
            this.Name = "frm_Materiais";
            this.Text = "frm_Materiais";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Materiais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Materiais;
        private System.Windows.Forms.ListBox ltb_Material;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.ListBox ltb_Curso;
        private System.Windows.Forms.ListBox ltb_Nome;
        private System.Windows.Forms.TextBox txt_Curso;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.TextBox txt_Horas;
        private System.Windows.Forms.Label lbl_horas;
        private System.Windows.Forms.Button btn_FileMaterial;
        private System.Windows.Forms.ListBox ltb_Horas;
        private System.Windows.Forms.ListBox ltb_FileMaterial;
        private System.Windows.Forms.TextBox txt_FileMaterial;
        private System.Windows.Forms.Label lbl_FileMaterial;
        private System.Windows.Forms.ListBox ltb_FileAtividade;
        private System.Windows.Forms.TextBox txt_FileAtividade;
        private System.Windows.Forms.Label lbl_FileAtividade;
        private System.Windows.Forms.Button btn_FileAtividade;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.TextBox txt_PMaterial;
        private System.Windows.Forms.TextBox txt_PIdCurso;
        private System.Windows.Forms.TextBox txt_PNome;
        private System.Windows.Forms.TextBox txt_PHoras;
        private System.Windows.Forms.TextBox txt_PFileMaterial;
        private System.Windows.Forms.TextBox txt_PFileAtividade;
        private System.Windows.Forms.Button btn_Pesquisas;
        private System.Windows.Forms.ComboBox cbx_Pesquisas;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}