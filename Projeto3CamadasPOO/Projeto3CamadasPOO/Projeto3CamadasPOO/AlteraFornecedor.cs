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
    public partial class AlteraFornecedor : Form
    {
        public AlteraFornecedor()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            this.Hide();
            menu.ShowDialog();
        }

        BLL_Fornecedor objBLLFornecedor = new BLL_Fornecedor();
        DTO_Fornecedor objDTOFornecedor = new DTO_Fornecedor();

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            bool radioID = rbID.Checked;


            if (radioID == true)
            {
                objDTOFornecedor.IdFornecedor = int.Parse(txtID.Text);
                objDTOFornecedor.NomeFornecedor = txtNome.Text;
                objDTOFornecedor.Cnpj = txtCnpj.Text;
                objDTOFornecedor.Telefone = txtTelefone.Text;
                objDTOFornecedor.Endereco = txtEndereco.Text;
                objBLLFornecedor.AlterarFornecedor(objDTOFornecedor);

                MessageBox.Show("Fornecedor Alterado!", "OK");

                txtCnpj.Clear();
                txtTelefone.Clear();
                txtNome.Clear();
                txtEndereco.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool radioID = rbID.Checked;

            if (radioID == true)
            {
                objDTOFornecedor.IdFornecedor = int.Parse(txtID.Text);
                txtNome.Text = objBLLFornecedor.RetornaNome(objDTOFornecedor);
                txtCnpj.Text = objBLLFornecedor.RetornaCnpj(objDTOFornecedor);
                txtTelefone.Text = objBLLFornecedor.RetornaTelefone(objDTOFornecedor);
                txtEndereco.Text = objBLLFornecedor.RetornaEndereco(objDTOFornecedor);
            }
        }
    }
}
