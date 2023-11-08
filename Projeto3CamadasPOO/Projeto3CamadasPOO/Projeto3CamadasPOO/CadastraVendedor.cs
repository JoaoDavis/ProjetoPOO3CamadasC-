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
    public partial class CadastraVendedor : Form
    {
        public CadastraVendedor()
        {
            InitializeComponent();
        }

        BLL_Vendedor objBLLVendedor = new BLL_Vendedor();
        DTO_Vendedor objDTOVendedor = new DTO_Vendedor();   

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            this.Hide();
            menu.ShowDialog();
        }

        private void btnCadTenis_Click(object sender, EventArgs e)
        {
            objDTOVendedor.NomeVendedor = txtNomeVend.Text;
            objDTOVendedor.Cpf = txtCpf.Text;
            objDTOVendedor.Telefone = txtTelefone.Text;
            objDTOVendedor.Endereco = txtEndereco.Text;

            objBLLVendedor.InserirVendedor(objDTOVendedor);
            MessageBox.Show("Vendedor Cadastrador!", "OK");

            txtNomeVend.Clear();
            txtCpf.Clear();
            txtTelefone.Clear();
            txtEndereco.Clear();
        }
    }
}
