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
    public partial class data : Form
    {
        clasegury CG = new clasegury();

        public data()
        {            
            InitializeComponent();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            clasegury.DataInicial = txtDataInicial.Text;
            clasegury.DataFinal = txtDatafinal.Text;
            Close();
        }
    }
}
