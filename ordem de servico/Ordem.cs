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

        private clasegury CG = new clasegury();

        /* Anotação
         *
         * Tamanho normao:  436 ou 420 nao lembro
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
                string id = r[0].ToString(); ;
                CarregarInformacoesObservacao(id);
                TXTcodigo.Text = r[0].ToString();
                txtCliente.Text = r[1].ToString();
                TXTsetor.Text = r[2].ToString();
                txtUsuario.Text = r[3].ToString();
                txtPrioridade.Text = r[4].ToString();
                mtbDataHora.Text = r[5].ToString();
                TXTtitulo.Text = r[6].ToString();
                TXTdescricao.Text = r[7].ToString();
                cbbStatus.SelectedItem = r[8].ToString();
            }
        }

        private void CarregarInformacoesObservacao(string IdServico)
        {
            string cmd = "SELECT ordem_servico_observacao.data, ordem_servico_observacao.observacao FROM ordem_servico_observacao where id_servico = " + IdServico + ";";
            CG.ExecutarComandoSql(cmd);
            CG.ExibirDGV(dgvObservacao);
            CG.FormatarDGV(dgvObservacao);
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
            string codigo = TXTcodigo.Text;
            string status = cbbStatus.Text;
            string observacao = txtObservacao.Text;

            string cmd = "UPDATE `" + clasegury.Banco + "`.`ordem_servico` SET `estado` = '" + status + "' WHERE (`id` = '" + codigo + "');";
            CG.ExecutarComandoSql(cmd);
            Close();
        }

        private void btnObservacao_Click(object sender, EventArgs e)
        {
            if (btnObservacao.BackColor == Color.SkyBlue)
            {
                Ordem.ActiveForm.Width = 800;
                btnObservacao.BackColor = Color.DodgerBlue;
                btnObservacao.Text = "Fechar Observação";
                return;
            }
            if (btnObservacao.BackColor == Color.DodgerBlue)
            {
                Ordem.ActiveForm.Width = 420;
                btnObservacao.BackColor = Color.SkyBlue;
                btnObservacao.Text = "Abrir Observação";
                return;
            }
        }
    }
}