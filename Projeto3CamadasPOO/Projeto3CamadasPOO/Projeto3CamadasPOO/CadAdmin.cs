using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto3CamadasPOO
{
    public partial class CadAdmin : Form
    {
        public CadAdmin()
        {
            InitializeComponent();
        }

        DTO_Administrador objDTOAdministrador = new DTO_Administrador();
        BLL_Administrador objBLLAdministrador = new BLL_Administrador();
        private void btnCadastra_Click(object sender, EventArgs e)
        {
            try
            {
                objDTOAdministrador.userAdmin = txtUser.Text;
                objDTOAdministrador.Pass = txtSenha.Text;

                objBLLAdministrador.InserirAdmin(objDTOAdministrador);
                MessageBox.Show("Administrador Cadastrado!", "OK");
                Login login = new Login();
                this.Hide();
                login.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("erro" + ex);
            }
        }

        private void btnCadastrado_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            this.Hide();
            login.ShowDialog();
        }
    }
}
