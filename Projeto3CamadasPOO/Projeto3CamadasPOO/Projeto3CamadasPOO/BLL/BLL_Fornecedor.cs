using DTO;
using DAL;
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace BLL
{
    internal class BLL_Fornecedor
    {
        Conexao conexao = new Conexao();

        public void InserirFornecedor(DTO_Fornecedor Fornecedor)
        {
            try
            {
                string comando = "INSERT INTO Fornecedor VALUES(NULL, '" + Fornecedor.NomeFornecedor + "','"
                                                                     + Fornecedor.Cnpj + "','"
                                                                     + Fornecedor.Telefone + "','"
                                                                     + Fornecedor.Endereco + "');";
                conexao.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable PesquisarFornecedorID(DTO_Fornecedor Fornecedor)
        {
            string mostrar = "SELECT * FROM Fornecedor WHERE idFornecedor = " + Fornecedor.IdFornecedor + ";";

            return conexao.ExecutarConsulta(mostrar);
        }

        public DataTable PesquisarFornecedorNome(DTO_Fornecedor Fornecedor)
        {
            string mostrar = "SELECT * FROM Fornecedor WHERE nomeFornecedor like '%" + Fornecedor.NomeFornecedor + "%';";

            return conexao.ExecutarConsulta(mostrar);
        }

        public DataTable PesquisarFornecedorCnpj(DTO_Fornecedor Fornecedor)
        {
            string mostrar = "SELECT * FROM Fornecedor WHERE CNPJ like '%" + Fornecedor.Cnpj + "%';";

            return conexao.ExecutarConsulta(mostrar);
        }

        public DataTable PesquisaTodos(DTO_Fornecedor fornecedor)
        {
            string mostrar = "SELECT * FROM Fornecedor;";

            return conexao.ExecutarConsulta(mostrar);
        }

        public void AlterarFornecedor(DTO_Fornecedor Fornecedor)
        {
            try
            {
                string comando = "UPDATE Fornecedor SET nomeFornecedor = '" + Fornecedor.NomeFornecedor +
                                                    "', CNPJ = '" + Fornecedor.Cnpj +
                                                    "', Telefone = '" + Fornecedor.Telefone +
                                                    "', Endereco = '" + Fornecedor.Endereco +
                                                    "' WHERE idFornecedor = " + Fornecedor.IdFornecedor + ";";
                conexao.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ExcluiFornecedor(DTO_Fornecedor Fornecedor)
        {
            string mostrar = "DELETE FROM Fornecedor WHERE idFornecedor = " + Fornecedor.IdFornecedor + ";";

            return conexao.ExecutarConsulta(mostrar);
        }

        public String RetornaNome(DTO_Fornecedor Fornecedor)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection();
                conexao.ConnectionString = "persist security info=false; server=localHost; database=Projeto3CamadasPOO; uid=root; pwd=;";
                conexao.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexao;
                command.CommandText = "SELECT nomeFornecedor FROM Fornecedor WHERE idFornecedor = " + Fornecedor.IdFornecedor;

                return command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public String RetornaCnpj(DTO_Fornecedor Fornecedor)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection();
                conexao.ConnectionString = "persist security info=false; server=localHost; database=Projeto3CamadasPOO; uid=root; pwd=;";
                conexao.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexao;
                command.CommandText = "SELECT CNPJ FROM Fornecedor WHERE idFornecedor = " + Fornecedor.IdFornecedor;

                return command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public String RetornaTelefone(DTO_Fornecedor Fornecedor)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection();
                conexao.ConnectionString = "persist security info=false; server=localHost; database=Projeto3CamadasPOO; uid=root; pwd=;";
                conexao.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexao;
                command.CommandText = "SELECT Telefone FROM Fornecedor WHERE idFornecedor = " + Fornecedor.IdFornecedor;

                return command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public String RetornaEndereco(DTO_Fornecedor Fornecedor)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection();
                conexao.ConnectionString = "persist security info=false; server=localHost; database=Projeto3CamadasPOO; uid=root; pwd=;";
                conexao.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexao;
                command.CommandText = "SELECT Endereco FROM Fornecedor WHERE idFornecedor = " + Fornecedor.IdFornecedor;

                return command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
