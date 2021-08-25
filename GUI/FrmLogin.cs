using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Modelo;
using BLL;
using DAL;
using Ferramenta;
using System.Data.SqlClient;
using System.IO;

namespace GUI
{
    public partial class FrmLogin : Form
    {
        
        public FrmLogin()
        {
            InitializeComponent();
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void lblName_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        private void lblSenha_Enter(object sender, EventArgs e)
        {
            if (txtsenha.Text == "SENHA")
            {
                txtsenha.Text = "";
                txtsenha.ForeColor = Color.LightGray;
                txtsenha.UseSystemPasswordChar = true;
            }
        }

        private void lblSenha_Leave(object sender, EventArgs e)
        {
            if (txtsenha.Text == "")
            {
                txtsenha.Text = "SENHA";
                txtsenha.ForeColor = Color.LightGray;
                txtsenha.UseSystemPasswordChar = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
                        
            if (txtuser.Text != "USUARIO")
            {
                if (txtsenha.Text != "SENHA")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLUsuarios bll = new BLLUsuarios(cx);

                    //BLLUsuarios DALobj = new BLLUsuarios(conexao);
                    var validalogin = bll.LoginUser(txtuser.Text, txtsenha.Text);

                    if (validalogin == true)
                    {

                        frmPrincipal f = new frmPrincipal();
                        //MessageBox.Show("Bem Vindo" + ModeloUsuarios.Usr_FirstName + "," + ModeloUsuarios.Usr_LastName);
                        f.Show();
                        f.FormClosed += Logout;
                        this.Hide();
                        //if (ModeloUsuarios.Usr_Position == CargosUsers.Administrador)
                        //{
                        //    frmPrincipal f = new frmPrincipal();
                        //    //MessageBox.Show("Bem Vindo" + ModeloUsuarios.Usr_FirstName + "," + ModeloUsuarios.Usr_LastName);
                        //    f.Show();
                        //    f.FormClosed += Logout;
                        //    this.Hide();
                        //}
                            

                    }
                    else msgError("Usuario ou senha incorreto. \n Tente Novamente.");
                    txtsenha.Text = "SENHA";
                    txtuser.Focus();
                }
                else msgError("Please enter password ");
            }
            else msgError("Please enter username");
        }
        private void msgError(string msg)
        {
            lblerrorpass.Text = "      " + msg;
            lblerrorpass.Visible = true;
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtsenha.Text = "SENHA";
            txtsenha.UseSystemPasswordChar = false;
            txtuser.Text = "USUARIO";
            lblerrorpass.Visible = false;
            this.Show();
            //txtuser.Focus();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
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

        private void linkRecover_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recoverPassword = new FrmRecoverPasswd();
            recoverPassword.ShowDialog();
        }

        

        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void txtsenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
