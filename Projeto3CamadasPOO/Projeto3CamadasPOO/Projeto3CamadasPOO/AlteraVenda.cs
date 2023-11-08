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
    public partial class AlteraVenda : Form
    {
        public AlteraVenda()
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            bool radioID = rbID.Checked;


            if (radioID == true)
            {
                objDTOVenda.IdVenda = int.Parse(txtID.Text);
                objDTOVenda.DataVenda = dtpData.Value.ToString("yyyy/mm/dd");
                objDTOVenda.PrecoVenda = float.Parse(txtPreco.Text);
                objBLLVenda.AlterarVenda(objDTOVenda);

                MessageBox.Show("Venda Alterada!", "OK");

                txtPreco.Clear();
            }
        }

        private void btnPesqVenda_Click(object sender, EventArgs e)
        {
            bool radioID = rbID.Checked;

            if (radioID == true)
            {
                objDTOVenda.IdVenda = int.Parse(txtID.Text);
                txtPreco.Text = objBLLVenda.RetornaPreco(objDTOVenda);
            }
        }
    }
}
