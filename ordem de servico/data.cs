using Fd_DBC;
using System;
using System.Windows.Forms;

namespace ordem_de_servico
{
    public partial class data : Form
    {
        private DBC CG = new DBC();

        //Form
        public data()
        {
            InitializeComponent();
        }

        private void data_Load(object sender, EventArgs e)
        {
            Form1.DataInicial = "";
            Form1.DataFinal = "";
        }

        //botão
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DateTime dataValida;
            if (DateTime.TryParse(txtDataInicial.Text, out dataValida) && DateTime.TryParse(txtDatafinal.Text, out dataValida))
            {
                Form1.DataInicial = txtDataInicial.Text;
                Form1.DataFinal = txtDatafinal.Text;
                Close();
            }
            else
            {
                MessageBox.Show("Por favor infome uma data valida");
            }
        }
    }
}