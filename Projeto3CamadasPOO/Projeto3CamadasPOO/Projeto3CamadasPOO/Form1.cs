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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DTO_Usuario objDTOUsuario = new DTO_Usuario();
        BLL_Usuario objBLLUsuario = new BLL_Usuario();

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            try
            {
                objDTOUsuario.Usuario = txtUser.Text;   
                objDTOUsuario.Pass = txtSenha.Text;

                objBLLUsuario.InserirUsuario(objDTOUsuario);
                MessageBox.Show("Usuário Cadastrado! \n Seu ID é: " + objBLLUsuario.UltimoID(objDTOUsuario), "OK");
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

        private void button1_Click(object sender, EventArgs e)
        {
            CadAdmin admin = new CadAdmin();

            this.Hide();
            admin.ShowDialog();
        }
    }
}
