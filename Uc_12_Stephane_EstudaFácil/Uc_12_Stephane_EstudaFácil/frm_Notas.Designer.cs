namespace Uc_12_Stephane_EstudaFácil
{
    partial class frm_Notas
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
            this.lbl_Notas = new System.Windows.Forms.Label();
            this.ltb_Horas = new System.Windows.Forms.ListBox();
            this.ltb_Matricula = new System.Windows.Forms.ListBox();
            this.ltb_Nome = new System.Windows.Forms.ListBox();
            this.txt_Horas = new System.Windows.Forms.TextBox();
            this.txt_Carga = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Horas = new System.Windows.Forms.Label();
            this.lbl_Carga = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.ltb_Aproveitamento = new System.Windows.Forms.ListBox();
            this.txt_Aproveitamento = new System.Windows.Forms.TextBox();
            this.lbl_Aproveitamento = new System.Windows.Forms.Label();
            this.ltb_Carga = new System.Windows.Forms.ListBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.ltb_FreqObrigatoria = new System.Windows.Forms.ListBox();
            this.txt_FreqObrigatoria = new System.Windows.Forms.TextBox();
            this.lbl_FreqObrigatoria = new System.Windows.Forms.Label();
            this.txt_PMatricula = new System.Windows.Forms.TextBox();
            this.txt_PNome = new System.Windows.Forms.TextBox();
            this.txt_PCarga = new System.Windows.Forms.TextBox();
            this.txt_PFreq = new System.Windows.Forms.TextBox();
            this.txt_PHoras = new System.Windows.Forms.TextBox();
            this.txt_PAproveitamento = new System.Windows.Forms.TextBox();
            this.btn_Pesquisas = new System.Windows.Forms.Button();
            this.cbx_Pesquisas = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Notas
            // 
            this.lbl_Notas.AutoSize = true;
            this.lbl_Notas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Notas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Notas.Location = new System.Drawing.Point(36, 39);
            this.lbl_Notas.Name = "lbl_Notas";
            this.lbl_Notas.Size = new System.Drawing.Size(260, 31);
            this.lbl_Notas.TabIndex = 122;
            this.lbl_Notas.Text = "Notas e frequência";
            // 
            // ltb_Horas
            // 
            this.ltb_Horas.FormattingEnabled = true;
            this.ltb_Horas.Location = new System.Drawing.Point(699, 136);
            this.ltb_Horas.Name = "ltb_Horas";
            this.ltb_Horas.Size = new System.Drawing.Size(150, 277);
            this.ltb_Horas.TabIndex = 137;
            this.ltb_Horas.SelectedIndexChanged += new System.EventHandler(this.ltb_Horas_SelectedIndexChanged);
            // 
            // ltb_Matricula
            // 
            this.ltb_Matricula.FormattingEnabled = true;
            this.ltb_Matricula.Location = new System.Drawing.Point(42, 136);
            this.ltb_Matricula.Name = "ltb_Matricula";
            this.ltb_Matricula.Size = new System.Drawing.Size(150, 277);
            this.ltb_Matricula.TabIndex = 135;
            this.ltb_Matricula.SelectedIndexChanged += new System.EventHandler(this.ltb_Matricula_SelectedIndexChanged);
            // 
            // ltb_Nome
            // 
            this.ltb_Nome.FormattingEnabled = true;
            this.ltb_Nome.Location = new System.Drawing.Point(198, 136);
            this.ltb_Nome.Name = "ltb_Nome";
            this.ltb_Nome.Size = new System.Drawing.Size(150, 277);
            this.ltb_Nome.TabIndex = 133;
            this.ltb_Nome.SelectedIndexChanged += new System.EventHandler(this.ltb_Nome_SelectedIndexChanged);
            // 
            // txt_Horas
            // 
            this.txt_Horas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Horas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Horas.Location = new System.Drawing.Point(699, 117);
            this.txt_Horas.Name = "txt_Horas";
            this.txt_Horas.Size = new System.Drawing.Size(150, 13);
            this.txt_Horas.TabIndex = 132;
            // 
            // txt_Carga
            // 
            this.txt_Carga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Carga.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Carga.Location = new System.Drawing.Point(354, 117);
            this.txt_Carga.Name = "txt_Carga";
            this.txt_Carga.Size = new System.Drawing.Size(150, 13);
            this.txt_Carga.TabIndex = 130;
            // 
            // txt_Id
            // 
            this.txt_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Id.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Id.Location = new System.Drawing.Point(42, 118);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(150, 13);
            this.txt_Id.TabIndex = 129;
            // 
            // txt_Nome
            // 
            this.txt_Nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Nome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Nome.Location = new System.Drawing.Point(198, 117);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(150, 13);
            this.txt_Nome.TabIndex = 128;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Id.Location = new System.Drawing.Point(39, 97);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(104, 18);
            this.lbl_Id.TabIndex = 127;
            this.lbl_Id.Text = "Id_Matricula:";
            // 
            // lbl_Horas
            // 
            this.lbl_Horas.AutoSize = true;
            this.lbl_Horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Horas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Horas.Location = new System.Drawing.Point(696, 96);
            this.lbl_Horas.Name = "lbl_Horas";
            this.lbl_Horas.Size = new System.Drawing.Size(141, 18);
            this.lbl_Horas.TabIndex = 126;
            this.lbl_Horas.Text = "Horas Assistidas:";
            // 
            // lbl_Carga
            // 
            this.lbl_Carga.AutoSize = true;
            this.lbl_Carga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Carga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Carga.Location = new System.Drawing.Point(354, 96);
            this.lbl_Carga.Name = "lbl_Carga";
            this.lbl_Carga.Size = new System.Drawing.Size(116, 18);
            this.lbl_Carga.TabIndex = 125;
            this.lbl_Carga.Text = "Carga horária:";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Nome.Location = new System.Drawing.Point(195, 96);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(133, 18);
            this.lbl_Nome.TabIndex = 123;
            this.lbl_Nome.Text = "Nome do Curso:";
            // 
            // ltb_Aproveitamento
            // 
            this.ltb_Aproveitamento.FormattingEnabled = true;
            this.ltb_Aproveitamento.Location = new System.Drawing.Point(855, 136);
            this.ltb_Aproveitamento.Name = "ltb_Aproveitamento";
            this.ltb_Aproveitamento.Size = new System.Drawing.Size(150, 277);
            this.ltb_Aproveitamento.TabIndex = 140;
            this.ltb_Aproveitamento.SelectedIndexChanged += new System.EventHandler(this.ltb_Aproveitamento_SelectedIndexChanged);
            // 
            // txt_Aproveitamento
            // 
            this.txt_Aproveitamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Aproveitamento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Aproveitamento.Location = new System.Drawing.Point(855, 117);
            this.txt_Aproveitamento.Name = "txt_Aproveitamento";
            this.txt_Aproveitamento.Size = new System.Drawing.Size(150, 13);
            this.txt_Aproveitamento.TabIndex = 139;
            // 
            // lbl_Aproveitamento
            // 
            this.lbl_Aproveitamento.AutoSize = true;
            this.lbl_Aproveitamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Aproveitamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Aproveitamento.Location = new System.Drawing.Point(852, 96);
            this.lbl_Aproveitamento.Name = "lbl_Aproveitamento";
            this.lbl_Aproveitamento.Size = new System.Drawing.Size(130, 18);
            this.lbl_Aproveitamento.TabIndex = 138;
            this.lbl_Aproveitamento.Text = "Aproveitamento:";
            // 
            // ltb_Carga
            // 
            this.ltb_Carga.FormattingEnabled = true;
            this.ltb_Carga.Location = new System.Drawing.Point(354, 136);
            this.ltb_Carga.Name = "ltb_Carga";
            this.ltb_Carga.Size = new System.Drawing.Size(150, 277);
            this.ltb_Carga.TabIndex = 141;
            this.ltb_Carga.SelectedIndexChanged += new System.EventHandler(this.ltb_Carga_SelectedIndexChanged);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Salvar.Location = new System.Drawing.Point(756, 460);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(200, 50);
            this.btn_Salvar.TabIndex = 145;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Excluir.Location = new System.Drawing.Point(514, 460);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(200, 50);
            this.btn_Excluir.TabIndex = 144;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Alterar.Location = new System.Drawing.Point(272, 460);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(200, 50);
            this.btn_Alterar.TabIndex = 143;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Novo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Novo.Location = new System.Drawing.Point(42, 460);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(200, 50);
            this.btn_Novo.TabIndex = 142;
            this.btn_Novo.Text = "Novo Histórico";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // ltb_FreqObrigatoria
            // 
            this.ltb_FreqObrigatoria.FormattingEnabled = true;
            this.ltb_FreqObrigatoria.Location = new System.Drawing.Point(510, 136);
            this.ltb_FreqObrigatoria.Name = "ltb_FreqObrigatoria";
            this.ltb_FreqObrigatoria.Size = new System.Drawing.Size(182, 277);
            this.ltb_FreqObrigatoria.TabIndex = 148;
            this.ltb_FreqObrigatoria.SelectedIndexChanged += new System.EventHandler(this.ltb_FreqObrigatoria_SelectedIndexChanged);
            // 
            // txt_FreqObrigatoria
            // 
            this.txt_FreqObrigatoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_FreqObrigatoria.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_FreqObrigatoria.Location = new System.Drawing.Point(507, 117);
            this.txt_FreqObrigatoria.Name = "txt_FreqObrigatoria";
            this.txt_FreqObrigatoria.Size = new System.Drawing.Size(185, 13);
            this.txt_FreqObrigatoria.TabIndex = 147;
            // 
            // lbl_FreqObrigatoria
            // 
            this.lbl_FreqObrigatoria.AutoSize = true;
            this.lbl_FreqObrigatoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FreqObrigatoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_FreqObrigatoria.Location = new System.Drawing.Point(507, 96);
            this.lbl_FreqObrigatoria.Name = "lbl_FreqObrigatoria";
            this.lbl_FreqObrigatoria.Size = new System.Drawing.Size(185, 18);
            this.lbl_FreqObrigatoria.TabIndex = 146;
            this.lbl_FreqObrigatoria.Text = "Frequência Obrigatória:";
            // 
            // txt_PMatricula
            // 
            this.txt_PMatricula.Location = new System.Drawing.Point(42, 419);
            this.txt_PMatricula.Name = "txt_PMatricula";
            this.txt_PMatricula.Size = new System.Drawing.Size(150, 20);
            this.txt_PMatricula.TabIndex = 149;
            this.txt_PMatricula.TextChanged += new System.EventHandler(this.txt_PMatricula_TextChanged);
            // 
            // txt_PNome
            // 
            this.txt_PNome.Location = new System.Drawing.Point(198, 419);
            this.txt_PNome.Name = "txt_PNome";
            this.txt_PNome.Size = new System.Drawing.Size(150, 20);
            this.txt_PNome.TabIndex = 150;
            this.txt_PNome.TextChanged += new System.EventHandler(this.txt_PNome_TextChanged);
            // 
            // txt_PCarga
            // 
            this.txt_PCarga.Location = new System.Drawing.Point(354, 419);
            this.txt_PCarga.Name = "txt_PCarga";
            this.txt_PCarga.Size = new System.Drawing.Size(150, 20);
            this.txt_PCarga.TabIndex = 151;
            this.txt_PCarga.TextChanged += new System.EventHandler(this.txt_PCurso_TextChanged);
            // 
            // txt_PFreq
            // 
            this.txt_PFreq.Location = new System.Drawing.Point(510, 419);
            this.txt_PFreq.Name = "txt_PFreq";
            this.txt_PFreq.Size = new System.Drawing.Size(182, 20);
            this.txt_PFreq.TabIndex = 152;
            this.txt_PFreq.TextChanged += new System.EventHandler(this.txt_PFreq_TextChanged);
            // 
            // txt_PHoras
            // 
            this.txt_PHoras.Location = new System.Drawing.Point(699, 419);
            this.txt_PHoras.Name = "txt_PHoras";
            this.txt_PHoras.Size = new System.Drawing.Size(150, 20);
            this.txt_PHoras.TabIndex = 153;
            this.txt_PHoras.TextChanged += new System.EventHandler(this.txt_PHoras_TextChanged);
            // 
            // txt_PAproveitamento
            // 
            this.txt_PAproveitamento.Location = new System.Drawing.Point(855, 419);
            this.txt_PAproveitamento.Name = "txt_PAproveitamento";
            this.txt_PAproveitamento.Size = new System.Drawing.Size(150, 20);
            this.txt_PAproveitamento.TabIndex = 154;
            this.txt_PAproveitamento.TextChanged += new System.EventHandler(this.txt_PAproveitamento_TextChanged);
            // 
            // btn_Pesquisas
            // 
            this.btn_Pesquisas.Location = new System.Drawing.Point(1499, 109);
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
            this.cbx_Pesquisas.Location = new System.Drawing.Point(1026, 109);
            this.cbx_Pesquisas.Name = "cbx_Pesquisas";
            this.cbx_Pesquisas.Size = new System.Drawing.Size(457, 21);
            this.cbx_Pesquisas.TabIndex = 157;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1026, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(457, 231);
            this.dataGridView1.TabIndex = 156;
            // 
            // frm_Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1597, 748);
            this.Controls.Add(this.btn_Pesquisas);
            this.Controls.Add(this.cbx_Pesquisas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_PAproveitamento);
            this.Controls.Add(this.txt_PHoras);
            this.Controls.Add(this.txt_PFreq);
            this.Controls.Add(this.txt_PCarga);
            this.Controls.Add(this.txt_PNome);
            this.Controls.Add(this.txt_PMatricula);
            this.Controls.Add(this.ltb_FreqObrigatoria);
            this.Controls.Add(this.txt_FreqObrigatoria);
            this.Controls.Add(this.lbl_FreqObrigatoria);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.ltb_Carga);
            this.Controls.Add(this.ltb_Aproveitamento);
            this.Controls.Add(this.txt_Aproveitamento);
            this.Controls.Add(this.lbl_Aproveitamento);
            this.Controls.Add(this.ltb_Horas);
            this.Controls.Add(this.ltb_Matricula);
            this.Controls.Add(this.ltb_Nome);
            this.Controls.Add(this.txt_Horas);
            this.Controls.Add(this.txt_Carga);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_Horas);
            this.Controls.Add(this.lbl_Carga);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.lbl_Notas);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frm_Notas";
            this.Text = "frm_Notas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Notas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Notas;
        private System.Windows.Forms.ListBox ltb_Horas;
        private System.Windows.Forms.ListBox ltb_Matricula;
        private System.Windows.Forms.ListBox ltb_Nome;
        private System.Windows.Forms.TextBox txt_Horas;
        private System.Windows.Forms.TextBox txt_Carga;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Horas;
        private System.Windows.Forms.Label lbl_Carga;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.ListBox ltb_Aproveitamento;
        private System.Windows.Forms.TextBox txt_Aproveitamento;
        private System.Windows.Forms.Label lbl_Aproveitamento;
        private System.Windows.Forms.ListBox ltb_Carga;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.ListBox ltb_FreqObrigatoria;
        private System.Windows.Forms.TextBox txt_FreqObrigatoria;
        private System.Windows.Forms.Label lbl_FreqObrigatoria;
        private System.Windows.Forms.TextBox txt_PMatricula;
        private System.Windows.Forms.TextBox txt_PNome;
        private System.Windows.Forms.TextBox txt_PCarga;
        private System.Windows.Forms.TextBox txt_PFreq;
        private System.Windows.Forms.TextBox txt_PHoras;
        private System.Windows.Forms.TextBox txt_PAproveitamento;
        private System.Windows.Forms.Button btn_Pesquisas;
        private System.Windows.Forms.ComboBox cbx_Pesquisas;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}