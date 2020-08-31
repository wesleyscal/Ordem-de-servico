using System;
using System.Windows.Forms;

namespace ordem_de_servico
{
    public partial class data : Form
    {
        private clasegury CG = new clasegury();

        public data()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            clasegury.DataInicial = txtDataInicial.Text;

            clasegury.DataFinal = txtDatafinal.Text;

            Close();
        }
    }
}