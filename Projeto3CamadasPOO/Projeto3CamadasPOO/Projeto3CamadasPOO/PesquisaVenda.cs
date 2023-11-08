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
    public partial class PesquisaVenda : Form
    {
        public PesquisaVenda()
        {
            InitializeComponent();
        }

        BLL_Venda objBLLVenda = new BLL_Venda();
        DTO_Venda objDTOVenda = new DTO_Venda();

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            this.Hide();
            menu.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            bool radioID = rbID.Checked;
            bool radioData = rbData.Checked;


            if (radioID == true)
            {
                objDTOVenda.IdVenda = int.Parse(txtPesquisa.Text);
                dgvPesquisa.DataSource = objBLLVenda.PesquisarVendaID(objDTOVenda);
            }
            else if (radioData == true)
            {
                objDTOVenda.DataVenda = txtPesquisa.Text;
                dgvPesquisa.DataSource = objBLLVenda.PesquisarVendaData(objDTOVenda);
            }
        }
    }
}
