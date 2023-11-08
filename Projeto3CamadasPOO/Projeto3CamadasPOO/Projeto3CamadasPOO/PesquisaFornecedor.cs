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
    public partial class PesquisaFornecedor : Form
    {
        public PesquisaFornecedor()
        {
            InitializeComponent();
        }

        BLL_Fornecedor objBLLFornecedor = new BLL_Fornecedor();
        DTO_Fornecedor objDTOFornecedor = new DTO_Fornecedor();

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            this.Hide();
            menu.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            bool radioID = rbID.Checked;
            bool radioNome = rbNome.Checked;
            bool radioCnpj = rbCnpj.Checked;

            if (radioID == true)
            {
                objDTOFornecedor.IdFornecedor= int.Parse(txtPesquisa.Text);
                dgvPesquisa.DataSource = objBLLFornecedor.PesquisarFornecedorID(objDTOFornecedor);
            }
            else if (radioNome == true)
            {
                objDTOFornecedor.NomeFornecedor = txtPesquisa.Text;
                dgvPesquisa.DataSource = objBLLFornecedor.PesquisarFornecedorNome(objDTOFornecedor);
            }
            else if (radioCnpj == true)
            {
                objDTOFornecedor.Cnpj = txtPesquisa.Text;
                dgvPesquisa.DataSource = objBLLFornecedor.PesquisarFornecedorCnpj(objDTOFornecedor);
            }
        }
    }
}
