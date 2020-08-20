namespace ordem_de_servico
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvOrdem = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cbbCliente = new System.Windows.Forms.ComboBox();
            this.cbbUsuario = new System.Windows.Forms.ComboBox();
            this.LB = new System.Windows.Forms.Label();
            this.txtDatafinal = new System.Windows.Forms.MaskedTextBox();
            this.txtDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.btnNovaOrdem = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RDBaberto = new System.Windows.Forms.RadioButton();
            this.RDBandamento = new System.Windows.Forms.RadioButton();
            this.RDBfinalizado = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrdem
            // 
            this.dgvOrdem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdem.Location = new System.Drawing.Point(12, 97);
            this.dgvOrdem.Name = "dgvOrdem";
            this.dgvOrdem.Size = new System.Drawing.Size(760, 403);
            this.dgvOrdem.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.RDBfinalizado);
            this.groupBox1.Controls.Add(this.RDBandamento);
            this.groupBox1.Controls.Add(this.RDBaberto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.cbbCliente);
            this.groupBox1.Controls.Add(this.cbbUsuario);
            this.groupBox1.Controls.Add(this.LB);
            this.groupBox1.Controls.Add(this.txtDatafinal);
            this.groupBox1.Controls.Add(this.txtDataInicial);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 79);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Data Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Data Inicial";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnPesquisar.Location = new System.Drawing.Point(637, 13);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(117, 57);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cbbCliente
            // 
            this.cbbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCliente.FormattingEnabled = true;
            this.cbbCliente.Location = new System.Drawing.Point(252, 49);
            this.cbbCliente.Name = "cbbCliente";
            this.cbbCliente.Size = new System.Drawing.Size(174, 21);
            this.cbbCliente.TabIndex = 4;
            // 
            // cbbUsuario
            // 
            this.cbbUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbUsuario.DropDownHeight = 100;
            this.cbbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUsuario.FormattingEnabled = true;
            this.cbbUsuario.IntegralHeight = false;
            this.cbbUsuario.Location = new System.Drawing.Point(432, 49);
            this.cbbUsuario.Name = "cbbUsuario";
            this.cbbUsuario.Size = new System.Drawing.Size(121, 21);
            this.cbbUsuario.TabIndex = 3;
            // 
            // LB
            // 
            this.LB.AutoSize = true;
            this.LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB.Location = new System.Drawing.Point(112, 54);
            this.LB.Name = "LB";
            this.LB.Size = new System.Drawing.Size(28, 16);
            this.LB.TabIndex = 2;
            this.LB.Text = "Ate";
            // 
            // txtDatafinal
            // 
            this.txtDatafinal.Location = new System.Drawing.Point(146, 50);
            this.txtDatafinal.Mask = "00/00/0000";
            this.txtDatafinal.Name = "txtDatafinal";
            this.txtDatafinal.Size = new System.Drawing.Size(100, 20);
            this.txtDatafinal.TabIndex = 1;
            this.txtDatafinal.ValidatingType = typeof(System.DateTime);
            this.txtDatafinal.Click += new System.EventHandler(this.txtDatafinal_Click);
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.Location = new System.Drawing.Point(6, 50);
            this.txtDataInicial.Mask = "00/00/0000";
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Size = new System.Drawing.Size(100, 20);
            this.txtDataInicial.TabIndex = 0;
            this.txtDataInicial.ValidatingType = typeof(System.DateTime);
            this.txtDataInicial.Click += new System.EventHandler(this.txtDataInicial_Click);
            // 
            // btnNovaOrdem
            // 
            this.btnNovaOrdem.BackColor = System.Drawing.Color.SkyBlue;
            this.btnNovaOrdem.Location = new System.Drawing.Point(578, 506);
            this.btnNovaOrdem.Name = "btnNovaOrdem";
            this.btnNovaOrdem.Size = new System.Drawing.Size(94, 43);
            this.btnNovaOrdem.TabIndex = 3;
            this.btnNovaOrdem.Text = "Nova Ordem";
            this.btnNovaOrdem.UseVisualStyleBackColor = false;
            this.btnNovaOrdem.Click += new System.EventHandler(this.btnNovaOrdem_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCliente.Location = new System.Drawing.Point(678, 506);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(94, 43);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(-1, 553);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(786, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = " || F2 - Atualizar ||";
            // 
            // RDBaberto
            // 
            this.RDBaberto.AutoSize = true;
            this.RDBaberto.Location = new System.Drawing.Point(559, 13);
            this.RDBaberto.Name = "RDBaberto";
            this.RDBaberto.Size = new System.Drawing.Size(56, 17);
            this.RDBaberto.TabIndex = 12;
            this.RDBaberto.TabStop = true;
            this.RDBaberto.Text = "Aberto";
            this.RDBaberto.UseVisualStyleBackColor = true;
            // 
            // RDBandamento
            // 
            this.RDBandamento.AutoSize = true;
            this.RDBandamento.Location = new System.Drawing.Point(559, 33);
            this.RDBandamento.Name = "RDBandamento";
            this.RDBandamento.Size = new System.Drawing.Size(79, 17);
            this.RDBandamento.TabIndex = 13;
            this.RDBandamento.TabStop = true;
            this.RDBandamento.Text = "Andamento";
            this.RDBandamento.UseVisualStyleBackColor = true;
            // 
            // RDBfinalizado
            // 
            this.RDBfinalizado.AutoSize = true;
            this.RDBfinalizado.Location = new System.Drawing.Point(559, 54);
            this.RDBfinalizado.Name = "RDBfinalizado";
            this.RDBfinalizado.Size = new System.Drawing.Size(72, 17);
            this.RDBfinalizado.TabIndex = 14;
            this.RDBfinalizado.TabStop = true;
            this.RDBfinalizado.Text = "Finalizado";
            this.RDBfinalizado.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(784, 572);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnNovaOrdem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvOrdem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ordem De Serviço";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrdem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbUsuario;
        private System.Windows.Forms.Label LB;
        private System.Windows.Forms.MaskedTextBox txtDatafinal;
        private System.Windows.Forms.MaskedTextBox txtDataInicial;
        private System.Windows.Forms.Button btnNovaOrdem;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cbbCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton RDBfinalizado;
        private System.Windows.Forms.RadioButton RDBandamento;
        private System.Windows.Forms.RadioButton RDBaberto;
    }
}

