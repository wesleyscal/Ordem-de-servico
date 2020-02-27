using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace ordem_de_servico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        clasegury CG = new clasegury();

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

        //form
        private void Form1_Load(object sender, EventArgs e)
        {

            #region Combobox
            cbbCliente.Items.Add("Escolha Um Cliente");
            cbbCliente.SelectedIndex = 0;

            cbbUsuario.Items.Add("Escolha Um Usuario");
            cbbUsuario.SelectedIndex = 0;
            #endregion             

            cbxAberto.Checked = true;

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
        }
        private void btnCliente_Click(object sender, EventArgs e)
        {
            Clientes frm = new Clientes();
            frm.ShowDialog();
        }

        //TextBox
        private void txtDataInicial_Click(object sender, EventArgs e)
        {
            txtDataInicial.Select(0, 0);

        }
        private void txtDatafinal_Click(object sender, EventArgs e)
        {
            txtDatafinal.Select(0, 0);

        }

        /* Teste GitHub Controle de verção
         * 
         * 27/02 - 08:34
         * 
         *  Teste 03
         * 
         */
    }
}
