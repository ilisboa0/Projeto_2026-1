namespace Uc_12_Stephane_EstudaFácil
{
    partial class frm_Secretaria
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
            this.lbl_Atendimento = new System.Windows.Forms.Label();
            this.ltb_IdAtendente = new System.Windows.Forms.ListBox();
            this.txt_IdAtendente = new System.Windows.Forms.TextBox();
            this.lbl_IdAtendente = new System.Windows.Forms.Label();
            this.ltb_IdAluno = new System.Windows.Forms.ListBox();
            this.txt_IdAluno = new System.Windows.Forms.TextBox();
            this.lbl_IdAluno = new System.Windows.Forms.Label();
            this.ltb_Atendimento = new System.Windows.Forms.ListBox();
            this.txt_Atendimento = new System.Windows.Forms.TextBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.ltb_Arquivos = new System.Windows.Forms.ListBox();
            this.txt_Arquivos = new System.Windows.Forms.TextBox();
            this.lbl_Arquivos = new System.Windows.Forms.Label();
            this.ltb_Descricao = new System.Windows.Forms.ListBox();
            this.txt_Descricao = new System.Windows.Forms.TextBox();
            this.lbl_Descricao = new System.Windows.Forms.Label();
            this.ltb_Tipo = new System.Windows.Forms.ListBox();
            this.txt_Tipo = new System.Windows.Forms.TextBox();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.cbx_Tipo = new System.Windows.Forms.ComboBox();
            this.btn_FileAtendimento = new System.Windows.Forms.Button();
            this.cbx_Status = new System.Windows.Forms.ComboBox();
            this.ltb_Status = new System.Windows.Forms.ListBox();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.txt_PAtendimento = new System.Windows.Forms.TextBox();
            this.txt_PIdAtendente = new System.Windows.Forms.TextBox();
            this.txt_PIdAluno = new System.Windows.Forms.TextBox();
            this.txt_PTipo = new System.Windows.Forms.TextBox();
            this.txt_PDescricao = new System.Windows.Forms.TextBox();
            this.txt_PStatus = new System.Windows.Forms.TextBox();
            this.btn_Pesquisas = new System.Windows.Forms.Button();
            this.cbx_Pesquisas = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Atendimento
            // 
            this.lbl_Atendimento.AutoSize = true;
            this.lbl_Atendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Atendimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Atendimento.Location = new System.Drawing.Point(12, 24);
            this.lbl_Atendimento.Name = "lbl_Atendimento";
            this.lbl_Atendimento.Size = new System.Drawing.Size(319, 31);
            this.lbl_Atendimento.TabIndex = 131;
            this.lbl_Atendimento.Text = "Atendimento Secretaria";
            // 
            // ltb_IdAtendente
            // 
            this.ltb_IdAtendente.FormattingEnabled = true;
            this.ltb_IdAtendente.Location = new System.Drawing.Point(170, 117);
            this.ltb_IdAtendente.Name = "ltb_IdAtendente";
            this.ltb_IdAtendente.Size = new System.Drawing.Size(150, 277);
            this.ltb_IdAtendente.TabIndex = 130;
            this.ltb_IdAtendente.SelectedIndexChanged += new System.EventHandler(this.ltb_IdAtendente_SelectedIndexChanged);
            // 
            // txt_IdAtendente
            // 
            this.txt_IdAtendente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_IdAtendente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_IdAtendente.Location = new System.Drawing.Point(170, 98);
            this.txt_IdAtendente.Name = "txt_IdAtendente";
            this.txt_IdAtendente.Size = new System.Drawing.Size(150, 13);
            this.txt_IdAtendente.TabIndex = 129;
            // 
            // lbl_IdAtendente
            // 
            this.lbl_IdAtendente.AutoSize = true;
            this.lbl_IdAtendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdAtendente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_IdAtendente.Location = new System.Drawing.Point(167, 77);
            this.lbl_IdAtendente.Name = "lbl_IdAtendente";
            this.lbl_IdAtendente.Size = new System.Drawing.Size(109, 18);
            this.lbl_IdAtendente.TabIndex = 128;
            this.lbl_IdAtendente.Text = "Id_Atendente:";
            // 
            // ltb_IdAluno
            // 
            this.ltb_IdAluno.FormattingEnabled = true;
            this.ltb_IdAluno.Location = new System.Drawing.Point(326, 117);
            this.ltb_IdAluno.Name = "ltb_IdAluno";
            this.ltb_IdAluno.Size = new System.Drawing.Size(150, 277);
            this.ltb_IdAluno.TabIndex = 127;
            this.ltb_IdAluno.SelectedIndexChanged += new System.EventHandler(this.ltb_IdAluno_SelectedIndexChanged);
            // 
            // txt_IdAluno
            // 
            this.txt_IdAluno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_IdAluno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_IdAluno.Location = new System.Drawing.Point(326, 98);
            this.txt_IdAluno.Name = "txt_IdAluno";
            this.txt_IdAluno.Size = new System.Drawing.Size(150, 13);
            this.txt_IdAluno.TabIndex = 126;
            // 
            // lbl_IdAluno
            // 
            this.lbl_IdAluno.AutoSize = true;
            this.lbl_IdAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_IdAluno.Location = new System.Drawing.Point(323, 78);
            this.lbl_IdAluno.Name = "lbl_IdAluno";
            this.lbl_IdAluno.Size = new System.Drawing.Size(77, 18);
            this.lbl_IdAluno.TabIndex = 125;
            this.lbl_IdAluno.Text = "Id_Aluno:";
            // 
            // ltb_Atendimento
            // 
            this.ltb_Atendimento.FormattingEnabled = true;
            this.ltb_Atendimento.Location = new System.Drawing.Point(14, 117);
            this.ltb_Atendimento.Name = "ltb_Atendimento";
            this.ltb_Atendimento.Size = new System.Drawing.Size(150, 277);
            this.ltb_Atendimento.TabIndex = 124;
            this.ltb_Atendimento.SelectedIndexChanged += new System.EventHandler(this.ltb_Atendimento_SelectedIndexChanged);
            // 
            // txt_Atendimento
            // 
            this.txt_Atendimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Atendimento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Atendimento.Location = new System.Drawing.Point(12, 98);
            this.txt_Atendimento.Name = "txt_Atendimento";
            this.txt_Atendimento.Size = new System.Drawing.Size(150, 13);
            this.txt_Atendimento.TabIndex = 123;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Id.Location = new System.Drawing.Point(9, 78);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(128, 18);
            this.lbl_Id.TabIndex = 122;
            this.lbl_Id.Text = "Id_Atendimento:";
            // 
            // ltb_Arquivos
            // 
            this.ltb_Arquivos.FormattingEnabled = true;
            this.ltb_Arquivos.Location = new System.Drawing.Point(794, 117);
            this.ltb_Arquivos.Name = "ltb_Arquivos";
            this.ltb_Arquivos.Size = new System.Drawing.Size(150, 277);
            this.ltb_Arquivos.TabIndex = 140;
            this.ltb_Arquivos.SelectedIndexChanged += new System.EventHandler(this.ltb_Arquivos_SelectedIndexChanged);
            // 
            // txt_Arquivos
            // 
            this.txt_Arquivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Arquivos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Arquivos.Location = new System.Drawing.Point(794, 98);
            this.txt_Arquivos.Name = "txt_Arquivos";
            this.txt_Arquivos.Size = new System.Drawing.Size(150, 13);
            this.txt_Arquivos.TabIndex = 139;
            // 
            // lbl_Arquivos
            // 
            this.lbl_Arquivos.AutoSize = true;
            this.lbl_Arquivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Arquivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Arquivos.Location = new System.Drawing.Point(791, 52);
            this.lbl_Arquivos.Name = "lbl_Arquivos";
            this.lbl_Arquivos.Size = new System.Drawing.Size(78, 18);
            this.lbl_Arquivos.TabIndex = 138;
            this.lbl_Arquivos.Text = "Arquivos:";
            // 
            // ltb_Descricao
            // 
            this.ltb_Descricao.FormattingEnabled = true;
            this.ltb_Descricao.Location = new System.Drawing.Point(638, 117);
            this.ltb_Descricao.Name = "ltb_Descricao";
            this.ltb_Descricao.Size = new System.Drawing.Size(150, 277);
            this.ltb_Descricao.TabIndex = 137;
            this.ltb_Descricao.SelectedIndexChanged += new System.EventHandler(this.ltb_Descricao_SelectedIndexChanged);
            // 
            // txt_Descricao
            // 
            this.txt_Descricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Descricao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Descricao.Location = new System.Drawing.Point(638, 98);
            this.txt_Descricao.Name = "txt_Descricao";
            this.txt_Descricao.Size = new System.Drawing.Size(150, 13);
            this.txt_Descricao.TabIndex = 136;
            // 
            // lbl_Descricao
            // 
            this.lbl_Descricao.AutoSize = true;
            this.lbl_Descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Descricao.Location = new System.Drawing.Point(635, 77);
            this.lbl_Descricao.Name = "lbl_Descricao";
            this.lbl_Descricao.Size = new System.Drawing.Size(90, 18);
            this.lbl_Descricao.TabIndex = 135;
            this.lbl_Descricao.Text = "Descrição:";
            // 
            // ltb_Tipo
            // 
            this.ltb_Tipo.FormattingEnabled = true;
            this.ltb_Tipo.Location = new System.Drawing.Point(482, 117);
            this.ltb_Tipo.Name = "ltb_Tipo";
            this.ltb_Tipo.Size = new System.Drawing.Size(150, 277);
            this.ltb_Tipo.TabIndex = 134;
            this.ltb_Tipo.SelectedIndexChanged += new System.EventHandler(this.ltb_Tipo_SelectedIndexChanged);
            // 
            // txt_Tipo
            // 
            this.txt_Tipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Tipo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Tipo.Location = new System.Drawing.Point(482, 98);
            this.txt_Tipo.Name = "txt_Tipo";
            this.txt_Tipo.Size = new System.Drawing.Size(150, 13);
            this.txt_Tipo.TabIndex = 133;
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Tipo.Location = new System.Drawing.Point(479, 54);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(156, 18);
            this.lbl_Tipo.TabIndex = 132;
            this.lbl_Tipo.Text = "Tipo de solicitação:";
            // 
            // cbx_Tipo
            // 
            this.cbx_Tipo.FormattingEnabled = true;
            this.cbx_Tipo.Items.AddRange(new object[] {
            "Matrícula",
            "Declaração",
            "Transferência de Curso",
            "Histórico",
            "Certificado",
            "Alteração de Cadastro",
            "outro"});
            this.cbx_Tipo.Location = new System.Drawing.Point(482, 75);
            this.cbx_Tipo.Name = "cbx_Tipo";
            this.cbx_Tipo.Size = new System.Drawing.Size(150, 21);
            this.cbx_Tipo.TabIndex = 141;
            this.cbx_Tipo.SelectedIndexChanged += new System.EventHandler(this.cbx_Tipo_SelectedIndexChanged);
            // 
            // btn_FileAtendimento
            // 
            this.btn_FileAtendimento.Location = new System.Drawing.Point(794, 72);
            this.btn_FileAtendimento.Name = "btn_FileAtendimento";
            this.btn_FileAtendimento.Size = new System.Drawing.Size(150, 23);
            this.btn_FileAtendimento.TabIndex = 148;
            this.btn_FileAtendimento.Text = "Upload de Arquivos";
            this.btn_FileAtendimento.UseVisualStyleBackColor = true;
            // 
            // cbx_Status
            // 
            this.cbx_Status.FormattingEnabled = true;
            this.cbx_Status.Items.AddRange(new object[] {
            "Pendente",
            "Em Análise",
            "Concluído",
            "Cancelado"});
            this.cbx_Status.Location = new System.Drawing.Point(950, 74);
            this.cbx_Status.Name = "cbx_Status";
            this.cbx_Status.Size = new System.Drawing.Size(150, 21);
            this.cbx_Status.TabIndex = 152;
            this.cbx_Status.SelectedIndexChanged += new System.EventHandler(this.cbx_Status_SelectedIndexChanged);
            // 
            // ltb_Status
            // 
            this.ltb_Status.FormattingEnabled = true;
            this.ltb_Status.Location = new System.Drawing.Point(950, 117);
            this.ltb_Status.Name = "ltb_Status";
            this.ltb_Status.Size = new System.Drawing.Size(150, 277);
            this.ltb_Status.TabIndex = 151;
            this.ltb_Status.SelectedIndexChanged += new System.EventHandler(this.ltb_Status_SelectedIndexChanged);
            // 
            // txt_Status
            // 
            this.txt_Status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Status.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Status.Location = new System.Drawing.Point(950, 98);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(150, 13);
            this.txt_Status.TabIndex = 150;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Status.Location = new System.Drawing.Point(947, 54);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(183, 18);
            this.lbl_Status.TabIndex = 149;
            this.lbl_Status.Text = "Status do Atendimento:";
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Salvar.Location = new System.Drawing.Point(630, 459);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(200, 50);
            this.btn_Salvar.TabIndex = 163;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Excluir.Location = new System.Drawing.Point(424, 459);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(200, 50);
            this.btn_Excluir.TabIndex = 162;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Alterar.Location = new System.Drawing.Point(218, 459);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(200, 50);
            this.btn_Alterar.TabIndex = 161;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Novo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Novo.Location = new System.Drawing.Point(12, 459);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(200, 50);
            this.btn_Novo.TabIndex = 160;
            this.btn_Novo.Text = "Novo Atendimento";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // txt_PAtendimento
            // 
            this.txt_PAtendimento.Location = new System.Drawing.Point(12, 400);
            this.txt_PAtendimento.Name = "txt_PAtendimento";
            this.txt_PAtendimento.Size = new System.Drawing.Size(150, 20);
            this.txt_PAtendimento.TabIndex = 164;
            this.txt_PAtendimento.TextChanged += new System.EventHandler(this.txt_PAtendimento_TextChanged);
            // 
            // txt_PIdAtendente
            // 
            this.txt_PIdAtendente.Location = new System.Drawing.Point(168, 400);
            this.txt_PIdAtendente.Name = "txt_PIdAtendente";
            this.txt_PIdAtendente.Size = new System.Drawing.Size(150, 20);
            this.txt_PIdAtendente.TabIndex = 165;
            this.txt_PIdAtendente.TextChanged += new System.EventHandler(this.txt_PIdAtendente_TextChanged);
            // 
            // txt_PIdAluno
            // 
            this.txt_PIdAluno.Location = new System.Drawing.Point(326, 400);
            this.txt_PIdAluno.Name = "txt_PIdAluno";
            this.txt_PIdAluno.Size = new System.Drawing.Size(150, 20);
            this.txt_PIdAluno.TabIndex = 166;
            this.txt_PIdAluno.TextChanged += new System.EventHandler(this.txt_PIdAluno_TextChanged);
            // 
            // txt_PTipo
            // 
            this.txt_PTipo.Location = new System.Drawing.Point(482, 400);
            this.txt_PTipo.Name = "txt_PTipo";
            this.txt_PTipo.Size = new System.Drawing.Size(150, 20);
            this.txt_PTipo.TabIndex = 167;
            this.txt_PTipo.TextChanged += new System.EventHandler(this.txt_PTipo_TextChanged);
            // 
            // txt_PDescricao
            // 
            this.txt_PDescricao.Location = new System.Drawing.Point(638, 400);
            this.txt_PDescricao.Name = "txt_PDescricao";
            this.txt_PDescricao.Size = new System.Drawing.Size(150, 20);
            this.txt_PDescricao.TabIndex = 168;
            this.txt_PDescricao.TextChanged += new System.EventHandler(this.txt_PDescricao_TextChanged);
            // 
            // txt_PStatus
            // 
            this.txt_PStatus.Location = new System.Drawing.Point(950, 400);
            this.txt_PStatus.Name = "txt_PStatus";
            this.txt_PStatus.Size = new System.Drawing.Size(150, 20);
            this.txt_PStatus.TabIndex = 169;
            this.txt_PStatus.TextChanged += new System.EventHandler(this.txt_PStatus_TextChanged);
            // 
            // btn_Pesquisas
            // 
            this.btn_Pesquisas.Location = new System.Drawing.Point(1309, 432);
            this.btn_Pesquisas.Name = "btn_Pesquisas";
            this.btn_Pesquisas.Size = new System.Drawing.Size(75, 23);
            this.btn_Pesquisas.TabIndex = 172;
            this.btn_Pesquisas.Text = "Pesquisar";
            this.btn_Pesquisas.UseVisualStyleBackColor = true;
            this.btn_Pesquisas.Click += new System.EventHandler(this.btn_Pesquisas_Click);
            // 
            // cbx_Pesquisas
            // 
            this.cbx_Pesquisas.FormattingEnabled = true;
            this.cbx_Pesquisas.Location = new System.Drawing.Point(836, 432);
            this.cbx_Pesquisas.Name = "cbx_Pesquisas";
            this.cbx_Pesquisas.Size = new System.Drawing.Size(457, 21);
            this.cbx_Pesquisas.TabIndex = 171;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(836, 459);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(457, 231);
            this.dataGridView1.TabIndex = 170;
            // 
            // frm_Secretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1486, 694);
            this.Controls.Add(this.btn_Pesquisas);
            this.Controls.Add(this.cbx_Pesquisas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_PStatus);
            this.Controls.Add(this.txt_PDescricao);
            this.Controls.Add(this.txt_PTipo);
            this.Controls.Add(this.txt_PIdAluno);
            this.Controls.Add(this.txt_PIdAtendente);
            this.Controls.Add(this.txt_PAtendimento);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.cbx_Status);
            this.Controls.Add(this.ltb_Status);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.btn_FileAtendimento);
            this.Controls.Add(this.cbx_Tipo);
            this.Controls.Add(this.ltb_Arquivos);
            this.Controls.Add(this.txt_Arquivos);
            this.Controls.Add(this.lbl_Arquivos);
            this.Controls.Add(this.ltb_Descricao);
            this.Controls.Add(this.txt_Descricao);
            this.Controls.Add(this.lbl_Descricao);
            this.Controls.Add(this.ltb_Tipo);
            this.Controls.Add(this.txt_Tipo);
            this.Controls.Add(this.lbl_Tipo);
            this.Controls.Add(this.lbl_Atendimento);
            this.Controls.Add(this.ltb_IdAtendente);
            this.Controls.Add(this.txt_IdAtendente);
            this.Controls.Add(this.lbl_IdAtendente);
            this.Controls.Add(this.ltb_IdAluno);
            this.Controls.Add(this.txt_IdAluno);
            this.Controls.Add(this.lbl_IdAluno);
            this.Controls.Add(this.ltb_Atendimento);
            this.Controls.Add(this.txt_Atendimento);
            this.Controls.Add(this.lbl_Id);
            this.Name = "frm_Secretaria";
            this.Text = "frm_Secretaria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Secretaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Atendimento;
        private System.Windows.Forms.ListBox ltb_IdAtendente;
        private System.Windows.Forms.TextBox txt_IdAtendente;
        private System.Windows.Forms.Label lbl_IdAtendente;
        private System.Windows.Forms.ListBox ltb_IdAluno;
        private System.Windows.Forms.TextBox txt_IdAluno;
        private System.Windows.Forms.Label lbl_IdAluno;
        private System.Windows.Forms.ListBox ltb_Atendimento;
        private System.Windows.Forms.TextBox txt_Atendimento;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.ListBox ltb_Arquivos;
        private System.Windows.Forms.TextBox txt_Arquivos;
        private System.Windows.Forms.Label lbl_Arquivos;
        private System.Windows.Forms.ListBox ltb_Descricao;
        private System.Windows.Forms.TextBox txt_Descricao;
        private System.Windows.Forms.Label lbl_Descricao;
        private System.Windows.Forms.ListBox ltb_Tipo;
        private System.Windows.Forms.TextBox txt_Tipo;
        private System.Windows.Forms.Label lbl_Tipo;
        private System.Windows.Forms.ComboBox cbx_Tipo;
        private System.Windows.Forms.Button btn_FileAtendimento;
        private System.Windows.Forms.ComboBox cbx_Status;
        private System.Windows.Forms.ListBox ltb_Status;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.TextBox txt_PAtendimento;
        private System.Windows.Forms.TextBox txt_PIdAtendente;
        private System.Windows.Forms.TextBox txt_PIdAluno;
        private System.Windows.Forms.TextBox txt_PTipo;
        private System.Windows.Forms.TextBox txt_PDescricao;
        private System.Windows.Forms.TextBox txt_PStatus;
        private System.Windows.Forms.Button btn_Pesquisas;
        private System.Windows.Forms.ComboBox cbx_Pesquisas;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}