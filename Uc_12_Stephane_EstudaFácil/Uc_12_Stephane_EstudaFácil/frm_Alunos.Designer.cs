namespace Uc_12_Stephane_EstudaFácil
{
    partial class frm_Alunos
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
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Sobrenome = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.dtp_Nascimento = new System.Windows.Forms.DateTimePicker();
            this.lbl_RG = new System.Windows.Forms.Label();
            this.lbl_CEP = new System.Windows.Forms.Label();
            this.lbl_Genero = new System.Windows.Forms.Label();
            this.lbl_CPF = new System.Windows.Forms.Label();
            this.rdb_Feminino = new System.Windows.Forms.RadioButton();
            this.rdb_Masculino = new System.Windows.Forms.RadioButton();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.txt_CEP = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_RG = new System.Windows.Forms.TextBox();
            this.txt_Sobrenome = new System.Windows.Forms.TextBox();
            this.txt_CPF = new System.Windows.Forms.TextBox();
            this.txt_Genero = new System.Windows.Forms.TextBox();
            this.ltb_Nome = new System.Windows.Forms.ListBox();
            this.ltb_Sobrenome = new System.Windows.Forms.ListBox();
            this.ltb_Aluno = new System.Windows.Forms.ListBox();
            this.ltb_Email = new System.Windows.Forms.ListBox();
            this.ltb_Nascimento = new System.Windows.Forms.ListBox();
            this.ltb_RG = new System.Windows.Forms.ListBox();
            this.ltb_CPF = new System.Windows.Forms.ListBox();
            this.ltb_Genero = new System.Windows.Forms.ListBox();
            this.ltb_CEP = new System.Windows.Forms.ListBox();
            this.lbl_Alunos = new System.Windows.Forms.Label();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.ltb_Telefone = new System.Windows.Forms.ListBox();
            this.txt_Telefone = new System.Windows.Forms.TextBox();
            this.lbl_Telefone = new System.Windows.Forms.Label();
            this.ltb_Senha = new System.Windows.Forms.ListBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.txt_Data = new System.Windows.Forms.TextBox();
            this.txt_PSenha = new System.Windows.Forms.TextBox();
            this.txt_PTelefone = new System.Windows.Forms.TextBox();
            this.txt_PEmail = new System.Windows.Forms.TextBox();
            this.txt_PCEP = new System.Windows.Forms.TextBox();
            this.txt_PGenero = new System.Windows.Forms.TextBox();
            this.txt_PData = new System.Windows.Forms.TextBox();
            this.txt_PCPF = new System.Windows.Forms.TextBox();
            this.txt_PRG = new System.Windows.Forms.TextBox();
            this.txt_PSobrenome = new System.Windows.Forms.TextBox();
            this.txt_PNome = new System.Windows.Forms.TextBox();
            this.txt_PAluno = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbx_Pesquisas = new System.Windows.Forms.ComboBox();
            this.btn_Pesquisas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Nome.Location = new System.Drawing.Point(172, 62);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(58, 18);
            this.lbl_Nome.TabIndex = 0;
            this.lbl_Nome.Text = "Nome:";
            // 
            // lbl_Sobrenome
            // 
            this.lbl_Sobrenome.AutoSize = true;
            this.lbl_Sobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sobrenome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Sobrenome.Location = new System.Drawing.Point(328, 61);
            this.lbl_Sobrenome.Name = "lbl_Sobrenome";
            this.lbl_Sobrenome.Size = new System.Drawing.Size(100, 18);
            this.lbl_Sobrenome.TabIndex = 1;
            this.lbl_Sobrenome.Text = "Sobrenome:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Email.Location = new System.Drawing.Point(1264, 62);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(55, 18);
            this.lbl_Email.TabIndex = 2;
            this.lbl_Email.Text = "Email:";
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Data.Location = new System.Drawing.Point(1576, 40);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(163, 18);
            this.lbl_Data.TabIndex = 3;
            this.lbl_Data.Text = "Data de nascimento:\r\n";
            this.lbl_Data.Click += new System.EventHandler(this.label4_Click);
            // 
            // dtp_Nascimento
            // 
            this.dtp_Nascimento.Location = new System.Drawing.Point(1579, 77);
            this.dtp_Nascimento.Name = "dtp_Nascimento";
            this.dtp_Nascimento.Size = new System.Drawing.Size(160, 20);
            this.dtp_Nascimento.TabIndex = 4;
            this.dtp_Nascimento.ValueChanged += new System.EventHandler(this.dtp_Nascimento_ValueChanged);
            // 
            // lbl_RG
            // 
            this.lbl_RG.AutoSize = true;
            this.lbl_RG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_RG.Location = new System.Drawing.Point(484, 62);
            this.lbl_RG.Name = "lbl_RG";
            this.lbl_RG.Size = new System.Drawing.Size(38, 18);
            this.lbl_RG.TabIndex = 5;
            this.lbl_RG.Text = "RG:";
            // 
            // lbl_CEP
            // 
            this.lbl_CEP.AutoSize = true;
            this.lbl_CEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CEP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_CEP.Location = new System.Drawing.Point(1108, 62);
            this.lbl_CEP.Name = "lbl_CEP";
            this.lbl_CEP.Size = new System.Drawing.Size(47, 18);
            this.lbl_CEP.TabIndex = 8;
            this.lbl_CEP.Text = "CEP:";
            this.lbl_CEP.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbl_Genero
            // 
            this.lbl_Genero.AutoSize = true;
            this.lbl_Genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Genero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Genero.Location = new System.Drawing.Point(953, 42);
            this.lbl_Genero.Name = "lbl_Genero";
            this.lbl_Genero.Size = new System.Drawing.Size(69, 18);
            this.lbl_Genero.TabIndex = 7;
            this.lbl_Genero.Text = "Gênero:";
            // 
            // lbl_CPF
            // 
            this.lbl_CPF.AutoSize = true;
            this.lbl_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_CPF.Location = new System.Drawing.Point(640, 62);
            this.lbl_CPF.Name = "lbl_CPF";
            this.lbl_CPF.Size = new System.Drawing.Size(46, 18);
            this.lbl_CPF.TabIndex = 6;
            this.lbl_CPF.Text = "CPF:";
            // 
            // rdb_Feminino
            // 
            this.rdb_Feminino.AutoSize = true;
            this.rdb_Feminino.Location = new System.Drawing.Point(955, 63);
            this.rdb_Feminino.Name = "rdb_Feminino";
            this.rdb_Feminino.Size = new System.Drawing.Size(67, 17);
            this.rdb_Feminino.TabIndex = 9;
            this.rdb_Feminino.Text = "Feminino";
            this.rdb_Feminino.UseVisualStyleBackColor = true;
            this.rdb_Feminino.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdb_Masculino
            // 
            this.rdb_Masculino.AutoSize = true;
            this.rdb_Masculino.Location = new System.Drawing.Point(1032, 64);
            this.rdb_Masculino.Name = "rdb_Masculino";
            this.rdb_Masculino.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdb_Masculino.Size = new System.Drawing.Size(73, 17);
            this.rdb_Masculino.TabIndex = 10;
            this.rdb_Masculino.Text = "Masculino";
            this.rdb_Masculino.UseVisualStyleBackColor = true;
            this.rdb_Masculino.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Id.Location = new System.Drawing.Point(16, 63);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(77, 18);
            this.lbl_Id.TabIndex = 11;
            this.lbl_Id.Text = "Id_Aluno:";
            // 
            // txt_CEP
            // 
            this.txt_CEP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_CEP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_CEP.Location = new System.Drawing.Point(1111, 82);
            this.txt_CEP.Name = "txt_CEP";
            this.txt_CEP.Size = new System.Drawing.Size(150, 13);
            this.txt_CEP.TabIndex = 12;
            this.txt_CEP.TextChanged += new System.EventHandler(this.txt_CEP_TextChanged);
            // 
            // txt_Email
            // 
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Email.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Email.Location = new System.Drawing.Point(1267, 83);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(150, 13);
            this.txt_Email.TabIndex = 13;
            // 
            // txt_Nome
            // 
            this.txt_Nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Nome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Nome.Location = new System.Drawing.Point(175, 83);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(150, 13);
            this.txt_Nome.TabIndex = 14;
            // 
            // txt_Id
            // 
            this.txt_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Id.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Id.Location = new System.Drawing.Point(19, 83);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(150, 13);
            this.txt_Id.TabIndex = 15;
            this.txt_Id.TextChanged += new System.EventHandler(this.txt_Id_TextChanged);
            // 
            // txt_RG
            // 
            this.txt_RG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_RG.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_RG.Location = new System.Drawing.Point(484, 83);
            this.txt_RG.Name = "txt_RG";
            this.txt_RG.Size = new System.Drawing.Size(150, 13);
            this.txt_RG.TabIndex = 16;
            // 
            // txt_Sobrenome
            // 
            this.txt_Sobrenome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Sobrenome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Sobrenome.Location = new System.Drawing.Point(331, 83);
            this.txt_Sobrenome.Name = "txt_Sobrenome";
            this.txt_Sobrenome.Size = new System.Drawing.Size(150, 13);
            this.txt_Sobrenome.TabIndex = 17;
            // 
            // txt_CPF
            // 
            this.txt_CPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_CPF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_CPF.Location = new System.Drawing.Point(643, 83);
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.Size = new System.Drawing.Size(150, 13);
            this.txt_CPF.TabIndex = 18;
            // 
            // txt_Genero
            // 
            this.txt_Genero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Genero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Genero.Location = new System.Drawing.Point(955, 83);
            this.txt_Genero.Name = "txt_Genero";
            this.txt_Genero.Size = new System.Drawing.Size(150, 13);
            this.txt_Genero.TabIndex = 19;
            // 
            // ltb_Nome
            // 
            this.ltb_Nome.FormattingEnabled = true;
            this.ltb_Nome.Location = new System.Drawing.Point(175, 102);
            this.ltb_Nome.Name = "ltb_Nome";
            this.ltb_Nome.Size = new System.Drawing.Size(150, 277);
            this.ltb_Nome.TabIndex = 20;
            this.ltb_Nome.SelectedIndexChanged += new System.EventHandler(this.ltb_Nome_SelectedIndexChanged);
            // 
            // ltb_Sobrenome
            // 
            this.ltb_Sobrenome.FormattingEnabled = true;
            this.ltb_Sobrenome.Location = new System.Drawing.Point(331, 102);
            this.ltb_Sobrenome.Name = "ltb_Sobrenome";
            this.ltb_Sobrenome.Size = new System.Drawing.Size(150, 277);
            this.ltb_Sobrenome.TabIndex = 21;
            this.ltb_Sobrenome.SelectedIndexChanged += new System.EventHandler(this.ltb_Sobrenome_SelectedIndexChanged);
            // 
            // ltb_Aluno
            // 
            this.ltb_Aluno.FormattingEnabled = true;
            this.ltb_Aluno.Location = new System.Drawing.Point(19, 102);
            this.ltb_Aluno.Name = "ltb_Aluno";
            this.ltb_Aluno.Size = new System.Drawing.Size(150, 277);
            this.ltb_Aluno.TabIndex = 22;
            this.ltb_Aluno.SelectedIndexChanged += new System.EventHandler(this.ltb_Aluno_SelectedIndexChanged);
            // 
            // ltb_Email
            // 
            this.ltb_Email.FormattingEnabled = true;
            this.ltb_Email.Location = new System.Drawing.Point(1267, 102);
            this.ltb_Email.Name = "ltb_Email";
            this.ltb_Email.Size = new System.Drawing.Size(150, 277);
            this.ltb_Email.TabIndex = 23;
            this.ltb_Email.SelectedIndexChanged += new System.EventHandler(this.ltb_Email_SelectedIndexChanged);
            // 
            // ltb_Nascimento
            // 
            this.ltb_Nascimento.FormattingEnabled = true;
            this.ltb_Nascimento.Location = new System.Drawing.Point(1579, 102);
            this.ltb_Nascimento.Name = "ltb_Nascimento";
            this.ltb_Nascimento.Size = new System.Drawing.Size(160, 277);
            this.ltb_Nascimento.TabIndex = 24;
            this.ltb_Nascimento.SelectedIndexChanged += new System.EventHandler(this.ltb_Nascimento_SelectedIndexChanged);
            // 
            // ltb_RG
            // 
            this.ltb_RG.FormattingEnabled = true;
            this.ltb_RG.Location = new System.Drawing.Point(487, 102);
            this.ltb_RG.Name = "ltb_RG";
            this.ltb_RG.Size = new System.Drawing.Size(150, 277);
            this.ltb_RG.TabIndex = 25;
            this.ltb_RG.SelectedIndexChanged += new System.EventHandler(this.ltb_RG_SelectedIndexChanged);
            // 
            // ltb_CPF
            // 
            this.ltb_CPF.FormattingEnabled = true;
            this.ltb_CPF.Location = new System.Drawing.Point(643, 102);
            this.ltb_CPF.Name = "ltb_CPF";
            this.ltb_CPF.Size = new System.Drawing.Size(150, 277);
            this.ltb_CPF.TabIndex = 26;
            this.ltb_CPF.SelectedIndexChanged += new System.EventHandler(this.ltb_CPF_SelectedIndexChanged);
            // 
            // ltb_Genero
            // 
            this.ltb_Genero.FormattingEnabled = true;
            this.ltb_Genero.Location = new System.Drawing.Point(955, 102);
            this.ltb_Genero.Name = "ltb_Genero";
            this.ltb_Genero.Size = new System.Drawing.Size(150, 277);
            this.ltb_Genero.TabIndex = 27;
            this.ltb_Genero.SelectedIndexChanged += new System.EventHandler(this.ltb_Genero_SelectedIndexChanged);
            // 
            // ltb_CEP
            // 
            this.ltb_CEP.FormattingEnabled = true;
            this.ltb_CEP.Location = new System.Drawing.Point(1111, 102);
            this.ltb_CEP.Name = "ltb_CEP";
            this.ltb_CEP.Size = new System.Drawing.Size(150, 277);
            this.ltb_CEP.TabIndex = 28;
            this.ltb_CEP.SelectedIndexChanged += new System.EventHandler(this.ltb_CEP_SelectedIndexChanged);
            // 
            // lbl_Alunos
            // 
            this.lbl_Alunos.AutoSize = true;
            this.lbl_Alunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Alunos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Alunos.Location = new System.Drawing.Point(13, 9);
            this.lbl_Alunos.Name = "lbl_Alunos";
            this.lbl_Alunos.Size = new System.Drawing.Size(103, 31);
            this.lbl_Alunos.TabIndex = 29;
            this.lbl_Alunos.Text = "Alunos";
            this.lbl_Alunos.Click += new System.EventHandler(this.lbl_Alunos_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Novo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Novo.Location = new System.Drawing.Point(15, 454);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(200, 50);
            this.btn_Novo.TabIndex = 30;
            this.btn_Novo.Text = "Novo Aluno";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Alterar.Location = new System.Drawing.Point(221, 454);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(200, 50);
            this.btn_Alterar.TabIndex = 31;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Excluir.Location = new System.Drawing.Point(427, 454);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(200, 50);
            this.btn_Excluir.TabIndex = 32;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Salvar.Location = new System.Drawing.Point(633, 454);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(200, 50);
            this.btn_Salvar.TabIndex = 33;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // ltb_Telefone
            // 
            this.ltb_Telefone.FormattingEnabled = true;
            this.ltb_Telefone.Location = new System.Drawing.Point(1423, 102);
            this.ltb_Telefone.Name = "ltb_Telefone";
            this.ltb_Telefone.Size = new System.Drawing.Size(150, 277);
            this.ltb_Telefone.TabIndex = 36;
            this.ltb_Telefone.SelectedIndexChanged += new System.EventHandler(this.ltb_Telefone_SelectedIndexChanged);
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Telefone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Telefone.Location = new System.Drawing.Point(1423, 82);
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(150, 13);
            this.txt_Telefone.TabIndex = 35;
            // 
            // lbl_Telefone
            // 
            this.lbl_Telefone.AutoSize = true;
            this.lbl_Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Telefone.Location = new System.Drawing.Point(1420, 62);
            this.lbl_Telefone.Name = "lbl_Telefone";
            this.lbl_Telefone.Size = new System.Drawing.Size(78, 18);
            this.lbl_Telefone.TabIndex = 34;
            this.lbl_Telefone.Text = "Telefone:";
            this.lbl_Telefone.Click += new System.EventHandler(this.lblTelefone_Click);
            // 
            // ltb_Senha
            // 
            this.ltb_Senha.FormattingEnabled = true;
            this.ltb_Senha.Location = new System.Drawing.Point(799, 102);
            this.ltb_Senha.Name = "ltb_Senha";
            this.ltb_Senha.Size = new System.Drawing.Size(150, 277);
            this.ltb_Senha.TabIndex = 39;
            this.ltb_Senha.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txt_Senha
            // 
            this.txt_Senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Senha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Senha.Location = new System.Drawing.Point(799, 82);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(150, 13);
            this.txt_Senha.TabIndex = 38;
            this.txt_Senha.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Senha.Location = new System.Drawing.Point(796, 62);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(60, 18);
            this.lbl_Senha.TabIndex = 37;
            this.lbl_Senha.Text = "Senha:";
            this.lbl_Senha.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Data
            // 
            this.txt_Data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Data.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Data.Location = new System.Drawing.Point(1579, 61);
            this.txt_Data.Name = "txt_Data";
            this.txt_Data.Size = new System.Drawing.Size(160, 13);
            this.txt_Data.TabIndex = 89;
            this.txt_Data.TextChanged += new System.EventHandler(this.txt_Data_TextChanged);
            // 
            // txt_PSenha
            // 
            this.txt_PSenha.Location = new System.Drawing.Point(799, 385);
            this.txt_PSenha.Name = "txt_PSenha";
            this.txt_PSenha.Size = new System.Drawing.Size(150, 20);
            this.txt_PSenha.TabIndex = 152;
            this.txt_PSenha.TextChanged += new System.EventHandler(this.txt_PSenha_TextChanged);
            // 
            // txt_PTelefone
            // 
            this.txt_PTelefone.Location = new System.Drawing.Point(1423, 385);
            this.txt_PTelefone.Name = "txt_PTelefone";
            this.txt_PTelefone.Size = new System.Drawing.Size(150, 20);
            this.txt_PTelefone.TabIndex = 151;
            this.txt_PTelefone.TextChanged += new System.EventHandler(this.txt_PTelefone_TextChanged);
            // 
            // txt_PEmail
            // 
            this.txt_PEmail.Location = new System.Drawing.Point(1267, 385);
            this.txt_PEmail.Name = "txt_PEmail";
            this.txt_PEmail.Size = new System.Drawing.Size(150, 20);
            this.txt_PEmail.TabIndex = 150;
            this.txt_PEmail.TextChanged += new System.EventHandler(this.txt_PEmail_TextChanged);
            // 
            // txt_PCEP
            // 
            this.txt_PCEP.Location = new System.Drawing.Point(1111, 385);
            this.txt_PCEP.Name = "txt_PCEP";
            this.txt_PCEP.Size = new System.Drawing.Size(150, 20);
            this.txt_PCEP.TabIndex = 149;
            this.txt_PCEP.TextChanged += new System.EventHandler(this.txt_PCEP_TextChanged);
            // 
            // txt_PGenero
            // 
            this.txt_PGenero.Location = new System.Drawing.Point(955, 385);
            this.txt_PGenero.Name = "txt_PGenero";
            this.txt_PGenero.Size = new System.Drawing.Size(150, 20);
            this.txt_PGenero.TabIndex = 148;
            this.txt_PGenero.TextChanged += new System.EventHandler(this.txt_PGenero_TextChanged);
            // 
            // txt_PData
            // 
            this.txt_PData.Location = new System.Drawing.Point(1579, 385);
            this.txt_PData.Name = "txt_PData";
            this.txt_PData.Size = new System.Drawing.Size(160, 20);
            this.txt_PData.TabIndex = 147;
            this.txt_PData.TextChanged += new System.EventHandler(this.txt_PData_TextChanged);
            // 
            // txt_PCPF
            // 
            this.txt_PCPF.Location = new System.Drawing.Point(643, 385);
            this.txt_PCPF.Name = "txt_PCPF";
            this.txt_PCPF.Size = new System.Drawing.Size(150, 20);
            this.txt_PCPF.TabIndex = 146;
            this.txt_PCPF.TextChanged += new System.EventHandler(this.txt_PCPF_TextChanged);
            // 
            // txt_PRG
            // 
            this.txt_PRG.Location = new System.Drawing.Point(487, 385);
            this.txt_PRG.Name = "txt_PRG";
            this.txt_PRG.Size = new System.Drawing.Size(150, 20);
            this.txt_PRG.TabIndex = 145;
            this.txt_PRG.TextChanged += new System.EventHandler(this.txt_PRG_TextChanged);
            // 
            // txt_PSobrenome
            // 
            this.txt_PSobrenome.Location = new System.Drawing.Point(331, 385);
            this.txt_PSobrenome.Name = "txt_PSobrenome";
            this.txt_PSobrenome.Size = new System.Drawing.Size(150, 20);
            this.txt_PSobrenome.TabIndex = 144;
            this.txt_PSobrenome.TextChanged += new System.EventHandler(this.txt_PSobrenome_TextChanged);
            // 
            // txt_PNome
            // 
            this.txt_PNome.Location = new System.Drawing.Point(175, 385);
            this.txt_PNome.Name = "txt_PNome";
            this.txt_PNome.Size = new System.Drawing.Size(150, 20);
            this.txt_PNome.TabIndex = 143;
            this.txt_PNome.TextChanged += new System.EventHandler(this.txt_PNome_TextChanged);
            // 
            // txt_PAluno
            // 
            this.txt_PAluno.Location = new System.Drawing.Point(19, 385);
            this.txt_PAluno.Name = "txt_PAluno";
            this.txt_PAluno.Size = new System.Drawing.Size(150, 20);
            this.txt_PAluno.TabIndex = 142;
            this.txt_PAluno.TextChanged += new System.EventHandler(this.txt_PAluno_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1050, 468);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(457, 231);
            this.dataGridView1.TabIndex = 153;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbx_Pesquisas
            // 
            this.cbx_Pesquisas.FormattingEnabled = true;
            this.cbx_Pesquisas.Location = new System.Drawing.Point(1050, 441);
            this.cbx_Pesquisas.Name = "cbx_Pesquisas";
            this.cbx_Pesquisas.Size = new System.Drawing.Size(457, 21);
            this.cbx_Pesquisas.TabIndex = 154;
            this.cbx_Pesquisas.SelectedIndexChanged += new System.EventHandler(this.cbx_Pesquisas_SelectedIndexChanged);
            // 
            // btn_Pesquisas
            // 
            this.btn_Pesquisas.Location = new System.Drawing.Point(1523, 441);
            this.btn_Pesquisas.Name = "btn_Pesquisas";
            this.btn_Pesquisas.Size = new System.Drawing.Size(75, 23);
            this.btn_Pesquisas.TabIndex = 155;
            this.btn_Pesquisas.Text = "Pesquisar";
            this.btn_Pesquisas.UseVisualStyleBackColor = true;
            this.btn_Pesquisas.Click += new System.EventHandler(this.btn_Pesquisas_Click);
            // 
            // frm_Alunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1924, 761);
            this.Controls.Add(this.btn_Pesquisas);
            this.Controls.Add(this.cbx_Pesquisas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_PSenha);
            this.Controls.Add(this.txt_PTelefone);
            this.Controls.Add(this.txt_PEmail);
            this.Controls.Add(this.txt_PCEP);
            this.Controls.Add(this.txt_PGenero);
            this.Controls.Add(this.txt_PData);
            this.Controls.Add(this.txt_PCPF);
            this.Controls.Add(this.txt_PRG);
            this.Controls.Add(this.txt_PSobrenome);
            this.Controls.Add(this.txt_PNome);
            this.Controls.Add(this.txt_PAluno);
            this.Controls.Add(this.txt_Data);
            this.Controls.Add(this.ltb_Senha);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.lbl_Senha);
            this.Controls.Add(this.ltb_Telefone);
            this.Controls.Add(this.txt_Telefone);
            this.Controls.Add(this.lbl_Telefone);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.lbl_Alunos);
            this.Controls.Add(this.ltb_CEP);
            this.Controls.Add(this.ltb_Genero);
            this.Controls.Add(this.ltb_CPF);
            this.Controls.Add(this.ltb_RG);
            this.Controls.Add(this.ltb_Nascimento);
            this.Controls.Add(this.ltb_Email);
            this.Controls.Add(this.ltb_Aluno);
            this.Controls.Add(this.ltb_Sobrenome);
            this.Controls.Add(this.ltb_Nome);
            this.Controls.Add(this.txt_Genero);
            this.Controls.Add(this.txt_CPF);
            this.Controls.Add(this.txt_Sobrenome);
            this.Controls.Add(this.txt_RG);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_CEP);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.rdb_Masculino);
            this.Controls.Add(this.rdb_Feminino);
            this.Controls.Add(this.lbl_CEP);
            this.Controls.Add(this.lbl_Genero);
            this.Controls.Add(this.lbl_CPF);
            this.Controls.Add(this.lbl_RG);
            this.Controls.Add(this.dtp_Nascimento);
            this.Controls.Add(this.lbl_Data);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Sobrenome);
            this.Controls.Add(this.lbl_Nome);
            this.Name = "frm_Alunos";
            this.Text = "\'";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Alunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Sobrenome;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Data;
        private System.Windows.Forms.DateTimePicker dtp_Nascimento;
        private System.Windows.Forms.Label lbl_RG;
        private System.Windows.Forms.Label lbl_CEP;
        private System.Windows.Forms.Label lbl_Genero;
        private System.Windows.Forms.Label lbl_CPF;
        private System.Windows.Forms.RadioButton rdb_Feminino;
        private System.Windows.Forms.RadioButton rdb_Masculino;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.TextBox txt_CEP;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_RG;
        private System.Windows.Forms.TextBox txt_Sobrenome;
        private System.Windows.Forms.TextBox txt_CPF;
        private System.Windows.Forms.TextBox txt_Genero;
        private System.Windows.Forms.ListBox ltb_Nome;
        private System.Windows.Forms.ListBox ltb_Sobrenome;
        private System.Windows.Forms.ListBox ltb_Aluno;
        private System.Windows.Forms.ListBox ltb_Email;
        private System.Windows.Forms.ListBox ltb_Nascimento;
        private System.Windows.Forms.ListBox ltb_RG;
        private System.Windows.Forms.ListBox ltb_CPF;
        private System.Windows.Forms.ListBox ltb_Genero;
        private System.Windows.Forms.ListBox ltb_CEP;
        private System.Windows.Forms.Label lbl_Alunos;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.ListBox ltb_Telefone;
        private System.Windows.Forms.TextBox txt_Telefone;
        private System.Windows.Forms.Label lbl_Telefone;
        private System.Windows.Forms.ListBox ltb_Senha;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.TextBox txt_Data;
        private System.Windows.Forms.TextBox txt_PSenha;
        private System.Windows.Forms.TextBox txt_PTelefone;
        private System.Windows.Forms.TextBox txt_PEmail;
        private System.Windows.Forms.TextBox txt_PCEP;
        private System.Windows.Forms.TextBox txt_PGenero;
        private System.Windows.Forms.TextBox txt_PData;
        private System.Windows.Forms.TextBox txt_PCPF;
        private System.Windows.Forms.TextBox txt_PRG;
        private System.Windows.Forms.TextBox txt_PSobrenome;
        private System.Windows.Forms.TextBox txt_PNome;
        private System.Windows.Forms.TextBox txt_PAluno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbx_Pesquisas;
        private System.Windows.Forms.Button btn_Pesquisas;
    }
}