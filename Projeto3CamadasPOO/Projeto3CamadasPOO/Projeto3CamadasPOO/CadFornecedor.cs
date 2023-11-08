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
    public partial class CadFornecedor : Form
    {
        public CadFornecedor()
        {
            InitializeComponent();
        }

        DTO_Fornecedor objDTOFornecedor = new DTO_Fornecedor();
        BLL_Fornecedor objBLLFornecedor = new BLL_Fornecedor();

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }

        private void btnCadFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                objDTOFornecedor.NomeFornecedor = txtNomeFornecedor.Text;
                objDTOFornecedor.Cnpj = txtCnpj.Text;
                objDTOFornecedor.Telefone = txtTelefone.Text;
                objDTOFornecedor.Endereco = txtEndereco.Text;

                objBLLFornecedor.InserirFornecedor(objDTOFornecedor);
                MessageBox.Show("Fornecedor Cadastrado!", "OK");

                txtCnpj.Clear();
                txtTelefone.Clear();
                txtNomeFornecedor.Clear();
                txtEndereco.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("erro" + ex);
            }
        }
    }
}
