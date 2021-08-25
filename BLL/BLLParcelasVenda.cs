using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelo;

namespace BLL
{
    public class BLLParcelasVenda
    {
        private DALConexao conexao;
        public BLLParcelasVenda(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloParcelasVenda modelo)
        {
            if (modelo.PveCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }

            if (modelo.PveValor <= 0)
            {
                throw new Exception("O valor da parcela é obrigatório");
            }
            DateTime data = DateTime.Now;
            if (modelo.PveDataVencito.Year < data.Year)
            {
                throw new Exception("Ano de vencimento inferior ao ano atual");
            }
            DALParcelasVenda DALobj = new DALParcelasVenda(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloParcelasVenda modelo)
        {
            if (modelo.PveCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }

            if (modelo.PveValor <= 0)
            {
                throw new Exception("O valor da parcela é obrigatório");
            }
            DateTime data = DateTime.Now;
            if (modelo.PveDataVencito.Year < data.Year)
            {
                throw new Exception("Ano de vencimento inferior ao ano atual");
            }
            DALParcelasVenda DALobj = new DALParcelasVenda(conexao);
            DALobj.Incluir(modelo);

        }
        public void Excluir(ModeloParcelasVenda modelo)
        {
            if (modelo.PveCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }
            DALParcelasVenda DALobj = new DALParcelasVenda(conexao);
            DALobj.Excluir(modelo);

        }
        public void ExcluirTodasAsParcelas(int comcod)
        {

            if (comcod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }
            DALParcelasVenda DALobj = new DALParcelasVenda(conexao);
            DALobj.ExcluirTodasAsparcelas(comcod);

        }
        public DataTable Localizar(int comcod)
        {
            if (comcod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }
            DALParcelasVenda DALobj = new DALParcelasVenda(conexao);
            return DALobj.Localizar(comcod);
        }

        public ModeloParcelasVenda CarregaModeloParcelasVenda(int PveCod, int VenCod)
        {
            if (PveCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }
            if (VenCod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }

            DALParcelasVenda DALobj = new DALParcelasVenda(conexao);
            return DALobj.CarregaModeloParcelasVenda(PveCod, VenCod);
           
        }
    }
}
