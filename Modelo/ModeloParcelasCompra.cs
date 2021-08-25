using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloParcelasCompra
    {
        public ModeloParcelasCompra()
        {
            this.PcoCod = 0;
            this.PcoValor = 0;
            this.ComCod = 0;
            //this.PcoDataPagto = DateTime.Now;
            this.PcoDataVencito = DateTime.Now;
        }

        private int pco_cod;
        public int PcoCod
        {
            get { return this.pco_cod; }
            set { this.pco_cod = value; }
        }

        private int com_cod;
        public int ComCod
        {
            get { return this.com_cod; }
            set { this.com_cod = value; }
        }

        private Double pco_valor;
        public Double PcoValor
        {
            get { return this.pco_valor; }
            set { this.pco_valor = value; }
        }

        private DateTime pco_datapagto;
        public DateTime PcoDataPagto
        {
            get { return this.pco_datapagto; }
            set { this.pco_datapagto = value; }
        }

        private DateTime pco_datavencito;
        public DateTime PcoDataVencito
        {
            get { return this.pco_datavencito; }
            set { this.pco_datavencito = value; }
        }
    }
}
