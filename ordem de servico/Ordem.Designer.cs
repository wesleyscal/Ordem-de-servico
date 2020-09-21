namespace ordem_de_servico
{
    partial class Ordem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ordem));
            this.btnObservacao = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtbDataHora = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.txtPrioridade = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.TXTdescricao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTtitulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TXTcodigo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTsetor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtobservacao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSalvarOb = new System.Windows.Forms.Button();
            this.btnExcluirOb = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObservacao
            // 
            this.btnObservacao.BackColor = System.Drawing.Color.SkyBlue;
            this.btnObservacao.Location = new System.Drawing.Point(216, 335);
            this.btnObservacao.Name = "btnObservacao";
            this.btnObservacao.Size = new System.Drawing.Size(178, 52);
            this.btnObservacao.TabIndex = 8;
            this.btnObservacao.Text = "Abrir Observação";
            this.btnObservacao.UseVisualStyleBackColor = false;
            this.btnObservacao.Click += new System.EventHandler(this.btnObservacao_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mtbDataHora);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbbStatus);
            this.groupBox2.Controls.Add(this.txtPrioridade);
            this.groupBox2.Controls.Add(this.txtUsuario);
            this.groupBox2.Controls.Add(this.TXTdescricao);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TXTtitulo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 249);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados";
            // 
            // mtbDataHora
            // 
            this.mtbDataHora.BackColor = System.Drawing.SystemColors.Info;
            this.mtbDataHora.Enabled = false;
            this.mtbDataHora.Location = new System.Drawing.Point(251, 34);
            this.mtbDataHora.Mask = "00/00/0000 90:00";
            this.mtbDataHora.Name = "mtbDataHora";
            this.mtbDataHora.ReadOnly = true;
            this.mtbDataHora.Size = new System.Drawing.Size(125, 20);
            this.mtbDataHora.TabIndex = 20;
            this.mtbDataHora.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Gray;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(248, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Data E Hora";
            // 
            // cbbStatus
            // 
            this.cbbStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Location = new System.Drawing.Point(251, 73);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(125, 21);
            this.cbbStatus.TabIndex = 17;
            // 
            // txtPrioridade
            // 
            this.txtPrioridade.BackColor = System.Drawing.Color.LightYellow;
            this.txtPrioridade.Enabled = false;
            this.txtPrioridade.Location = new System.Drawing.Point(127, 34);
            this.txtPrioridade.Name = "txtPrioridade";
            this.txtPrioridade.ReadOnly = true;
            this.txtPrioridade.Size = new System.Drawing.Size(118, 20);
            this.txtPrioridade.TabIndex = 16;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.LightYellow;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(6, 34);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(115, 20);
            this.txtUsuario.TabIndex = 15;
            // 
            // TXTdescricao
            // 
            this.TXTdescricao.BackColor = System.Drawing.SystemColors.Info;
            this.TXTdescricao.Enabled = false;
            this.TXTdescricao.Location = new System.Drawing.Point(6, 112);
            this.TXTdescricao.Multiline = true;
            this.TXTdescricao.Name = "TXTdescricao";
            this.TXTdescricao.ReadOnly = true;
            this.TXTdescricao.Size = new System.Drawing.Size(370, 127);
            this.TXTdescricao.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(251, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Titulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(124, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prioridade";
            // 
            // TXTtitulo
            // 
            this.TXTtitulo.BackColor = System.Drawing.SystemColors.Info;
            this.TXTtitulo.Enabled = false;
            this.TXTtitulo.Location = new System.Drawing.Point(6, 73);
            this.TXTtitulo.Name = "TXTtitulo";
            this.TXTtitulo.ReadOnly = true;
            this.TXTtitulo.Size = new System.Drawing.Size(239, 20);
            this.TXTtitulo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descrição";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Gray;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Codigo";
            // 
            // TXTcodigo
            // 
            this.TXTcodigo.BackColor = System.Drawing.Color.LightYellow;
            this.TXTcodigo.Enabled = false;
            this.TXTcodigo.Location = new System.Drawing.Point(6, 36);
            this.TXTcodigo.Name = "TXTcodigo";
            this.TXTcodigo.ReadOnly = true;
            this.TXTcodigo.Size = new System.Drawing.Size(54, 20);
            this.TXTcodigo.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.TXTcodigo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TXTsetor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 65);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.LightYellow;
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(66, 36);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(168, 20);
            this.txtCliente.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(237, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Setor";
            // 
            // TXTsetor
            // 
            this.TXTsetor.BackColor = System.Drawing.Color.LightYellow;
            this.TXTsetor.Enabled = false;
            this.TXTsetor.Location = new System.Drawing.Point(240, 37);
            this.TXTsetor.Name = "TXTsetor";
            this.TXTsetor.ReadOnly = true;
            this.TXTsetor.Size = new System.Drawing.Size(136, 20);
            this.TXTsetor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSalvar.Location = new System.Drawing.Point(12, 335);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(198, 52);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtobservacao
            // 
            this.txtobservacao.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtobservacao.Location = new System.Drawing.Point(411, 195);
            this.txtobservacao.Multiline = true;
            this.txtobservacao.Name = "txtobservacao";
            this.txtobservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtobservacao.Size = new System.Drawing.Size(361, 134);
            this.txtobservacao.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Gray;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(408, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Observação";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(411, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(361, 164);
            this.dataGridView1.TabIndex = 22;
            // 
            // btnSalvarOb
            // 
            this.btnSalvarOb.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSalvarOb.Location = new System.Drawing.Point(411, 335);
            this.btnSalvarOb.Name = "btnSalvarOb";
            this.btnSalvarOb.Size = new System.Drawing.Size(180, 52);
            this.btnSalvarOb.TabIndex = 23;
            this.btnSalvarOb.Text = "Salvar Observação";
            this.btnSalvarOb.UseVisualStyleBackColor = false;
            // 
            // btnExcluirOb
            // 
            this.btnExcluirOb.BackColor = System.Drawing.Color.SkyBlue;
            this.btnExcluirOb.Location = new System.Drawing.Point(597, 335);
            this.btnExcluirOb.Name = "btnExcluirOb";
            this.btnExcluirOb.Size = new System.Drawing.Size(175, 52);
            this.btnExcluirOb.TabIndex = 24;
            this.btnExcluirOb.Text = "Excluir Observação";
            this.btnExcluirOb.UseVisualStyleBackColor = false;
            // 
            // Ordem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(784, 399);
            this.Controls.Add(this.btnExcluirOb);
            this.Controls.Add(this.btnSalvarOb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtobservacao);
            this.Controls.Add(this.btnObservacao);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Ordem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordem";
            this.Load += new System.EventHandler(this.Ordem_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObservacao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TXTdescricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTtitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TXTcodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXTsetor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.TextBox txtPrioridade;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtobservacao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mtbDataHora;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSalvarOb;
        private System.Windows.Forms.Button btnExcluirOb;
    }
}