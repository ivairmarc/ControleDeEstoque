using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DAL;
using System.Text.RegularExpressions;
using Ferramenta;
using System.Data;

namespace BLL
{
    public class BLLFornecedor
    {
        private DALConexao conexao;

        public BLLFornecedor(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFornecedor modelo)
        {
            if (modelo.ForNome.Trim().Length == 0)
            {
                throw new Exception("O nome do Fornecedor é obrigatório");
            }
            if (modelo.ForCnpj.Trim().Length == 0)
            {
                throw new Exception("O CNPJ do Fornecedor é obrigatório");
            }

            //verificar CPF/CNPJ
            if (Validacao.IsCnpj(modelo.ForCnpj) == false)
            {
                throw new Exception("CNPJ inválido");
            }

            if (modelo.ForIe.Trim().Length == 0)
            {
                throw new Exception("O IE do Fornecedor é obrigatório");
            }

            if (modelo.ForFone.Trim().Length == 0)
            {
                throw new Exception("O telefone do Fornecedor é obrigatório");
            }

            //validacao email
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\" +
                ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modelo.ForEmail))
            {
                throw new Exception("Digite um email válido");
            }

            if (Validacao.ValidaCep(modelo.ForCep) == false)
            {
                throw new Exception("O Cep é Invalido ");
            }

            DALFornecedor DALobj = new DALFornecedor(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloFornecedor modelo)
        {
            if (modelo.ForNome.Trim().Length == 0)
            {
                throw new Exception("O nome do Fornecedor é obrigatório");
            }
            if (modelo.ForCnpj.Trim().Length == 0)
            {
                throw new Exception("O CNPJ do Fornecedor é obrigatório");
            }

            //verificar CPF/CNPJ
            if (Validacao.IsCnpj(modelo.ForCnpj) == false)
            {
                throw new Exception("CNPJ inválido");
            }

            if (modelo.ForIe.Trim().Length == 0)
            {
                throw new Exception("O IE do Fornecedor é obrigatório");
            }

            if (modelo.ForFone.Trim().Length == 0)
            {
                throw new Exception("O telefone do Fornecedor é obrigatório");
            }

            //validacao email
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\" +
                ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modelo.ForEmail))
            {
                throw new Exception("Digite um email válido");
            }

            DALFornecedor DALobj = new DALFornecedor(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALFornecedor DAlobj = new DALFornecedor(conexao);
            DAlobj.Excluir(codigo);
        }

        public DataTable Localizar(string valor)
        {
            DALFornecedor DAlobj = new DALFornecedor(conexao);
            return DAlobj.Localizar(valor);
        }
        public DataTable LocalizarporNome(string valor)
        {
            DALFornecedor DAlobj = new DALFornecedor(conexao);
            return DAlobj.LocalizarporNome(valor);
        }
        public DataTable LocalizarporCNPJ(string valor)
        {
            DALFornecedor DAlobj = new DALFornecedor(conexao);
            return DAlobj.LocalizarporCNPJ(valor);
        }
        public DataTable LocalizarTodos()
        {
            DALFornecedor DAlobj = new DALFornecedor(conexao);
            return DAlobj.LocalizarTodos();
        }
        public ModeloFornecedor CarregaModeloFornecedor(int codigo)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.CarregaModeloFornecedor(codigo);
        }

        public ModeloFornecedor CarregaModeloFornecedor(string cnpj)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.CarregaModeloFornecedor(cnpj);
        }
    }
}

