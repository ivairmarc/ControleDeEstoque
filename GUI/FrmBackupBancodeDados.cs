using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Ferramenta;

namespace GUI
{
    public partial class FrmBackupBancodeDados : Form
    {
        public FrmBackupBancodeDados()
        {
            InitializeComponent();
        }

        private void btBackupBd_Click(object sender, EventArgs e)
        {
            SaveFileDialog d = new SaveFileDialog();
            d.Filter = "Backup Files | *.back";
            d.ShowDialog();
            if (d.FileName != "")
            {
                try
                {
                    String nomeBanco = DadosDaConexao.BancoDados;
                    String localBackup = d.FileName;
                    String conexao = @"Data Source=" + DadosDaConexao.Servidor + ";Initial Catalog=master;User=" +
                         DadosDaConexao.Usuario + ";Password=" + DadosDaConexao.Senha;
                    SQLServerBackup.BackupDataBase(conexao, nomeBanco, d.FileName);
                    MessageBox.Show("Backup realizado com sucesso!!");
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }

        private void btRestaurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "Backup Files | *.back";
            d.ShowDialog();
            if (d.FileName != "")
            {
                try
                {
                    String nomeBanco = DadosDaConexao.BancoDados;
                    String localBackup = d.FileName;
                    String conexao = @"Data Source=" + DadosDaConexao.Servidor + ";Initial Catalog=master;User=" +
                         DadosDaConexao.Usuario + ";Password=" + DadosDaConexao.Senha;
                    SQLServerBackup.RestauraDatabase(conexao, nomeBanco, d.FileName);
                    MessageBox.Show("Backup restaurado com sucesso!!");
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }
    }
}
