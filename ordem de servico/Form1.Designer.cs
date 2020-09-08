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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvOrdem = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnData = new System.Windows.Forms.Button();
            this.RDBfinalizado = new System.Windows.Forms.RadioButton();
            this.RDBandamento = new System.Windows.Forms.RadioButton();
            this.RDBaberto = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cbbCliente = new System.Windows.Forms.ComboBox();
            this.cbbUsuario = new System.Windows.Forms.ComboBox();
            this.btnNovaOrdem = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.dgvOrdem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdem_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.btnData);
            this.groupBox1.Controls.Add(this.RDBfinalizado);
            this.groupBox1.Controls.Add(this.RDBandamento);
            this.groupBox1.Controls.Add(this.RDBaberto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.cbbCliente);
            this.groupBox1.Controls.Add(this.cbbUsuario);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 79);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // btnData
            // 
            this.btnData.BackColor = System.Drawing.Color.SkyBlue;
            this.btnData.Location = new System.Drawing.Point(6, 16);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(117, 57);
            this.btnData.TabIndex = 15;
            this.btnData.Text = "Data";
            this.btnData.UseVisualStyleBackColor = false;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // RDBfinalizado
            // 
            this.RDBfinalizado.AutoSize = true;
            this.RDBfinalizado.Location = new System.Drawing.Point(516, 56);
            this.RDBfinalizado.Name = "RDBfinalizado";
            this.RDBfinalizado.Size = new System.Drawing.Size(72, 17);
            this.RDBfinalizado.TabIndex = 14;
            this.RDBfinalizado.TabStop = true;
            this.RDBfinalizado.Text = "Finalizado";
            this.RDBfinalizado.UseVisualStyleBackColor = true;
            // 
            // RDBandamento
            // 
            this.RDBandamento.AutoSize = true;
            this.RDBandamento.Location = new System.Drawing.Point(516, 35);
            this.RDBandamento.Name = "RDBandamento";
            this.RDBandamento.Size = new System.Drawing.Size(79, 17);
            this.RDBandamento.TabIndex = 13;
            this.RDBandamento.TabStop = true;
            this.RDBandamento.Text = "Andamento";
            this.RDBandamento.UseVisualStyleBackColor = true;
            // 
            // RDBaberto
            // 
            this.RDBaberto.AutoSize = true;
            this.RDBaberto.Location = new System.Drawing.Point(516, 12);
            this.RDBaberto.Name = "RDBaberto";
            this.RDBaberto.Size = new System.Drawing.Size(56, 17);
            this.RDBaberto.TabIndex = 12;
            this.RDBaberto.TabStop = true;
            this.RDBaberto.Text = "Aberto";
            this.RDBaberto.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cliente";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnPesquisar.Location = new System.Drawing.Point(601, 16);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(153, 57);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cbbCliente
            // 
            this.cbbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCliente.FormattingEnabled = true;
            this.cbbCliente.Location = new System.Drawing.Point(129, 52);
            this.cbbCliente.Name = "cbbCliente";
            this.cbbCliente.Size = new System.Drawing.Size(214, 21);
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
            this.cbbUsuario.Location = new System.Drawing.Point(349, 52);
            this.cbbUsuario.Name = "cbbUsuario";
            this.cbbUsuario.Size = new System.Drawing.Size(161, 21);
            this.cbbUsuario.TabIndex = 3;
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
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(786, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = " || F2 - Atualizar ||";
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button btnNovaOrdem;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cbbCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton RDBfinalizado;
        private System.Windows.Forms.RadioButton RDBandamento;
        private System.Windows.Forms.RadioButton RDBaberto;
        public System.Windows.Forms.Button btnData;
    }
}

