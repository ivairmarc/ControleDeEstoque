using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ferramenta;
using Microsoft.Win32;
using Modelo;


namespace DAL
{
    public class DALUsuarios
    {
        private DALConexao conexao;
        public DALUsuarios(DALConexao cx)
        {
            this.conexao = cx;
        }
        public  bool Login(string user, string pass)
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from users where usr_loginname = @user and usr_passwd = @pass";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.CommandType = CommandType.Text;
            conexao.Conectar();
            SqlDataReader reader = cmd.ExecuteReader(); 

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    ModeloUsuarios.Usr_Iduser = Convert.ToInt32(reader["usr_id"]);
                    ModeloUsuarios.Usr_FirstName = Convert.ToString(reader["usr_firstname"]);
                    ModeloUsuarios.Usr_LastName = Convert.ToString(reader["usr_lastname"]);
                    ModeloUsuarios.Usr_Position = Convert.ToString(reader["usr_position"]);
                    ModeloUsuarios.Usr_Email = Convert.ToString(reader["usr_email"]);
                    //conexao.Desconectar();
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Incluir(ModeloCliente modelo)
        {

        }
        //public void Alterar(ModeloUsuarios modelo)
        //{
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = conexao.ObjetoConexao;
        //    cmd.CommandText = "update users set usr_loginname = @usr_loginname, usr_passwd = @usr_passwd, usr_firstname = @usr_firstname," +
        //        " usr_lastname = @usr_lastname, usr_position = @usr_position" +
        //        ", usr_email = @usr_email where usr_id = @codigo;";

        //    cmd.Parameters.AddWithValue("@usr_loginname", modelo.Usr_Iduser);
        //    cmd.Parameters.AddWithValue("@usr_passwd", modelo.CliCpfCnpj);
        //    cmd.Parameters.AddWithValue("@usr_firstname", modelo.CliRgIe);
        //    cmd.Parameters.AddWithValue("@usr_lastname", modelo.CliRSocial);
        //    cmd.Parameters.AddWithValue("@usr_position", modelo.CliTipo);
        //    cmd.Parameters.AddWithValue("@usr_email", modelo.CliCep);

        //    cmd.Parameters.AddWithValue("@codigo", modelo.usr_id);
        //    conexao.Conectar();
        //    cmd.ExecuteNonQuery();
        //    conexao.Desconectar();
        //}
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from users where usr_id = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from users where usr_firstname like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;

        }
        public DataTable LocalizarporNome(String valor)
        {
            return Localizar(valor);
        }
        public DataTable LocalizarporCargo(String valor) 
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from users where usr_position like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        //public string recoverPass(string userRequesting)
        //{
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = conexao.ObjetoConexao;
        //    cmd.CommandText = "select * from users where usr_loginname = @user and usr_email = @mail";
        //    cmd.Parameters.AddWithValue("@user", userRequesting);
        //    cmd.Parameters.AddWithValue("@mail", userRequesting);
        //    cmd.CommandType = CommandType.Text;
        //    conexao.Conectar();
        //    SqlDataReader reader = cmd.ExecuteReader();

        //    if (reader.Read() == true)
        //    {

        //        string Usr_FirstName = Convert.ToString(reader["usr_firstname"] + "," + reader["usr_lastname"]);
        //        string Usr_Email = Convert.ToString(reader["usr_email"]);
        //        string Usr_passwd = Convert.ToString(reader["usr_passwd"]);
        //        conexao.Desconectar();
        //        List<string> listMail = new List<string>();
        //        listMail.Add(Usr_Email);
                
        //        var mailService = new DALSuportMail();
        //        mailService.sendEmail(
        //            subject: "SYSTEM: Password recovery request",
        //            body: "Hi, " + Usr_FirstName + "\nYou Requested to Recover your password.\n" +
        //            "your current password is: " + Usr_passwd + "\nHowever, we ask that you change password inmediately once you enter the system.",
        //            recipientMail: new List<string> { Usr_Email });
        //        return "Hi, " + Usr_FirstName + "\nYou Requested to Recover your password.\n" +
        //            "Please check your email: " + Usr_Email + "\nHowever, we ask that you change password inmediately once you enter the system.";

        //    }
        //    else { return "Sorry, you do not have an account with that email or username"}
        //}
    }
}
