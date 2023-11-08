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
using System.Xml.Linq;

namespace Projeto3CamadasPOO
{
    public partial class PesquisaVendedor : Form
    {
        public PesquisaVendedor()
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            bool radioID = rbID.Checked;
            bool radioNome = rbNome.Checked;
            bool radioCpf = rbCpf.Checked;


            if (radioID == true)
            {
                objDTOVendedor.IdVendedor = int.Parse(txtPesquisa.Text);
                dgvPesquisa.DataSource = objBLLVendedor.PesquisarVendedorID(objDTOVendedor);
            }
            else if (radioNome == true)
            {
                objDTOVendedor.NomeVendedor = txtPesquisa.Text;
                dgvPesquisa.DataSource = objBLLVendedor.PesquisarVendedorNome(objDTOVendedor);
            }
            else if (radioCpf == true)
            {
                objDTOVendedor.Cpf = txtPesquisa.Text;
                dgvPesquisa.DataSource = objBLLVendedor.PesquisarVendedorCpf(objDTOVendedor);
            }
        }
    }
}
