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
    public partial class Ordem : Form
    {
        public Ordem()
        {
            InitializeComponent();
        }

        /* Anotação
         *
         * Tamanho normao:  436
         *
         * Tamanho Grande:  800
         *
         */

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnObservacao.BackColor == Color.SkyBlue)
            {
                Ordem.ActiveForm.Width = 800;
                btnObservacao.BackColor = Color.DodgerBlue;
                return;
            }
            if (btnObservacao.BackColor == Color.DodgerBlue)
            {
                Ordem.ActiveForm.Width = 436;
                btnObservacao.BackColor = Color.SkyBlue;
                return;
            }
        }
    }
}