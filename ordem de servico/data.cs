using System;
using System.Windows.Forms;

namespace ordem_de_servico
{
    public partial class data : Form
    {
        private clasegury CG = new clasegury();

        //Form
        public data()
        {
            InitializeComponent();
        }

        private void data_Load(object sender, EventArgs e)
        {
            clasegury.DataInicial = "";
            clasegury.DataFinal = "";
        }

        //botão
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DateTime dataValida;
            if (DateTime.TryParse(txtDataInicial.Text, out dataValida) && DateTime.TryParse(txtDatafinal.Text, out dataValida))
            {
                clasegury.DataInicial = txtDataInicial.Text;
                clasegury.DataFinal = txtDatafinal.Text;
                Close();
            }
            else
            {
                MessageBox.Show("Por favor infome uma data valida");
            }
        }
    }
}