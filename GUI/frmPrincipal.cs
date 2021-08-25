using DAL;
using Modelo;
using Ferramenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks; 
using System.Windows.Forms;


namespace GUI
{
    public partial class frmPrincipal : Form
    {

        
        public frmPrincipal()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria f = new frmCadastroCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCategoria f = new frmConsultaCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void subCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroSubCategoria f = new frmCadastroSubCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void subCategoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaSubCategoria f = new frmConsultaSubCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void unidadeDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrounidadeDeMedida f = new frmCadastrounidadeDeMedida();
            f.ShowDialog();
            f.Dispose();
        }

        private void unidadeDeMedidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaUnidadeDeMedida f = new frmConsultaUnidadeDeMedida();
            f.ShowDialog();
            f.Dispose();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroProduto f = new frmCadastroProduto();
            f.ShowDialog();
            f.Dispose();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
            f.Dispose();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            LoadUserData();
            //if (ModeloUsuarios.Usr_Position == CargosUsers.Administrador)
            //{
                
            //}
            //if (ModeloUsuarios.Usr_Position == CargosUsers.Caixa)
            //{
            //    categoriaToolStripMenuItem.Enabled = false;
            //    subCategoriaToolStripMenuItem.Enabled = false;
            //}
            try
            {
                
                StreamReader arquivo = new StreamReader("configuracaoBanco.txt");
                DadosDaConexao.Servidor = arquivo.ReadLine();
                DadosDaConexao.BancoDados = arquivo.ReadLine();
                DadosDaConexao.Usuario = arquivo.ReadLine();
                DadosDaConexao.Senha = arquivo.ReadLine();
                arquivo.Close();
                //testar a conexao
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = DadosDaConexao.StringDeConexao;
                conexao.Open();
                conexao.Close();

            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao Conectar ao Banco de Dados \n" +
                    "Acesse as configurações do banco de dados e informe os parâmetros de conexão");
            }
            catch (Exception erros)
            {
                MessageBox.Show(erros.Message);
            }

            
        }
        
        private void LoadUserData()
        {
            lblNome.Text = ModeloUsuarios.Usr_FirstName + ", " + ModeloUsuarios.Usr_LastName;
            lblCargo.Text = ModeloUsuarios.Usr_Position;
            lblEmail.Text = ModeloUsuarios.Usr_Email;
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void movimentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void configuraçãoDoBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConfiguracaoBancoDados f = new FrmConfiguracaoBancoDados();
            f.ShowDialog();
            f.Dispose();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void explorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer");
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void backupDoBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBackupBancodeDados f = new FrmBackupBancodeDados();
            f.ShowDialog();
            f.Dispose();
        }

        private void tipoDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroTipoPagamento f = new FrmCadastroTipoPagamento();
            f.ShowDialog();
            f.Dispose();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente f = new FrmCadastroCliente();
            f.ShowDialog();
            f.Dispose();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaCliente f = new FrmConsultaCliente();
            f.ShowDialog();
            f.Dispose();
        }

        private void tipoDePagamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaTipoPagamento f = new FrmConsultaTipoPagamento();
            f.ShowDialog();
            f.Dispose();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroFornecedor f = new FrmCadastroFornecedor();
            f.ShowDialog();
            f.Dispose();
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaFornecedor f = new FrmConsultaFornecedor();
            f.ShowDialog();
            f.Dispose();
        }

        
        private void ferramentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void iconClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconMaxi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconRest.Visible = true;
            iconMaxi.Visible = false;
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconRest_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconRest.Visible = false;
            iconMaxi.Visible = true;
        }

        private void iconHideMenu_Click(object sender, EventArgs e)
        {
            if (panelLateralLeft.Width == 168)
            {
                panelLateralLeft.Width = 0;
            }
            else
                panelLateralLeft.Width = 168;
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMovimentCompra f = new FrmMovimentCompra();
            f.ShowDialog();
            f.Dispose();
        }

        private void panelCentral_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("A sessão sera encerrada.", "Tem Certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void compraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaCompra f = new FrmConsultaCompra();
            f.ShowDialog();
            f.Dispose();
        }

        private void pagamentoDeParcelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPagamentoCompra f = new FormPagamentoCompra();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
