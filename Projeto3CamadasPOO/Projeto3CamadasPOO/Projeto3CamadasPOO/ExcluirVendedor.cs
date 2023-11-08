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
    public partial class ExcluirVendedor : Form
    {
        public ExcluirVendedor()
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            bool radioID = rbID.Checked;

            if (radioID == true)
            {
                objDTOVendedor.IdVendedor = int.Parse(txtID.Text);
                dgvPesquisa.DataSource = objBLLVendedor.ExcluiVendedor(objDTOVendedor);
                MessageBox.Show("Vendedor Excluido");
                dgvPesquisa.DataSource = objBLLVendedor.PesquisaTodos(objDTOVendedor);
            }
        }
    }
}
