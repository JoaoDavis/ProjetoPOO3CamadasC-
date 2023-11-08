using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Projeto3CamadasPOO
{
    public class Conexao
    {
        MySqlConnection conecta;

        public string Conectar()
        {
            string sql = "server=localhost; uid=root;database=Projeto3CamadasPOO;pwd=";

            try
            {
                conecta = new MySqlConnection(sql);
                conecta.Open();
                return "Conexão aberta com sucesso";
            }
            catch (MySqlException)
            {
                throw new Exception("Problemas");
            }
        }

        public string ExecutarInsere(string sql1)
        {
            Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql1, conecta);
                cmd.ExecuteNonQuery();
                return "Dados inseridos com sucesso";
            }
            catch (MySqlException ex)
            {
                throw new Exception("Não foi possivel executar a instrução \n" + ex.Message);
            }
            finally
            {
                conecta.Close();
            }
        }

        public DataTable ExeutaConsulta(string sql2)
        {
            Conectar();
            try
            {
                DataTable dt = new DataTable();
                MySqlDataAdapter dados = new MySqlDataAdapter(sql2, conecta);
                dados.Fill(dt);
                return dt;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Não foi possivel retornar os dados \n" + ex.Message);
            }
            finally
            {
                conecta.Close();
            }
        }
    }
}
