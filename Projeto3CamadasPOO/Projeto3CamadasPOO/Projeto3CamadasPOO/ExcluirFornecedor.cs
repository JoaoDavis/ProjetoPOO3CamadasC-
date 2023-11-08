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
    public partial class ExcluirFornecedor : Form
    {
        public ExcluirFornecedor()
        {
            InitializeComponent();
        }

        BLL_Fornecedor objBLLFornecedor = new BLL_Fornecedor();
        DTO_Fornecedor objDTOFornecedor = new DTO_Fornecedor();

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            bool radioID = rbID.Checked;

            if (radioID == true)
            {
                objDTOFornecedor.IdFornecedor = int.Parse(txtPesquisa.Text);
                dgvPesquisa.DataSource = objBLLFornecedor.ExcluiFornecedor(objDTOFornecedor);
                MessageBox.Show("Fornecedor Excluido");
                dgvPesquisa.DataSource = objBLLFornecedor.PesquisaTodos(objDTOFornecedor);
            }
        }

        private void ExcluirFornecedor_Load(object sender, EventArgs e)
        {
            dgvPesquisa.DataSource = objBLLFornecedor.PesquisaTodos(objDTOFornecedor);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            
            this.Hide();
            menu.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
