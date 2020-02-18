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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //form
        private void Form1_Load(object sender, EventArgs e)
        {
            cbbCliente.Items.Add("Escolha Um Cliente");
            cbbCliente.SelectedIndex = 0;

            cbbUsuario.Items.Add("Escolha Um Usuario");
            cbbUsuario.SelectedIndex = 0;
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

        private void cbbCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
