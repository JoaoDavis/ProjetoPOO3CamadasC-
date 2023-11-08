using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_Venda
    {
        private string nomeVendedor;
        private string dataVenda;
        private int idVenda;
        private float precoVenda;

        public string DataVenda
        {
            get
            {
                return dataVenda;
            }

            set
            {
                dataVenda = value;
            }
        }

        public string NomeVendedor
        {
            get
            {
                return nomeVendedor;
            }

            set
            {
                nomeVendedor = value;
            }
        }

        public int IdVenda
        {
            get
            {
                return idVenda;
            }

            set
            {
                idVenda = value;
            }
        }

        public float PrecoVenda
        {
            get
            {
                return precoVenda;
            }

            set
            {
                precoVenda = value;
            }
        }
    }
}
