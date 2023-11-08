using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     class DTO_Tenis
    {
        private string tamanho, marca, cor, modelo;
        private int idTenis;

        public int IdTenis
        {
            get
            {
                return idTenis;
            }

            set
            {
                idTenis = value;
            }
        }

        public string Tamanho
        {
            get
            {
                return tamanho;
            }

            set
            {
                tamanho = value;
            }
        }

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public string Cor
        {
            get
            {
                return cor;
            }

            set
            {
                cor = value;
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }
    }
}
