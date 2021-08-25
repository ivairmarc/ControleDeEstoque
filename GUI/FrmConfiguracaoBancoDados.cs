using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmConfiguracaoBancoDados : Form
    {
        public FrmConfiguracaoBancoDados()
        {
            InitializeComponent();
        }

        private void FrmConfiguracaoBancoDados_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader arquivo = new StreamReader("configuracaoBanco.txt");
                txtServidor.Text = arquivo.ReadLine();
                txtBancoDados.Text = arquivo.ReadLine();
                txtUsuario.Text = arquivo.ReadLine();
                txtSenha.Text = arquivo.ReadLine();
                arquivo.Close();
                //testar a conexao
                 
            }
            catch (Exception erros)
            {
                MessageBox.Show(erros.Message);
            }
        }
            private void btSalvar_Click(object sender, EventArgs e)
        {
            try
              {
                StreamWriter arquivo = new StreamWriter("configuracaoBanco.txt", false);
                arquivo.WriteLine(txtServidor.Text);
                arquivo.WriteLine(txtBancoDados.Text);
                arquivo.WriteLine(txtUsuario.Text);
                arquivo.WriteLine(txtSenha.Text);
                arquivo.Close();
                MessageBox.Show("Atualizado com Sucesso!!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
           
        }

        private void btTesteConexao_Click(object sender, EventArgs e)
        {
            try
            {
                
                DadosDaConexao.Servidor = txtServidor.Text;
                DadosDaConexao.BancoDados = txtBancoDados.Text;
                DadosDaConexao.Usuario = txtUsuario.Text;
                DadosDaConexao.Senha = txtSenha.Text;
                //testar a conexao
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = DadosDaConexao.StringDeConexao;
                conexao.Open();
                conexao.Close();
                MessageBox.Show("Conectado com sucesso");
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao Conectar ao Banco de Dados \n" +
                    "Verifique os dados informados");
            }
            catch (Exception erros)
            {
                MessageBox.Show(erros.Message);
            }
        }
    }
}
