using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace DAL
{
    public class DALParcelasVenda
    {
        private DALConexao conexao;
        public DALParcelasVenda(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloParcelasVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into parcelasvenda (pve_cod, ven_cod, pve_datavecto, pve_valor) values " +
                "(@pve_cod, @ven_cod, @pve_datavecto, @pve_valor);";
            cmd.Parameters.AddWithValue("@pve_cod", modelo.PveCod);
            cmd.Parameters.AddWithValue("@ven_cod", modelo.VenCod);
            cmd.Parameters.AddWithValue("@pve_valor", modelo.PveValor);
            cmd.Parameters.Add("@pve_datavecto", System.Data.SqlDbType.Date);
            if (modelo.PveDataVencito == null)
            {
                cmd.Parameters["@pve_datavecto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@pve_datavecto"].Value = modelo.PveDataVencito;
            }


            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Alterar(ModeloParcelasVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update parcelasvenda set pve_valor = @pve_valor," +
                "pve_datapagto = @pve_datapagto, pve_datavecto = @Pvedatavecto where pve_cod = @pve_cod and ven_cod = @ven_cod;";
            cmd.Parameters.AddWithValue("@ven_cod", modelo.VenCod);
            cmd.Parameters.AddWithValue("@pve_cod", modelo.PveCod);
            cmd.Parameters.AddWithValue("@pve_valor", modelo.PveValor);
            cmd.Parameters.Add("@pve_datapagto", System.Data.SqlDbType.Date);
            cmd.Parameters.Add("@pve_datavecto", System.Data.SqlDbType.Date);
            if (modelo.PveDataPagto == null)
            {
                cmd.Parameters["@pve_datapagto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@pve_datapagto"].Value = modelo.PveDataPagto;
            }
            cmd.Parameters["@pve_datavecto"].Value = modelo.PveDataVencito;


            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(ModeloParcelasVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from parcelasvenda where pve_cod = @pve_cod and ven_cod = @ven_cod;";
            cmd.Parameters.AddWithValue("@pve_cod", modelo.PveCod);
            cmd.Parameters.AddWithValue("@ven_cod", modelo.VenCod);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void ExcluirTodasAsparcelas(int Vencod)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from parcelasvenda where ven_cod = @ven_cod;";
            cmd.Parameters.AddWithValue("@ven_cod", Vencod);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public DataTable Localizar(int Vencod)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from parcelasvenda where ven_cod =" +
                Vencod.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloParcelasVenda CarregaModeloParcelasVenda(int PveCod, int VenCod)
        {
            ModeloParcelasVenda modelo = new ModeloParcelasVenda();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from parcelasvenda where pve_cod = @pve_cod and ven_cod = @ven_cod;";
            cmd.Parameters.AddWithValue("@pve_cod", PveCod);
            cmd.Parameters.AddWithValue("@ven_cod", VenCod);

            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.PveCod = PveCod;
                modelo.VenCod = VenCod;

                modelo.PveDataPagto = Convert.ToDateTime(registro["pve_datapagto"]);
                modelo.PveDataVencito = Convert.ToDateTime(registro["pve_datavecto"]);
                modelo.PveValor = Convert.ToDouble(registro["pve_valor"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
