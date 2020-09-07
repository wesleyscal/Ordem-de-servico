using System;
using System.Data;
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

        private clasegury CG = new clasegury();

        //Metodos
        private void atualizarform()
        {
            string cmd = "SELECT IFNULL(ordem_cliente.cliente, 'CLIENTE NÃO ENCONTRADO') 'Cliente', ordem_servico.titulo 'Título', ordem_servico.prioridade 'Prioridade', ordem_servico.estado 'Situação', ordem_servico.data_hora 'Data / Hora' FROM ordem_servico LEFT OUTER JOIN ordem_cliente ON(ordem_servico.id_cliente = ordem_cliente.id); ";
            CG.ExecutarComandoSql(cmd);
            CG.ExibirDGV(dgvOrdem);
            CG.FormatarDGV(dgvOrdem);
        }

        private void CarregarDadosComboBox()
        {
            cbbUsuario.Items.Clear();
            cbbCliente.Items.Clear();

            cbbCliente.Items.Add("Todos os Cliente");
            cbbCliente.SelectedIndex = 0;

            cbbUsuario.Items.Add("Todos os Usuario");
            cbbUsuario.SelectedIndex = 0;

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
        }

        public void AlterarNomeBotaoData()
        {
            btnData.Text = clasegury.DataInicial + "\n Até \n" + clasegury.DataFinal;
        }

        //form
        private void Form1_Load(object sender, EventArgs e)
        {
            RDBaberto.Checked = true;

            atualizarform();
            CarregarDadosComboBox();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                atualizarform();
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
            data Fdat = new data();
            Fdat.ShowDialog(this);
            if (clasegury.DataFinal != "" && clasegury.DataInicial != "")
            {
                AlterarNomeBotaoData();
            }
            else
            {
                btnData.Text = "Data";
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //variaveis
            string Data_Inicial = "";
            string Data_Final = "";
            string Cliente = "";
            string Usuario = "";
            string Estado = "";

            //Atribuir valor a Condição
            if (clasegury.DataInicial == "" && clasegury.DataFinal == "")
            {
                Data_Inicial = "1000-01-01 00:00:00";
                Data_Final = "4000-01-01 00:00:00";
            }
            else
            {
                Data_Inicial = CG.DataMySQL(clasegury.DataInicial) + " 00:00:00";
                Data_Final = CG.DataMySQL(clasegury.DataFinal) + " 23:59:59";
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
            if (RDBaberto.Checked == true)
            {
                Estado = "Aberto";
            }
            else if (RDBandamento.Checked == true)
            {
                Estado = "Andamento";
            }
            else if (RDBfinalizado.Checked == true)
            {
                Estado = "Finalizado";
            }
            else
            {
                MessageBox.Show("Deu Ruim");
            }

            MessageBox.Show(Data_Final);
            MessageBox.Show(Data_Inicial);

            string cmd = "SELECT " +
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
            "estado = '" + Estado + "';";

            CG.ExecutarComandoSql(cmd);
            CG.ExibirDGV(dgvOrdem);
            CG.FormatarDGV(dgvOrdem);
        }

        private void dgvOrdem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Ordem Form = new Ordem();
            Form.ShowDialog();
        }
    }
}