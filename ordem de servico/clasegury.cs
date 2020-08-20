using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Drawing;

namespace ordem_de_servico
{
    public class clasegury
    {
        private const string Banco = "ods_teste";

        private const string V = "server=localhost;port=3306;User id=root;database=" + Banco + ";password=Pa$$w0rd;CharSet=utf8";
        public MySqlCommand myCMD = new MySqlCommand();
        public MySqlConnection conectarbanco = new MySqlConnection();

        public object Controls { get; private set; }

        #region Banco de dados

        //conectar banco de dados
        public void ConectarBancoDeDados()
        {
            conectarbanco.Close();
            string ConnString = V;
            conectarbanco.ConnectionString = ConnString;
            conectarbanco.Open();

        }

        //Executa comando no MySql
        public void ExecutarComandoSql(string cmd)
        {
            ConectarBancoDeDados();

            myCMD.CommandText = cmd;
            myCMD.CommandType = CommandType.Text;
            myCMD.Connection = conectarbanco;
            myCMD.ExecuteNonQuery();

            conectarbanco.Close();

        }

        //retorna valores do sql
        public string RetornarValorSQL()
        {
            //Instanciar um novo DataTable (Objeto que receberão as infonrmações do banco SQL)
            DataTable dt = new DataTable();

            //Objeto que retornam os valores da pesquisa SQL
            MySqlDataAdapter adp = new MySqlDataAdapter(myCMD);

            //Método que inserem as informações da pesquisa SQL
            adp.Fill(dt);

            return dt.Rows[0][0].ToString();
        }

        //retorna os dados do datatable
        public void RetornarDadosDataTable(DataTable dt)
        {
            //Objeto que retornam os valores da pesquisa SQL
            MySqlDataAdapter adp = new MySqlDataAdapter(myCMD);

            //Método que inserem as informações da pesquisa SQL
            adp.Fill(dt);
        }

        #endregion

        #region DataGridView

        //Exibe dados no DataGreedView
        public void ExibirDGV(DataGridView dgv)
        {

            //Instanciar um novo DataTable (Objeto que receberão as infonrmações do banco SQL)
            DataTable dt = new DataTable();

            //Objeto que retornam os valores da pesquisa SQL
            MySqlDataAdapter adp = new MySqlDataAdapter(myCMD);

            //Método que inserem as informações da pesquisa SQL
            adp.Fill(dt);

            //Exibe os dados no DataGridView usando como fonte de dados o DataTable (dt)
            dgv.DataSource = dt;

        }

        //Formatar DataGridView
        public void FormatarDGV(DataGridView dgv)
        {
            //Básico
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.MultiSelect = false;
            dgv.EnableHeadersVisualStyles = false;

            //Somente leitura
            dgv.ReadOnly = true;

            //Fonte dos Cabeçalhos das Colunas
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 8.25F, FontStyle.Bold);

            //Alternar Cores Linhas
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
        }

        #endregion

        #region Formatar

        //Converte para formata de data do MySql
        public string DataMySQL(string DataNormal)
        {
            string _DataNormal = DataNormal.Replace("/", "-");
            string N_DataMySQL = _DataNormal.Substring(6, 4) +
                                 _DataNormal.Substring(5, 1) +
                                 _DataNormal.Substring(3, 2) +
                                 _DataNormal.Substring(2, 1) +
                                 _DataNormal.Substring(0, 2);
            return N_DataMySQL;
        }

        public string DataHoraMySQL(string DataNormal)
        {
            string _DataNormal = DataNormal.Replace("/", "-");
            string N_DataMySQL = _DataNormal.Substring(6, 4) +
                                 _DataNormal.Substring(5, 1) +
                                 _DataNormal.Substring(3, 2) +
                                 _DataNormal.Substring(2, 1) +
                                 _DataNormal.Substring(0, 2) +
                                 _DataNormal.Substring(10, 1) +
                                 _DataNormal.Substring(11, 8);
            return N_DataMySQL;
        }

        //TEXBOX EM FORMATO NUMÉRICO "MOEDA"
        public void Moeda(TextBox TXT)
        {
            string n = string.Empty;
            double v = 0;

            try
            {
                n = TXT.Text.Replace(",", "").Replace(".", "");

                if (n.Equals(""))
                {
                    n = "000";
                }

                n = n.PadLeft(3, '0');

                if (n.Length > 3 & n.Substring(0, 1) == "0")
                {
                    n = n.Substring(1, n.Length - 1);
                }

                v = Convert.ToDouble(n) / 100;

                TXT.Text = string.Format("{0:N}", v);
                TXT.SelectionStart = TXT.Text.Length;
            }
            catch
            {
            }
        }

        //Formatar DataTimePicker
        public void FormatarDTP(DateTimePicker DTP)
        {
            //Data Minima e Maxima
            DTP.MinDate = new DateTime(2000, 6, 20);
            DTP.MaxDate = DateTime.Now;
            DTP.Value = DateTime.Now;

            //Data Formato
            DTP.Format = DateTimePickerFormat.Custom;
            DTP.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }

        #endregion

        #region Variaveis Publicas

        public static string DataInicial = "D.I";
        public static string DataFinal = "D.F";


        #endregion



    }
}




