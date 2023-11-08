using DTO;
using DAL;
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BLL
{
    internal class BLL_Venda
    {
        Conexao conexao = new Conexao();
        public void InserirVenda(DTO_Venda Venda)
        {
            try
            {
                string comando = "INSERT INTO Venda VALUES(NULL, '" + Venda.DataVenda + "','"
                                                                    + Venda.NomeVendedor + "','"
                                                                     + Venda.PrecoVenda + "');";
                conexao.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarVenda(DTO_Venda Venda)
        {
            try
            {
                string comando = "UPDATE Venda SET dataVenda = '" + Venda.DataVenda +
                                                    "', precoVenda = '" + Venda.PrecoVenda +
                                                    "' WHERE idVenda = " + Venda.IdVenda + ";";
                conexao.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable PesquisarVendaID(DTO_Venda Venda)
        {
            string mostrar = "SELECT * FROM Venda WHERE idVenda = " + Venda.IdVenda + ";";

            return conexao.ExecutarConsulta(mostrar);
        }

        public DataTable PesquisarVendaData(DTO_Venda Venda)
        {
            string mostrar = "SELECT * FROM Venda WHERE dataVenda like  '%" + Venda.DataVenda + "%';";

            return conexao.ExecutarConsulta(mostrar);
        }

        public DataTable PesquisarTodos(DTO_Venda venda)
        {
            string mostrar = "SELECT * FROM Venda ;";

            return conexao.ExecutarConsulta(mostrar);
        }

        public DataTable ExcluiVenda(DTO_Venda Venda)
        {
            string mostrar = "DELETE FROM Venda WHERE idVenda = " + Venda.IdVenda + ";";

            return conexao.ExecutarConsulta(mostrar);
        }

        public String RetornaPreco(DTO_Venda Venda)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection();
                conexao.ConnectionString = "persist security info=false; server=localHost; database=Projeto3CamadasPOO; uid=root; pwd=;";
                conexao.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexao;
                command.CommandText = "SELECT precoVenda FROM Venda WHERE idVenda = " + Venda.IdVenda;

                return command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
