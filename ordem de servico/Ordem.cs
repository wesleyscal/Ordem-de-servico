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

        private void CarregarInformarcoesPesquisa()
        {
            if (Form1.dt.Rows.Count == 0)
            {
                return;
            }

            foreach (DataRow r in Form1.dt.Rows)
            {
                TXTcodigo.Text = r[0].ToString();
                txtCliente.Text = r[1].ToString();
                TXTsetor.Text = r[2].ToString();
                txtUsuario.Text = r[3].ToString();
                txtPrioridade.Text = r[4].ToString();
                mtbDataHora.Text = r[5].ToString();
                TXTtitulo.Text = r[6].ToString();
                TXTdescricao.Text = r[7].ToString();
                cbbStatus.SelectedItem = r[8].ToString();
                txtobservacao.Text = r[9].ToString();
            }
        }

        private void Ordem_Load(object sender, EventArgs e)
        {
            cbbStatus.Items.Add("Aberto");
            cbbStatus.Items.Add("Andamento");
            cbbStatus.Items.Add("Finalizado");

            CarregarInformarcoesPesquisa();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
        }

        private void btnObservacao_Click(object sender, EventArgs e)
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