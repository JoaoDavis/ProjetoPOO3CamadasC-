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
    public partial class AlteraVendedor : Form
    {
        public AlteraVendedor()
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            bool radioID = rbID.Checked;


            if (radioID == true)
            {
                objDTOVendedor.IdVendedor = int.Parse(txtID.Text);
                objDTOVendedor.Cpf = txtCpf.Text;
                objDTOVendedor.NomeVendedor = txtNome.Text;
                objDTOVendedor.Telefone = txtTelefone.Text;
                objDTOVendedor.Endereco = txtEndereco.Text;
                objBLLVendedor.AlterarVendedor(objDTOVendedor);

                MessageBox.Show("Fornecedor Alterado!", "OK");

                txtCpf.Clear();
                txtTelefone.Clear();
                txtNome.Clear();
                txtEndereco.Clear();
            }
        }

        private void btnPesqVend_Click(object sender, EventArgs e)
        {
            bool radioID = rbID.Checked;

            if (radioID == true)
            {
                objDTOVendedor.IdVendedor = int.Parse(txtID.Text);
                txtNome.Text = objBLLVendedor.RetornaNome(objDTOVendedor);
                txtCpf.Text = objBLLVendedor.RetornaCpf(objDTOVendedor);
                txtTelefone.Text = objBLLVendedor.RetornaTelefone(objDTOVendedor);
                txtEndereco.Text = objBLLVendedor.RetornaEndereco(objDTOVendedor);
            }
        }
    }
}
