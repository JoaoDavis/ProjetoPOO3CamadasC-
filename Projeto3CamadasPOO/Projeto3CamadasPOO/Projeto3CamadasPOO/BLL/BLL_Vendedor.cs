using DTO;
using DAL;
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BLL
{
    internal class BLL_Vendedor
    {
        Conexao conexao = new Conexao();
        public void InserirVendedor(DTO_Vendedor Vendedor)
        {
            try
            {
                string comando = "INSERT INTO Vendedor VALUES(NULL, '" + Vendedor.NomeVendedor + "','"
                                                                    + Vendedor.Cpf + "','"
                                                                    + Vendedor.Telefone + "','"
                                                                     + Vendedor.Endereco + "');";
                conexao.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarVendedor(DTO_Vendedor Vendedor)
        {
            try
            {
                string comando = "UPDATE Vendedor SET nomeVendedor = '" + Vendedor.NomeVendedor +
                                                    "', CPF = '" + Vendedor.Cpf +
                                                    "', Telefone = '" + Vendedor.Telefone +
                                                    "', Endereco = '" + Vendedor.Endereco +
                                                    "' WHERE idVendedor = " + Vendedor.IdVendedor + ";";
                conexao.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable PesquisarVendedorID(DTO_Vendedor Vendedor)
        {
            string mostrar = "SELECT * FROM Vendedor WHERE idVendedor = " + Vendedor.IdVendedor + ";";

            return conexao.ExecutarConsulta(mostrar);
        }

        public DataTable PesquisarVendedorNome(DTO_Vendedor Vendedor)
        {
            string mostrar = "SELECT * FROM Vendedor WHERE nomeVendedor like  '%" + Vendedor.NomeVendedor + "%';";

            return conexao.ExecutarConsulta(mostrar);
        }

        public DataTable PesquisarVendedorCpf(DTO_Vendedor Vendedor)
        {
            string mostrar = "SELECT * FROM Vendedor WHERE CPF like  '%" + Vendedor.Cpf + "%';";

            return conexao.ExecutarConsulta(mostrar);
        }

        public DataTable PesquisaTodos(DTO_Vendedor Vendedor)
        {
            string mostrar = "SELECT * FROM Vendedor ;";

            return conexao.ExecutarConsulta(mostrar);
        }

        public DataTable ExcluiVendedor(DTO_Vendedor Vendedor)
        {
            string mostrar = "DELETE * FROM Vendedor WHERE idVendedor = " + Vendedor.IdVendedor + ";";

            return conexao.ExecutarConsulta(mostrar);
        }

        public String RetornaNome(DTO_Vendedor Vendedor)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection();
                conexao.ConnectionString = "persist security info=false; server=localHost; database=Projeto3CamadasPOO; uid=root; pwd=;";
                conexao.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexao;
                command.CommandText = "SELECT nomeVendedor FROM Vendedor WHERE idVendedor = " + Vendedor.IdVendedor;

                return command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public String RetornaCpf(DTO_Vendedor Vendedor)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection();
                conexao.ConnectionString = "persist security info=false; server=localHost; database=Projeto3CamadasPOO; uid=root; pwd=;";
                conexao.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexao;
                command.CommandText = "SELECT CPF FROM Vendedor WHERE idVendedor = " + Vendedor.IdVendedor;

                return command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public String RetornaTelefone(DTO_Vendedor Vendedor)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection();
                conexao.ConnectionString = "persist security info=false; server=localHost; database=Projeto3CamadasPOO; uid=root; pwd=;";
                conexao.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexao;
                command.CommandText = "SELECT Telefone FROM Vendedor WHERE idVendedor = " + Vendedor.IdVendedor;

                return command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public String RetornaEndereco(DTO_Vendedor Vendedor)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection();
                conexao.ConnectionString = "persist security info=false; server=localHost; database=Projeto3CamadasPOO; uid=root; pwd=;";
                conexao.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexao;
                command.CommandText = "SELECT Endereco FROM Vendedor WHERE idVendedor = " + Vendedor.IdVendedor;

                return command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
