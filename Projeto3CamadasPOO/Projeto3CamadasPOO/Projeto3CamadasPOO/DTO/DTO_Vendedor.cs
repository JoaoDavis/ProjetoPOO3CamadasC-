using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class DTO_Vendedor
    {
        private string nomeVendedor, cpf, telefone, endereco;
        private int idVendedor;

        public int IdVendedor
        {
            get
            {
                return idVendedor;
            }

            set
            {
                idVendedor = value;
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

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public string Endereco
        {
            get
            {
                return endereco;
            }

            set
            {
                endereco = value;
            }
        }
    }
}
