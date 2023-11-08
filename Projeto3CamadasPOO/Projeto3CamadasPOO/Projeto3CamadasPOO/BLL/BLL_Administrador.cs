using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    internal class BLL_Administrador
    {
        Conexao conexao = new Conexao();

        public void InserirAdmin(DTO_Administrador Administrador)
        {
            try
            {
                string comando = "INSERT INTO Administrador VALUES(NULL, '" + Administrador.userAdmin + "','"
                                                                     + Administrador.Pass + "');";
                conexao.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool VerificaAdmin(string usuer, string senha)
        {
            try
            {
                string comando = $"SELECT UserAdmin,pass FROM Administrador where UserAdmin='{usuer}' && pass='{senha}' ";
                conexao.ExecutarComandos(comando);

                return true;
                // return consulta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
