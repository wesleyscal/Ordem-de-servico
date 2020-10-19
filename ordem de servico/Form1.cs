using Fd_DBC;
using System;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace ordem_de_servico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DBC CG = new DBC();
        public static string DataInicial = "";
        public static string DataFinal = "";

        //Metodos
        private void atualizarform()
        {
            string cmd = "SELECT ordem_servico.id 'Codigo', IFNULL(ordem_cliente.cliente, 'CLIENTE NÃO ENCONTRADO') 'Cliente', ordem_servico.titulo 'Título', ordem_servico.prioridade 'Prioridade', ordem_servico.estado 'Situação', ordem_servico.data_hora 'Data / Hora' FROM ordem_servico LEFT OUTER JOIN ordem_cliente ON(ordem_servico.id_cliente = ordem_cliente.id); ";
            CG.ExecutarComandoSql(cmd);
            CG.ExibirDGV(dgvOrdem);
            CG.FormatarDGV(dgvOrdem);
            dgvOrdem.Columns[0].Visible = false;
        }

        private void CarregarDadosComboBox()
        {
            cbbUsuario.Items.Clear();
            cbbCliente.Items.Clear();
            cbbStatus.Items.Clear();

            cbbCliente.Items.Add("Todos os Cliente");
            cbbCliente.SelectedIndex = 0;

            cbbUsuario.Items.Add("Todos os Usuario");
            cbbUsuario.SelectedIndex = 0;

            cbbStatus.Items.Add("Todos os Status");
            cbbStatus.SelectedIndex = 0;

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
                cbbCliente.Items.Add(Cliente);
            }

            //Usuario
            cbbUsuario.Items.Add("Lucas");
            cbbUsuario.Items.Add("Wesley gury");

            //Status
            cbbStatus.Items.Add("Aberto");
            cbbStatus.Items.Add("Andamento");
            cbbStatus.Items.Add("Finalizado");
        }

        public void AlterarNomeBotaoData()
        {
            txtDataInicial.Text = DataInicial;
            txtDataFinal.Text = DataFinal;
        }

        private void NotificacaoInicial()
        {
            DataTable dtNotifica = new DataTable();

            int Aberto = 0;
            int Andamento = 0;
            int Finalizado = 0;

            string cmd = "SELECT " +
                            "ordem_servico.estado " +
                            "FROM " +
                            "ordem_servico ;";

            CG.ExecutarComandoSql(cmd);
            CG.RetornarDadosDataTable(dtNotifica);

            foreach (DataRow r in dtNotifica.Rows)
            {
                if (r[0].ToString() == "Aberto")
                {
                    Aberto++;
                }
                if (r[0].ToString() == "Andamento")
                {
                    Andamento++;
                }
                if (r[0].ToString() == "Finalizado")
                {
                    Finalizado++;
                }
            }

            notifyIcon.BalloonTipTitle = "Ordens";
            notifyIcon.BalloonTipText = "Aberto: " + Aberto + "\n" + "Andamento: " + Andamento + "\n" + "Finalizado: " + Finalizado + "\n";
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.ShowBalloonTip(30000);
        }

        //form
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                CG.ConectarBancoDeDados();
            }
            catch
            {
                ConfigurarBanco CB = new ConfigurarBanco();
                CB.ShowDialog();
            }


            atualizarform();
            CarregarDadosComboBox();
            NotificacaoInicial();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                atualizarform();
            }
            if (e.KeyCode == Keys.F3)
            {
                data Fdat = new data();
                Fdat.ShowDialog(this);
                if (DataFinal != "" && DataInicial != "")
                {
                    AlterarNomeBotaoData();
                }
                else
                {
                    txtDataInicial.Text = "";
                    txtDataFinal.Text = "";
                }
            }
            if (e.KeyCode == Keys.F4)
            {
                ConfigurarBanco CB = new ConfigurarBanco();
                CB.ShowDialog();
            }
        }

        //botão
        private void btnNovaOrdem_Click(object sender, EventArgs e)
        {
            NovaOrdem frm = new NovaOrdem();
            frm.ShowDialog();
            atualizarform();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Clientes frm = new Clientes();
            frm.ShowDialog();
            CarregarDadosComboBox();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //variaveis
            string Data_Inicial = "";
            string Data_Final = "";
            string Cliente = "";
            string Usuario = "";
            string Status = "";

            //Atribuir valor a Condição
            if (DataInicial == "" && DataFinal == "")
            {
                Data_Inicial = "1000-01-01 00:00:00";
                Data_Final = "4000-01-01 00:00:00";
            }
            else
            {
                Data_Inicial = CG.DataMySQL(DataInicial) + " 00:00:00";
                Data_Final = CG.DataMySQL(DataFinal) + " 23:59:59";
            }
            if (cbbCliente.Text == "Todos os Cliente")
            {
                Cliente = "%%";
            }
            else
            {
                Cliente = cbbCliente.Text;
            }
            if (cbbUsuario.Text == "Todos os Usuario")
            {
                Usuario = "%%";
            }
            else
            {
                Usuario = cbbUsuario.Text;
            }
            if (cbbStatus.SelectedIndex == 0)
            {
                Status = "%%";
            }
            else
            {
                Status = cbbStatus.Text;
            }

            string cmd = "SELECT " +
            "ordem_servico.id," +
            "ordem_cliente.cliente 'Cliente'," +
            "ordem_servico.titulo 'Título'," +
            "ordem_servico.prioridade 'Prioridade'," +
            "ordem_servico.estado 'Situação'," +
            "ordem_servico.data_hora 'Data / Hora'" +
            "FROM " +
            "ordem_servico " +
            "LEFT OUTER JOIN " +
            "ordem_cliente ON (ordem_servico.id_cliente = ordem_cliente.id) " +
            "WHERE " +
            "ordem_servico.data_hora BETWEEN '" + Data_Inicial + "' AND '" + Data_Final + "' " +
            "and " +
            "cliente like '" + Cliente + "' " +
            "and " +
            "usuario like '" + Usuario + "' " +
            "and " +
            "estado like '" + Status + "';";

            CG.ExecutarComandoSql(cmd);
            CG.ExibirDGV(dgvOrdem);
            CG.FormatarDGV(dgvOrdem);

            dgvOrdem.Columns[0].Visible = false;
        }

        public static DataTable dt = new DataTable();

        //DataGridView
        private void dgvOrdem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string codigo = dgvOrdem.CurrentRow.Cells[0].Value.ToString();

                string cmd = "SELECT " +
                             "ordem_servico.id 'Codigo'," +
                             "IFNULL(ordem_cliente.cliente," +
                             "'CLIENTE NÃO ENCONTRADO') 'Cliente'," +
                             "ordem_cliente.setor 'Setor'," +
                             "ordem_servico.usuario 'Usuario'," +
                             "ordem_servico.prioridade 'Prioridade'," +
                             "ordem_servico.data_hora 'Data / Hora'," +
                             "ordem_servico.titulo 'Título'," +
                             "ordem_servico.descricao 'Descrição'," +
                             "ordem_servico.estado 'Situação'" +
                             "FROM " +
                             "ordem_servico " +
                             "LEFT OUTER JOIN " +
                             "ordem_cliente ON (ordem_servico.id_cliente = ordem_cliente.id)" +
                             "where " +
                             "ordem_servico.id = " + codigo + ";";
                CG.ExecutarComandoSql(cmd);
                CG.RetornarDadosDataTable(dt);

                Ordem Form = new Ordem();
                Form.ShowDialog();
                atualizarform();
            }
        }
    }
}