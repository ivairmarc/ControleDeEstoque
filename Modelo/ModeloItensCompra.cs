using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloItensCompra
    {

        private int itc_cod;
        public int ItcCod
        {
            get
            {
                return this.itc_cod;
            }
            set
            {
                this.itc_cod = value;
            }
        }
        private double itc_qtde;
        public double ItcQtde
        {
            get
            {
                return this.itc_qtde;
            }
            set
            {
                this.itc_qtde = value;
            }
        }
        private double itc_valor;
        public double ItcValor
        {
            get
            {
                return this.itc_valor;
            }
            set
            {
                this.itc_valor = value;
            }
        }
        private int com_cod;
        public int ComCod
        {
            get
            {
                return this.com_cod;
            }
            set
            {
                this.com_cod = value;
            }
        }
        private int pro_cod;
        public int ProCod
        {
            get
            {
                return this.pro_cod;
            }
            set
            {
                this.pro_cod = value;
            }
        }
    }
}
