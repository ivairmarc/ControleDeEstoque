using BLL;
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

namespace GUI
{
    public partial class FrmRecoverPasswd : Form
    {
        public FrmRecoverPasswd()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            
            //var user = new BLLUsuarios(cx);
            
            //var result = user.recoverPass(txtUserRequest.Text);
            //lblResult.Text = result;
        }
    }
}
