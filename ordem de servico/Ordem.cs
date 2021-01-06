using Fd_DBC;
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

        private DBC CG = new DBC();

        /* Anotação
         *
         * Tamanho normao:  436 ou 420 nao lembro
         *
         * Tamanho Grande:  800
         *
         */

        //Metodos
        private void ExcluirObservacao()
        {
            int x = 0;
            foreach (DataGridViewRow r in dgvObservacao.Rows)
            {
                if (r.Selected)
                {
                    x++;
                }
            }
            if (x == 0)
            {
                MessageBox.Show("Nenhuma Observação selecionada!", Text);
                return;
            }

            //vsariavel
            string observacao = dgvObservacao.CurrentRow.Cells[0].Value.ToString();
            string cmd = "delete from ordem_servico_observacao where id = " + observacao + ";";

            DialogResult confirm = MessageBox.Show("Deseja Continuar?", "Excluir Observacao", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "YES")
            {
                CG.ExecutarComandoSql(cmd);
                CarregarInformacoesObservacao();
            }
        }
        private void CarregarInformacoesPesquisa()
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
            }
        }
        private void CarregarInformacoesObservacao()
        {
            string IdServico = TXTcodigo.Text;
            string cmd = "SELECT ordem_servico_observacao.id, ordem_servico_observacao.data, ordem_servico_observacao.observacao FROM ordem_servico_observacao where id_servico = " + IdServico + ";";
            CG.ExecutarComandoSql(cmd);
            CG.ExibirDGV(dgvObservacao);
            CG.FormatarDGV(dgvObservacao);
        }

        //Form
        private void Ordem_Load(object sender, EventArgs e)
        {
            cbbStatus.Items.Add("Aberto");
            cbbStatus.Items.Add("Andamento");
            cbbStatus.Items.Add("Finalizado");

            CarregarInformacoesPesquisa();
            CarregarInformacoesObservacao();
        }

        //Botão
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string codigo = TXTcodigo.Text;
            string status = cbbStatus.Text;
            string observacao = txtObservacao.Text;

            string cmd = "UPDATE `ordem_servico` SET `estado` = '" + status + "' WHERE (`id` = '" + codigo + "');";
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
        private void btnSalvarOb_Click(object sender, EventArgs e)
        {
            if (txtObservacao.Text.Trim() != "")
            {
                string IdServico = TXTcodigo.Text;
                string Observacao = txtObservacao.Text;
                string Data = CG.DataMySQL(DateTime.Today.ToString());

                string cmd = "INSERT INTO `ordem_servico_observacao` (`id_servico`, `observacao`, `data`) VALUES ('" + IdServico + "', '" + Observacao + "', '" + Data + "');";
                CG.ExecutarComandoSql(cmd);
                CarregarInformacoesObservacao();
                txtObservacao.Clear();
            }
            else
            {
                MessageBox.Show("Campo Observações esta sem preencher");
            }
        }
        private void btnExcluirOb_Click(object sender, EventArgs e)
        {
            ExcluirObservacao();
        }

        //DataGridView
        private void dgvObservacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = 0;
            foreach (DataGridViewRow r in dgvObservacao.Rows)
            {
                if (r.Selected)
                {
                    x++;
                }
            }
            if (x == 0)
            {
                MessageBox.Show("Nenhuma Observação selecionada!", Text);
                return;
            }

            string observacao = dgvObservacao.CurrentRow.Cells[2].Value.ToString();

            MessageBox.Show(observacao);
        }
    }
}