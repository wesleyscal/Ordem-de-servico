using System;
using System.Windows.Forms;

namespace ordem_de_servico
{
    public partial class Clientes : Form
    {
        private clasegury CG = new clasegury();

        public Clientes()
        {
            InitializeComponent();
        }

        //Metodo
        private void Setores()
        {
            CBBsetor.Items.Add("Escolha um setor");
            CBBsetor.Items.Add("TI");
            CBBsetor.Items.Add("Fogão");
            CBBsetor.Items.Add("Financeiro");
            CBBsetor.Items.Add("Vendas");
            CBBsetor.Items.Add("Compras");
            CBBsetor.Items.Add("Logistica/faturamento");
            CBBsetor.Items.Add("Almoxarifado");
            CBBsetor.Items.Add("Meio De Fabrica");
            CBBsetor.Items.Add("Recursos Humanos");
            CBBsetor.Items.Add("PCP");
            CBBsetor.Items.Add("Engenharia");
            CBBsetor.Items.Add("Refeitorio");
            CBBsetor.Items.Add("Manutenção");
            CBBsetor.SelectedIndex = 0;
        }

        private void AtualizarDGV()
        {
            string cmd = "SELECT * FROM ordem_cliente;";
            CG.ExecutarComandoSql(cmd);
            CG.ExibirDGV(DGVcliente);
            CG.FormatarDGV(DGVcliente);
        }

        private void SalvarProduto()
        {
            DialogResult confirm = MessageBox.Show("Deseja Continuar?", "Salvar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "YES")
            {
                string cliente = TXTcliente.Text.Trim();

                string cmd = "INSERT INTO ordem_cliente VALUES(NULL,'" + cliente + "','" + CBBsetor.Text + "');";
                CG.ExecutarComandoSql(cmd);
                TXTcliente.Clear();
                CBBsetor.SelectedIndex = 0;
            }
        }

        //Form
        private void Clientes_Load(object sender, EventArgs e)
        {
            Setores();

            AtualizarDGV();
        }

        //Botão
        private void BTNlimpar_Click(object sender, EventArgs e)
        {
            TXTcliente.Clear();
            CBBsetor.SelectedIndex = 0;
        }

        private void BTNsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXTcliente.Text.Trim() != "")
                {
                    if (CBBsetor.Text != "Escolha um setor")
                    {
                        SalvarProduto();

                        AtualizarDGV();
                    }
                    else
                    {
                        MessageBox.Show("Por Favor Informe um setor");
                    }
                }
                else
                {
                    MessageBox.Show("Por Favor Informe o Nome do Cliente Que Deseja Salvar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!\n\n" + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DELETE FROM `ods_teste`.`ordem_cliente` WHERE (`id` = '13');
        }
    }
}