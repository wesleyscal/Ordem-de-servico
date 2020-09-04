using System;
using System.Data;
using System.Windows.Forms;

namespace ordem_de_servico
{
    public partial class NovaOrdem : Form
    {
        public NovaOrdem()
        {
            InitializeComponent();
        }

        private clasegury CG = new clasegury();

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

        private void SalvarOrdem()
        {
            //Validações
            if (CBBcliente.Text.Trim() == "")
            {
                MessageBox.Show("Informe um cliente!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (CBBusuario.SelectedIndex == 0)
            {
                MessageBox.Show("Informe um usuário!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (CBBprioridade.SelectedIndex == 0)
            {
                MessageBox.Show("Informe uma prioridade!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (TXTtitulo.Text.Trim() == "")
            {
                MessageBox.Show("Informe um título!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (TXTdescricao.Text.Trim() == "")
            {
                MessageBox.Show("Informe a descrição!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult confirm = MessageBox.Show("Deseja Continuar?", "Salvar Ordem", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm == DialogResult.Yes)
            {
                string id_cliente = TXTcodigo.Text;
                string usuario = CBBusuario.Text;
                string prioridade = CBBprioridade.Text;
                string data_hora = CG.DataHoraMySQL(DTPnovaOrdem.Text);
                string titulo = TXTtitulo.Text;
                string descricao = TXTdescricao.Text;
                string estado = "Aberto";

                string cmd = "insert into ordem_servico values(null," + id_cliente + ",'" + usuario + "','" + prioridade + "','" + data_hora + "','" + titulo + "','" + descricao + "','" + estado + "','');";
                CG.ExecutarComandoSql(cmd);

                LimparTela();
            }
        }

        private void LimparTela()
        {
            TXTcodigo.Clear();
            TXTdescricao.Clear();
            TXTsetor.Clear();
            TXTtitulo.Clear();
            CBBcliente.Items.Clear();
            CarregarDadosComboBox();
            CBBprioridade.SelectedIndex = 0;
            CBBusuario.SelectedIndex = 0;
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
                CBBcliente.Select();
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
            LimparTela();
        }

        private void BTNsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                SalvarOrdem();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!\n\n" + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}