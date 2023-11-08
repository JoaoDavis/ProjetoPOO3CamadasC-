using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace BLL
{
     class BLL_Tenis : BLL_TenisBase
    {
        Conexao conexao = new Conexao();

        public void InserirTenis(DTO_Tenis Tenis)
        {
            try
            {
                string comando = "INSERT INTO Tenis VALUES(NULL, '" + Tenis.Tamanho + "','"
                                                                     + Tenis.Marca + "','" 
                                                                     + Tenis.Cor + "','"
                                                                     + Tenis.Modelo + "');";
                conexao.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
