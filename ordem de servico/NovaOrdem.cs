using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ordem_de_servico
{

    public partial class NovaOrdem : Form
    {
        public NovaOrdem()
        {
            InitializeComponent();
        }
        clasegury CG = new clasegury();

        //Metados
        private void CarregarDadosComboBox()
        {
            //Limpa o ComboBox
            CBBcliente.Items.Clear();

            //Declara um DataTable
            DataTable dt;

            //Pesquisam os nomes dos clientes no banco de dados
            string cmd = "SELECT cliente FROM ordem_cliente;";
            CG.ExecutarComandoSql(cmd);

            //Instancia o DataTable e insere o retorno do banco de dados no mesmo
            dt = new DataTable();
            CG.RetornarDadosDataTable(dt);

            //Variável que receberá o nome do cliente
            string Cliente = "";

            //Para Cada Cliente inserido no DataTable
            foreach (DataRow r in dt.Rows)
            {
                //Retorna o nome do cliente na variável
                Cliente = r[0].ToString();

                //Insere o nome do cliente na ComboBox
                CBBcliente.Items.Add(Cliente);
            }
        }
        private void CarregarInformacoesClienteSelecaoComboBox()
        {
            //Limpam os dados anteriores
            TXTcodigo.Clear();
            TXTsetor.Clear();

            //Variáveis
            DataTable dt;
            string Codigo = "";
            string Cliente = "";
            string Setor = "";

            Cliente = CBBcliente.Text;

            string cmd = "SELECT Id, setor FROM ordem_cliente WHERE Cliente = '" + Cliente + "';";
            CG.ExecutarComandoSql(cmd);

            dt = new DataTable();
            CG.RetornarDadosDataTable(dt);

            Codigo = dt.Rows[0][0].ToString();
            Setor = dt.Rows[0][1].ToString();

            TXTcodigo.Text = Codigo;
            TXTsetor.Text = Setor;

        }
        private void CarregarUsuarios()
        {
            CBBusuario.Items.Add("Escolha Um Usuario");
            CBBusuario.Items.Add("Lucas");
            CBBusuario.Items.Add("Wesley Gury");

            CBBusuario.SelectedIndex = 0;
        }
        private void CarregarPrioridade()
        {
            CBBprioridade.Items.Add("Escolha a prioridade");
            CBBprioridade.Items.Add("Baixa");
            CBBprioridade.Items.Add("Media");
            CBBprioridade.Items.Add("Alta");
            CBBprioridade.Items.Add("Urgente");

            CBBprioridade.SelectedIndex = 0;
        }

        //Form
        private void NovaOrdem_Load(object sender, EventArgs e)
        {
            try
            {
                CG.FormatarDTP(DTPnovaOrdem);
                CarregarDadosComboBox();
                CarregarUsuarios();
                CarregarPrioridade();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!\n\n" + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //ComboBox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CarregarInformacoesClienteSelecaoComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!\n\n" + ex.Message, Text);
                return;
            }
        }

        //Botão
        private void BTNlimpar_Click(object sender, EventArgs e)
        {
            TXTcodigo.Clear();
            TXTdescricao.Clear();
            TXTsetor.Clear();
            TXTtitulo.Clear();
            CBBcliente.Items.Clear();
            CBBprioridade.SelectedIndex = 0;
            CBBusuario.SelectedIndex = 0;

        }
    }
}
