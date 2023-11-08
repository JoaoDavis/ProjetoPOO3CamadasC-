using DTO;
using DAL;
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BLL
{
    internal class BLL_TenisBase
    {
        Conexao conexao = new Conexao();

        public DataTable PesquisarTenisID(DTO_Tenis Tenis)
        {
            string mostrar = "SELECT * FROM Tenis WHERE idTenis = " + Tenis.IdTenis + ";";

            return conexao.ExecutarConsulta(mostrar);
        }

        public DataTable PesquisarTenisMarca(DTO_Tenis Tenis)
        {
            string mostrar = "SELECT * FROM Tenis WHERE marca like  '%" + Tenis.Marca + "%';";

            return conexao.ExecutarConsulta(mostrar);
        }

        public DataTable PesquisarTenisModelo(DTO_Tenis Tenis)
        {
            string mostrar = "SELECT * FROM Tenis WHERE modelo = " + Tenis.Modelo + ";";

            return conexao.ExecutarConsulta(mostrar);
        }

        public DataTable PesquisaTodos(DTO_Tenis Tenis)
        {
            string mostrar = "SELECT * FROM Tenis ;";

            return conexao.ExecutarConsulta(mostrar);
        }

        public void AlterarTenis(DTO_Tenis Tenis)
        {
            try
            {
                string comando = "UPDATE Tenis SET tamanho = '" + Tenis.Tamanho +
                                                    "', marca = '" + Tenis.Marca +
                                                    "', cor = '" + Tenis.Cor +
                                                    "', modelo = '" + Tenis.Modelo +
                                                    "' WHERE idTenis = " + Tenis.IdTenis + ";";
                conexao.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ExcluiTenis(DTO_Tenis Tenis)
        {
            string mostrar = "DELETE FROM Tenis WHERE idTenis = " + Tenis.IdTenis + ";";

            return conexao.ExecutarConsulta(mostrar);
        }

        public String RetornaTamanho(DTO_Tenis Tenis)
        {
            try
            {
                string mostrar = "SELECT tamanho FROM Tenis WHERE idTenis = " + Tenis.IdTenis;

                return conexao.ExecutarComandosComFuncao(mostrar).ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public String RetornaMarca(DTO_Tenis Tenis)
        {
            try
            {
                string mostrar = "SELECT marca FROM Tenis WHERE idTenis = " + Tenis.IdTenis;

                return conexao.ExecutarComandosComFuncao(mostrar).ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public String RetornaCor(DTO_Tenis Tenis)
        {
            try
            {
                string mostrar = "SELECT cor FROM Tenis WHERE idTenis = " + Tenis.IdTenis;

                return conexao.ExecutarComandosComFuncao(mostrar).ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public String RetornaModelo(DTO_Tenis Tenis)
        {
            try
            {
                string mostrar = "SELECT modelo FROM Tenis WHERE idTenis = " + Tenis.IdTenis;

                return conexao.ExecutarComandosComFuncao(mostrar).ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public String QuantTenis(DTO_Tenis Tenis)
        {
            try
            {
                string mostrar  = "SELECT count(Tenis.idTenis) FROM Tenis;";
                return conexao.ExecutarComandosComFuncao(mostrar).ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}