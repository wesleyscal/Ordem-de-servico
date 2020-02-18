namespace ordem_de_servico
{
    partial class NovaOrdem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBBcliente = new System.Windows.Forms.ComboBox();
            this.CBBprioridade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTdescricao = new System.Windows.Forms.TextBox();
            this.CBBusuario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTtitulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTsetor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXTcodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DTPnovaOrdem = new System.Windows.Forms.DateTimePicker();
            this.BTNsalvar = new System.Windows.Forms.Button();
            this.BTNlimpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // CBBcliente
            // 
            this.CBBcliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBcliente.FormattingEnabled = true;
            this.CBBcliente.Location = new System.Drawing.Point(66, 36);
            this.CBBcliente.Name = "CBBcliente";
            this.CBBcliente.Size = new System.Drawing.Size(168, 21);
            this.CBBcliente.TabIndex = 3;
            this.CBBcliente.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CBBprioridade
            // 
            this.CBBprioridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBprioridade.FormattingEnabled = true;
            this.CBBprioridade.Location = new System.Drawing.Point(143, 33);
            this.CBBprioridade.Name = "CBBprioridade";
            this.CBBprioridade.Size = new System.Drawing.Size(102, 21);
            this.CBBprioridade.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prioridade";
            // 
            // TXTdescricao
            // 
            this.TXTdescricao.Location = new System.Drawing.Point(6, 112);
            this.TXTdescricao.Multiline = true;
            this.TXTdescricao.Name = "TXTdescricao";
            this.TXTdescricao.Size = new System.Drawing.Size(370, 127);
            this.TXTdescricao.TabIndex = 6;
            // 
            // CBBusuario
            // 
            this.CBBusuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBusuario.FormattingEnabled = true;
            this.CBBusuario.Location = new System.Drawing.Point(6, 33);
            this.CBBusuario.Name = "CBBusuario";
            this.CBBusuario.Size = new System.Drawing.Size(131, 21);
            this.CBBusuario.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descrição";
            // 
            // TXTtitulo
            // 
            this.TXTtitulo.Location = new System.Drawing.Point(6, 73);
            this.TXTtitulo.Name = "TXTtitulo";
            this.TXTtitulo.Size = new System.Drawing.Size(370, 20);
            this.TXTtitulo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Titulo";
            // 
            // TXTsetor
            // 
            this.TXTsetor.BackColor = System.Drawing.Color.LightYellow;
            this.TXTsetor.Location = new System.Drawing.Point(240, 37);
            this.TXTsetor.Name = "TXTsetor";
            this.TXTsetor.ReadOnly = true;
            this.TXTsetor.Size = new System.Drawing.Size(136, 20);
            this.TXTsetor.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Setor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXTcodigo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.CBBcliente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TXTsetor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 65);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info Cliente";
            // 
            // TXTcodigo
            // 
            this.TXTcodigo.BackColor = System.Drawing.Color.LightYellow;
            this.TXTcodigo.Location = new System.Drawing.Point(6, 36);
            this.TXTcodigo.Name = "TXTcodigo";
            this.TXTcodigo.ReadOnly = true;
            this.TXTcodigo.Size = new System.Drawing.Size(54, 20);
            this.TXTcodigo.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Codigo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Data E Hora";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DTPnovaOrdem);
            this.groupBox2.Controls.Add(this.TXTdescricao);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.CBBprioridade);
            this.groupBox2.Controls.Add(this.CBBusuario);
            this.groupBox2.Controls.Add(this.TXTtitulo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 249);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados";
            // 
            // DTPnovaOrdem
            // 
            this.DTPnovaOrdem.Location = new System.Drawing.Point(251, 34);
            this.DTPnovaOrdem.Name = "DTPnovaOrdem";
            this.DTPnovaOrdem.Size = new System.Drawing.Size(125, 20);
            this.DTPnovaOrdem.TabIndex = 15;
            this.DTPnovaOrdem.Value = new System.DateTime(2020, 2, 14, 8, 44, 1, 0);
            // 
            // BTNsalvar
            // 
            this.BTNsalvar.BackColor = System.Drawing.Color.SkyBlue;
            this.BTNsalvar.Location = new System.Drawing.Point(12, 338);
            this.BTNsalvar.Name = "BTNsalvar";
            this.BTNsalvar.Size = new System.Drawing.Size(198, 32);
            this.BTNsalvar.TabIndex = 16;
            this.BTNsalvar.Text = "Salvar";
            this.BTNsalvar.UseVisualStyleBackColor = false;
            // 
            // BTNlimpar
            // 
            this.BTNlimpar.BackColor = System.Drawing.Color.SkyBlue;
            this.BTNlimpar.Location = new System.Drawing.Point(216, 338);
            this.BTNlimpar.Name = "BTNlimpar";
            this.BTNlimpar.Size = new System.Drawing.Size(178, 32);
            this.BTNlimpar.TabIndex = 17;
            this.BTNlimpar.Text = "Limpar";
            this.BTNlimpar.UseVisualStyleBackColor = false;
            this.BTNlimpar.Click += new System.EventHandler(this.BTNlimpar_Click);
            // 
            // NovaOrdem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(406, 377);
            this.Controls.Add(this.BTNlimpar);
            this.Controls.Add(this.BTNsalvar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NovaOrdem";
            this.Text = "NovaOrdem";
            this.Load += new System.EventHandler(this.NovaOrdem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBBcliente;
        private System.Windows.Forms.ComboBox CBBprioridade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTdescricao;
        private System.Windows.Forms.ComboBox CBBusuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTtitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTsetor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker DTPnovaOrdem;
        private System.Windows.Forms.TextBox TXTcodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BTNsalvar;
        private System.Windows.Forms.Button BTNlimpar;
    }
}