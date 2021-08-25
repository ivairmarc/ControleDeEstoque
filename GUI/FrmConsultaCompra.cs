using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using Modelo;

namespace GUI
{
    public partial class FrmConsultaCompra : Form
    {

        public int codigo = 0;
        public FrmConsultaCompra()
        {
            InitializeComponent();
        }

        private void FrmConsultaCompra_Load(object sender, EventArgs e)
        {
            rbGeral_CheckedChanged(sender, e);
        }
        public void AtualizaCabecalhoDGCompra()
        {
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[1].HeaderText = "Data da compra";
            dgvDados.Columns[2].HeaderText = "Nota fiscal";
            dgvDados.Columns[3].HeaderText = "Fornecedor";
            dgvDados.Columns[4].HeaderText = "Numero de parcelas";
            dgvDados.Columns[5].HeaderText = "Status";
            dgvDados.Columns[6].HeaderText = "Código do Fornecedor";
            dgvDados.Columns[7].HeaderText = "Código do Tipo de pagamento";
            dgvDados.Columns[8].HeaderText = "Total";
            dgvDados.Columns[7].Visible = false;
            dgvDados.Columns[6].Visible = false;
            dgvDados.Columns[3].Width = 200;
        }
        private void btLocalizaFornecedor_Click(object sender, EventArgs e)
        {
            FrmConsultaFornecedor f = new FrmConsultaFornecedor();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtForCod.Text = f.codigo.ToString();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(f.codigo);
                lbForNome.Text = "Nome do fornecedor: " + modelo.ForNome;
                BLLCompra bllcompra = new BLLCompra(cx);
                dgvDados.DataSource = bllcompra.Localizar(f.codigo);
                f.Dispose();
                this.AtualizaCabecalhoDGCompra();
            }
            else
            {
                txtForCod.Text = ""; lbForNome.Text = "Nome do fornecedor: ";
            }
        }

        private void rbGeral_CheckedChanged(object sender, EventArgs e)
        {
            panelFornecedor.Visible = false;
            pData.Visible = false;
            //limpar os grids
            dgvDados.DataSource = null;
            dgvItens.DataSource = null;
            dgvParcelas.DataSource = null;

            if (rbGeral.Checked == true)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra bllcompra = new BLLCompra(cx);
                dgvDados.DataSource = bllcompra.Localizar();
                this.AtualizaCabecalhoDGCompra();
            }

            if (rbData.Checked == true)
            {
                pData.Visible = true;
            }
            if (rbFornecedor.Checked == true)
            {
                panelFornecedor.Visible = true;
            }
            if (rbParcelas.Checked == true)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra bllcompra = new BLLCompra(cx);
                dgvDados.DataSource = bllcompra.LocalizarPorParcelasEmAberto();
                this.AtualizaCabecalhoDGCompra();
            }
        }
        //103
        private void btLocData_Click(object sender, EventArgs e)
        {
            DateTime dtini = dateTimePicker1.Value;
            DateTime dtfin = dateTimePicker2.Value;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCompra bllcompra = new BLLCompra(cx);
            dgvDados.DataSource = bllcompra.Localizar(dtini, dtfin);
            this.AtualizaCabecalhoDGCompra();
        }

        public void alteraCabecalhoItensParcelas()
        {
            try
            {
                dgvItens.Columns[0].Visible = false;
                dgvItens.Columns[1].HeaderText = "Código do item";
                dgvItens.Columns[2].HeaderText = "Código do Produto";
                dgvItens.Columns[3].HeaderText = "Nome do Produto";
                dgvItens.Columns[4].HeaderText = "Quantidade";
                dgvItens.Columns[5].HeaderText = "Valor";
                dgvItens.Columns[3].Width = 200;

                dgvParcelas.Columns[0].HeaderText = "Parcela";
                dgvParcelas.Columns[1].HeaderText = "Valor";
                dgvParcelas.Columns[2].HeaderText = "Data de Pagamento";
                dgvParcelas.Columns[3].HeaderText = "Data de Vencimento";
                dgvParcelas.Columns[4].Visible = false;

            }
            catch
            {

            }


        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                // Itens da Compra
                BLLItensCompra bllItens = new BLLItensCompra(cx);
                dgvItens.DataSource = bllItens.Localizar(Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value));

                // Parcelas da Compra
                BLLParcelasCompra bllParcelas = new BLLParcelasCompra(cx);
                dgvParcelas.DataSource = bllParcelas.Localizar(Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value));
                alteraCabecalhoItensParcelas();
            }
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
