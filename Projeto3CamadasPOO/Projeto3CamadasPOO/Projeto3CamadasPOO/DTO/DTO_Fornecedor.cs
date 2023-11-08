using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_Fornecedor
    {
        private string nomeFornecedor, cnpj, telefone, endereco;
        private int idFornecedor;

        public int IdFornecedor
        {
            get
            {
                return idFornecedor;
            }
            set
            {
                idFornecedor = value;
            }
        }

        public string NomeFornecedor
        {
            get
            {
                return nomeFornecedor;
            }

            set
            {
                nomeFornecedor = value;
            }
        }

        public string Cnpj
        {
            get
            {
                return cnpj;
            }

            set
            {
                cnpj = value;
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

