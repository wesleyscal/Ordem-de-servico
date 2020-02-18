namespace ordem_de_servico
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.DGVcliente = new System.Windows.Forms.DataGridView();
            this.TXTcliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNsalvar = new System.Windows.Forms.Button();
            this.BTNlimpar = new System.Windows.Forms.Button();
            this.CBBsetor = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVcliente
            // 
            this.DGVcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVcliente.Location = new System.Drawing.Point(12, 78);
            this.DGVcliente.Name = "DGVcliente";
            this.DGVcliente.Size = new System.Drawing.Size(329, 196);
            this.DGVcliente.TabIndex = 0;
            // 
            // TXTcliente
            // 
            this.TXTcliente.Location = new System.Drawing.Point(6, 35);
            this.TXTcliente.Name = "TXTcliente";
            this.TXTcliente.Size = new System.Drawing.Size(159, 20);
            this.TXTcliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "setor";
            // 
            // BTNsalvar
            // 
            this.BTNsalvar.BackColor = System.Drawing.Color.SkyBlue;
            this.BTNsalvar.Location = new System.Drawing.Point(193, 280);
            this.BTNsalvar.Name = "BTNsalvar";
            this.BTNsalvar.Size = new System.Drawing.Size(71, 38);
            this.BTNsalvar.TabIndex = 5;
            this.BTNsalvar.Text = "Salvar";
            this.BTNsalvar.UseVisualStyleBackColor = false;
            this.BTNsalvar.Click += new System.EventHandler(this.BTNsalvar_Click);
            // 
            // BTNlimpar
            // 
            this.BTNlimpar.BackColor = System.Drawing.Color.SkyBlue;
            this.BTNlimpar.Location = new System.Drawing.Point(270, 280);
            this.BTNlimpar.Name = "BTNlimpar";
            this.BTNlimpar.Size = new System.Drawing.Size(71, 38);
            this.BTNlimpar.TabIndex = 6;
            this.BTNlimpar.Text = "Limpar";
            this.BTNlimpar.UseVisualStyleBackColor = false;
            this.BTNlimpar.Click += new System.EventHandler(this.BTNlimpar_Click);
            // 
            // CBBsetor
            // 
            this.CBBsetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBsetor.FormattingEnabled = true;
            this.CBBsetor.Location = new System.Drawing.Point(172, 34);
            this.CBBsetor.Name = "CBBsetor";
            this.CBBsetor.Size = new System.Drawing.Size(151, 21);
            this.CBBsetor.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXTcliente);
            this.groupBox1.Controls.Add(this.CBBsetor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 63);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(353, 323);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTNlimpar);
            this.Controls.Add(this.BTNsalvar);
            this.Controls.Add(this.DGVcliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVcliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVcliente;
        private System.Windows.Forms.TextBox TXTcliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNsalvar;
        private System.Windows.Forms.Button BTNlimpar;
        private System.Windows.Forms.ComboBox CBBsetor;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}