using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BLL
{
    internal class BLL_Usuario
    {
        Conexao conexao = new Conexao();    

        public void InserirUsuario(DTO_Usuario Usuario)
        {
            try
            {
                string comando = "INSERT INTO Usuario VALUES(NULL, '" + Usuario.Usuario + "','"
                                                                     + Usuario.Pass + "');";
                conexao.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public String UltimoID(DTO_Usuario Usuario)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection();
                conexao.ConnectionString = "persist security info=false; server=localHost; database=Projeto3CamadasPOO; uid=root; pwd=;";
                conexao.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexao;
                command.CommandText = "SELECT MAX(idUsuario) FROM Usuario ;";

                return command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public String VerificaUsuario(DTO_Usuario Usuario)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection();
                conexao.ConnectionString = "persist security info=false; server=localHost; database=Projeto3CamadasPOO; uid=root; pwd=;";
                conexao.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexao;
                command.CommandText = "SELECT usuario FROM Usuario WHERE idUsuario = " + Usuario.IdUsuario;

                return command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string VerificaSenha(DTO_Usuario Usuario)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection();
                conexao.ConnectionString = "persist security info=false; server=localHost; database=Projeto3CamadasPOO; uid=root; pwd=;";
                conexao.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexao;
                command.CommandText = "SELECT pass FROM usuario WHERE idUsuario = " + Usuario.IdUsuario;

                return command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }
}
