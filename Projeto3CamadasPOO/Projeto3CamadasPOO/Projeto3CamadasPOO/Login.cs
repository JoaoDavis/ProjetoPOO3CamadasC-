
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Projeto3CamadasPOO
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        DTO_Usuario objDTOUsuario = new DTO_Usuario();
        BLL_Usuario objBLLUsuario = new BLL_Usuario();

        DTO_Administrador objDTOAdministrador = new DTO_Administrador();
        BLL_Administrador objBLLAdministrador = new BLL_Administrador();

        private void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                Menu menu = new Menu();

                   
                string OpcaoLogar = cbLogar.Text;

                if (OpcaoLogar == "Usuario")
                {

                    objDTOUsuario.IdUsuario = int.Parse(txtidUser.Text);

                    string User = objBLLUsuario.VerificaUsuario(objDTOUsuario);
                    string Pass = objBLLUsuario.VerificaSenha(objDTOUsuario);

                    if (User == txtUser.Text && Pass == txtSenha.Text)
                    {
                        MessageBox.Show("Usuario Correto!");
                        this.Hide();
                        menu.ShowDialog();
                    }
                    else if (User != txtUser.Text || Pass != txtSenha.Text)
                    {
                        MessageBox.Show("Usuario ou Senha Incorreto!");
                    }

                    

                }
                else if (OpcaoLogar == "Administrador")
                {
                    objDTOAdministrador.userAdmin = txtUser.Text;
                    objDTOAdministrador.Pass = txtSenha.Text;
                    var teste = objBLLAdministrador.VerificaAdmin(objDTOAdministrador.userAdmin, objDTOAdministrador.Pass);

                    if (teste == true)
                    {
                        MessageBox.Show("Administrador Correto!");
                        this.Hide();
                        menu.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Administrador Incorreto!");
                    }

                }
                else
                {
                    MessageBox.Show("Preencha os Campos!");
                }
                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("erro" + ex);
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            this.Hide();
            form1.ShowDialog();
        }
    }
}
