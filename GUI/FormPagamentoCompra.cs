using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormPagamentoCompra : Form
    {
        public int pcoCod = 0;
        public FormPagamentoCompra()
        {
            InitializeComponent();
        }
        private void BtBusca_Click_1(object sender, EventArgs e)
        {
            FrmConsultaCompra f = new FrmConsultaCompra();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra bll = new BLLCompra(cx);
                ModeloCompra modelo = bll.CarregaModeloCompra(f.codigo);
                TxtCodigo.Text = modelo.ComCod.ToString();
                //txtNFiscal.Text = modelo.ComNFiscal.ToString();
                DtCompra.Value = modelo.ComData;
                TxtValor.Text = modelo.ComTotal.ToString();
                BLLFornecedor bllf = new BLLFornecedor(cx);
                ModeloFornecedor modelof = bllf.CarregaModeloFornecedor(modelo.ForCod);
                TxtNome.Text = modelof.ForNome;

                BLLParcelasCompra bllp = new BLLParcelasCompra(cx);
                DgvDados.DataSource = bllp.Localizar(modelo.ComCod);
                DgvDados.Columns[0].HeaderText = "Parcela";
                DgvDados.Columns[1].HeaderText = "Valor";
                DgvDados.Columns[2].HeaderText = "Pago em";
                DgvDados.Columns[3].HeaderText = "Vencimento";
                DgvDados.Columns[4].Visible = false;
                //AlteraBotoes(3);
            }
            else
            {
                //this.LimpaTela();
                //this.AlteraBotoes(1);
            }
            f.Dispose();
        }

        private void BtPagar_Click_1(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLParcelasCompra bllp = new BLLParcelasCompra(cx);
            int comCod = Convert.ToInt32(TxtCodigo.Text);

            DateTime dtpagto = DtPagamento.Value;
            bllp.EfetuarPagamentoParcela(comCod, this.pcoCod, dtpagto);
            BLLParcelasCompra bllp2 = new BLLParcelasCompra(cx);
            DgvDados.DataSource = bllp2.Localizar(comCod);
            DgvDados.Columns[0].HeaderText = "Parcela";
            DgvDados.Columns[1].HeaderText = "Valor";
            DgvDados.Columns[2].HeaderText = "Pago em";
            DgvDados.Columns[3].HeaderText = "Vencimento";
            DgvDados.Columns[4].Visible = false;
            BtPagar.Enabled = false;
        }

        private void DgvDados_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            BtPagar.Enabled = false;
            this.pcoCod = 0;
            if (e.RowIndex >= 0 && DgvDados.Rows[e.RowIndex].Cells[2].Value.ToString() == "")
            {
                BtPagar.Enabled = true;
                this.pcoCod = Convert.ToInt32(DgvDados.Rows[e.RowIndex].Cells[0].Value);
            }
        }
    }
}
