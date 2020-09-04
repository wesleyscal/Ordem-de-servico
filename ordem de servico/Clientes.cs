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

        private void SalvarCliente()
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

        private void ExcluirCliente()
        {
            int x = 0;
            foreach (DataGridViewRow r in DGVcliente.Rows)
            {
                if (r.Selected)
                {
                    x++;
                }
            }
            if (x == 0)
            {
                MessageBox.Show("Nenhum cliente selecionado!", Text);
                return;
            }

            //vsariavel
            string cliente = DGVcliente.CurrentRow.Cells[0].Value.ToString();
            string cmd = "delete from ordem_cliente where id = " + cliente + ";";

            DialogResult confirm = MessageBox.Show("Deseja Continuar?", "Excluir Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "YES")
            {
                CG.ExecutarComandoSql(cmd);
                AtualizarDGV();
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

            string teste = DGVcliente.CurrentCell.Value.ToString();
            MessageBox.Show(teste);
        }

        private void BTNsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXTcliente.Text.Trim() != "")
                {
                    if (CBBsetor.Text != "Escolha um setor")
                    {
                        SalvarCliente();

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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirCliente();
        }
    }
}