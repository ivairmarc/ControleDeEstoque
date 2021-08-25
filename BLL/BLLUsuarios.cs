using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelo;
using Ferramenta;

namespace BLL
{
    public class BLLUsuarios
    {
        private DALConexao conexao;

        public BLLUsuarios(DALConexao cx)
        {
            this.conexao = cx;
        }

        public bool LoginUser(string user, string pass)
        {
            DALUsuarios DALobj = new DALUsuarios(conexao);
            return DALobj.Login(user, pass);
            
        }
        //public string recoverPass(string userRequesting) {
        //    DALUsuarios DALobj = new DALUsuarios(conexao);
        //    return DALobj.recoverPass(userRequesting);
        //}

        //public void ValidaUser()
        //{
        //    //Security and permission
        //    if (ModeloUsuarios.Usr_Position == CargosUsers.Administrador)
        //    {
        //    }
        //    if (ModeloUsuarios.Usr_Position == CargosUsers.Caixa || ModeloUsuarios.Usr_Position == CargosUsers.Recepitionist)
        //    {

        //    }
        //}
    }
}
