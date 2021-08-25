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
    public partial class FrmMovimentCompra : Form
    {
        public double totalCompra = 0;
        public string operacao;
        public FrmMovimentCompra()
        {
            InitializeComponent();
        }

        public void alteraBotoes(int op)
        {
            // op = operaçoes que serao feitas com os botoes
            // 1  = Preparar os botoes para inserir e localizar
            // 2  = preparar os para inserir/alterar um registro
            // 3  = preparar a tela para excluir ou alterar

            pnDados.Enabled = false;
            btInserir.Enabled = false;
            btAlterar.Enabled = false;
            btLocalizar.Enabled = false;
            btExcluir.Enabled = false;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;

            if (op == 1)
            {
                btInserir.Enabled = true;
                btLocalizar.Enabled = true;
            }
            if (op == 2)
            {
                pnDados.Enabled = true;
                btSalvar.Enabled = true;
                btCancelar.Enabled = true;
            }
            if (op == 3)
            {
                btAlterar.Enabled = true;
                btExcluir.Enabled = true;
                btCancelar.Enabled = true;
            }
            if (op == 4)
            {
                btInserir.Enabled = false;
                btAlterar.Enabled = false;
                btLocalizar.Enabled = false;
                btExcluir.Enabled = false;
                btCancelar.Enabled = false;
                btSalvar.Enabled = false;
            }
        }
        public void LimpaTela()
        {
            txtComCod.Clear();
            txtNFiscal.Clear();
            txtForCod.Clear();
            txtProCod.Clear();
            lProduto.Text = "Informe o código do produto ou click em localizar";
            txtQtd.Clear();
            txtValor.Clear();
            txtTotalCompra.Clear();
            dgvItens.Rows.Clear();
        }
        

        private void btnLocFor_Click(object sender, EventArgs e)
        {
            FrmConsultaFornecedor f = new FrmConsultaFornecedor();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                string d = Convert.ToString(f.codigo);
                txtForCod.Text = d;
                txtForCod_Leave(sender, e);
            }
        }

        private void txtForCod_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(Convert.ToInt32(txtForCod.Text));
                lFornecedor.Text = modelo.ForNome;
            }
            catch
            {
                txtForCod.Clear();
                lFornecedor.Text = "Informe o código do fornecedor ou click em localizar";
            }
        }

        private void btnLocProd_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                string d = Convert.ToString(f.codigo);
                txtProCod.Text = d;
                txtProCod_Leave(sender, e);
            }
        }

        private void txtProCod_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(Convert.ToInt32(txtProCod.Text));
                lProduto.Text = modelo.ProNome;
                txtQtd.Text = "1";
                txtValor.Text = modelo.ProValorPago.ToString();
            }
            catch
            {
                txtProCod.Clear();
                lProduto.Text = "Informe o código do Produto ou click em localizar";
            }
        }

        private void btAddProd_Click(object sender, EventArgs e)
        {
            if ((txtProCod.Text != "") && (txtQtd.Text != "") && (txtValor.Text != ""))
            {
                Double TotalLocal = Convert.ToDouble(txtQtd.Text) * Convert.ToDouble(txtValor.Text);
                this.totalCompra = this.totalCompra + TotalLocal; // soma o total da compra
                String[] i = new string[] { txtProCod.Text, lProduto.Text, txtQtd.Text, txtValor.Text, TotalLocal.ToString() };
                this.dgvItens.Rows.Add(i); // adcionando o string dentro da datagrid

                txtProCod.Clear();
                lProduto.Text = "Informe o código do Produto ou click em localizar";
                txtQtd.Clear();
                txtValor.Clear();
                txtTotalCompra.Text = this.totalCompra.ToString();
            }
        }

        private void FrmMovimentCompra_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTipoPagamento bll = new BLLTipoPagamento(cx);
            cbTPagto.DataSource = bll.Localizar("");
            cbTPagto.DisplayMember = "tpa_nome";
            cbTPagto.ValueMember = "tpa_cod";
            cbTPagto.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbTPagto.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void dgvItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtProCod.Text = dgvItens.Rows[e.RowIndex].Cells[0].Value.ToString();
                lProduto.Text = dgvItens.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQtd.Text = dgvItens.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtValor.Text = dgvItens.Rows[e.RowIndex].Cells[3].Value.ToString();
                Double valor = Convert.ToDouble(dgvItens.Rows[e.RowIndex].Cells[4].Value);
                this.totalCompra = this.totalCompra - valor;
                dgvItens.Rows.RemoveAt(e.RowIndex);
                txtTotalCompra.Text = this.totalCompra.ToString();
            }
        }

        private void btnSalvarFinal_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            cx.Conectar();
            cx.IniciarTransacao();
            try
            {
                //leitura dos dados
                ModeloCompra modeloCompra = new ModeloCompra();
                modeloCompra.ComData = dtTimerCompra.Value;
                modeloCompra.ComNFiscal = Convert.ToInt32(txtNFiscal.Text);
                modeloCompra.ComNParcelas = Convert.ToInt32(cbNParcelas.Text);
                modeloCompra.ComStatus = "ativa";
                modeloCompra.ComTotal = this.totalCompra;
                modeloCompra.ForCod = Convert.ToInt32(txtForCod.Text);
                modeloCompra.TpaCod = Convert.ToInt32(cbTPagto.SelectedValue);
                //obj para gravar os dados no banco
                
                BLLCompra bll = new BLLCompra(cx);

                ModeloItensCompra mitens = new ModeloItensCompra();
                BLLItensCompra bitens = new BLLItensCompra(cx);

                ModeloParcelasCompra mparcelas = new ModeloParcelasCompra();
                BLLParcelasCompra bparcelas = new BLLParcelasCompra(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar uma compra
                    bll.Incluir(modeloCompra);
                    //cadastrar itens da compra
                    for (int i = 0; i < dgvItens.RowCount; i++)
                    {
                        mitens.ItcCod = i + 1;
                        mitens.ComCod = modeloCompra.ComCod;
                        mitens.ProCod = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                        mitens.ItcQtde = Convert.ToDouble(dgvItens.Rows[i].Cells[2].Value);
                        mitens.ItcValor = Convert.ToDouble(dgvItens.Rows[i].Cells[3].Value);
                        bitens.Incluir(mitens);
                        //triger para alterar a qtde de produtos na tb produtos
                    }
                    // inserir os itens na tabela de produtos
                    for (int i = 0; i < dgvParcelas.RowCount; i++)
                    {
                        mparcelas.ComCod = modeloCompra.ComCod;
                        mparcelas.PcoCod = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                        mparcelas.PcoValor = Convert.ToDouble(dgvParcelas.Rows[i].Cells[1].Value);
                        mparcelas.PcoDataVencito = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);
                        bparcelas.Incluir(mparcelas);
                    }
                    //cadastrar parcelas da compra
                    MessageBox.Show("Compra efetuada: Código " + modeloCompra.ComCod.ToString());

                }
                else
                {
                    //alterar uma compra
                    modeloCompra.ComCod = Convert.ToInt32(txtComCod.Text);
                    bll.Alterar(modeloCompra);
                    bitens.ExcluirTodosOsItens(modeloCompra.ComCod);
                    for (int i = 0; i < dgvItens.RowCount; i++)
                    {
                        mitens.ItcCod = i + 1;
                        mitens.ComCod = modeloCompra.ComCod;
                        mitens.ProCod = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                        mitens.ItcQtde = Convert.ToDouble(dgvItens.Rows[i].Cells[2].Value);
                        mitens.ItcValor = Convert.ToDouble(dgvItens.Rows[i].Cells[3].Value);
                        bitens.Incluir(mitens);
                        //triger para alterar a qtde de produtos na tb produtos
                    }
                    bparcelas.ExcluirTodasAsParcelas(modeloCompra.ComCod);
                    // inserir os itens na tabela de produtos
                    for (int i = 0; i < dgvParcelas.RowCount; i++)
                    {
                        mparcelas.ComCod = modeloCompra.ComCod;
                        mparcelas.PcoCod = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                        mparcelas.PcoValor = Convert.ToDouble(dgvParcelas.Rows[i].Cells[1].Value);
                        mparcelas.PcoDataVencito = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);
                        bparcelas.Incluir(mparcelas);
                    }
                    MessageBox.Show("Cadastro alterado");
                }
                pnFinalizaCompra.Visible = false;
                this.LimpaTela();
                this.alteraBotoes(1);
                cx.TerminarTransacao();
                cx.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                cx.CancelarTransacao();
                cx.Desconectar();
            }
        }

        private void btnCancelarParcelas_Click(object sender, EventArgs e)
        {
            pnFinalizaCompra.Visible = false;
        }

        private void FrmMovimentCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void btSalvar_Click_1(object sender, EventArgs e)
        {
            dgvParcelas.Rows.Clear();
             int parcelas = Convert.ToInt32(cbNParcelas.Text);
            Double totallocal = this.totalCompra;
            double valor = totallocal / parcelas;
            DateTime dt = new DateTime();
            dt = dtDataIni.Value;
            lbtotal.Text = this.totalCompra.ToString();
            for (int i = 1; i <= parcelas; i++)
            {
                String[] k = new string[] { i.ToString(), valor.ToString(), dt.Date.ToString() };
                this.dgvParcelas.Rows.Add(k);
                if (dt.Month != 12)
                {
                    dt = new DateTime(dt.Year, dt.Month + 1, dt.Day);
                }
                else
                {
                    dt = new DateTime(dt.Year + 1, 1, dt.Day);
                }
            }
            
            pnFinalizaCompra.Visible = true;
        }

        private void btCancelar_Click_1(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
            this.totalCompra = 0;
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            FrmConsultaCompra f = new FrmConsultaCompra();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra bll = new BLLCompra(cx);
                ModeloCompra modelo = bll.CarregaModeloCompra(f.codigo);
                txtComCod.Text = modelo.ComCod.ToString();
                txtNFiscal.Text = modelo.ComNFiscal.ToString();
                dtTimerCompra.Value = modelo.ComData;
                txtForCod.Text = modelo.ForCod.ToString();
                txtForCod_Leave(sender, e); // escreve o nome do fornecedor na tela
                cbTPagto.SelectedValue = modelo.TpaCod;
                cbNParcelas.Text = modelo.ComNParcelas.ToString();
                txtTotalCompra.Text = modelo.ComTotal.ToString();
                this.totalCompra = modelo.ComTotal; // armazena o valor total da compra
                // itens da compra
                BLLItensCompra bllItens = new BLLItensCompra(cx);
                DataTable tabela = bllItens.Localizar(modelo.ComCod);
                for(int i = 0; i < tabela.Rows.Count; i++)
                {
                    Double vl = Convert.ToDouble(tabela.Rows[i]["itc_qtde"]);
                    Double TotalLocal = vl * vl;
                    string icod = tabela.Rows[i]["pro_cod"].ToString();
                    string inome = tabela.Rows[i]["pro_nome"].ToString();
                    string iqtd = tabela.Rows[i]["itc_qtde"].ToString();
                    string ivunit = tabela.Rows[i]["itc_valor"].ToString();
                   
                    String[] it = new string[] { icod, inome, iqtd, ivunit, TotalLocal.ToString() };
                    this.dgvItens.Rows.Add(it);
                }


                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
             
        }

        private void btExcluir_Click_1(object sender, EventArgs e)
        {
           
           try
           {
               DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
               if (d.ToString() == "Yes")
               {
                    int qtde = Convert.ToInt32(cbNParcelas.Text);
                    int codigo = Convert.ToInt32(txtComCod.Text);

                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCompra bllc = new BLLCompra(cx);

                    qtde -= bllc.QtdParcelasNaoPagas(codigo);
                    if (qtde == 0)
                    {
                        // excluir as parcelas da compra
                        BLLParcelasCompra bllp = new BLLParcelasCompra(cx);
                        bllp.ExcluirTodasAsParcelas(codigo);

                        // excluir os itens
                        BLLItensCompra blli = new BLLItensCompra(cx);
                        blli.ExcluirTodosOsItens(codigo);

                        // Compra

                        bllc.Excluir(codigo);
                        MessageBox.Show("Registro excluido!");
                        this.LimpaTela();
                        this.alteraBotoes(1);
                    }
                    else
                    {
                        MessageBox.Show("Impossível excluir o registro. \n O registro possui parcelas pagas");
                    }
                    
                    
               }
           }
           catch
           {
               MessageBox.Show("Impossível excluir o registro.");
               this.alteraBotoes(3);
           }
            
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.totalCompra = 0;
            this.alteraBotoes(2);
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            int qtde = Convert.ToInt32(cbNParcelas.Text);
            int codigo = Convert.ToInt32(txtComCod.Text);

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCompra bllc = new BLLCompra(cx);

            qtde -= bllc.QtdParcelasNaoPagas(codigo);
            if (qtde == 0)
            {
                this.operacao = "alterar";
                this.alteraBotoes(2);
            }
            else
            {
                MessageBox.Show("Impossível Alterar o registro. \n O registro possui parcelas pagas");
            }
         // 116 video  
        }
    }
}
