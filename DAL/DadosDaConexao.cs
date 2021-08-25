using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDaConexao
    {
        public static string Servidor = "DESKTOP-Q07NF80";
        public static string BancoDados = "ROTS-CONTROLE-ESTOQUE";
        public static string Usuario = "rots";
        public static string Senha = "comspirace";

        public static String StringDeConexao
        {
            get 
            {
                return "Data Source="+ Servidor +";Initial Catalog="+ BancoDados +";User ID="+ Usuario +";Password="+ Senha;
            }
        }
    }
}
