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
    public partial class CadastraVenda : Form
    {
        public CadastraVenda()
        {
            InitializeComponent();
        }

        BLL_Venda objBLLVenda = new BLL_Venda();
        DTO_Venda objDTOVenda= new DTO_Venda();

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            this.Hide();
            menu.ShowDialog();
        }

        private void btnCadTenis_Click(object sender, EventArgs e)
        {
            objDTOVenda.DataVenda = dtpData.Value.ToString("yyyy/MM/dd");
            objDTOVenda.NomeVendedor = txtFuncionario.Text;
            objDTOVenda.PrecoVenda = float.Parse(txtVenda.Text);

            objBLLVenda.InserirVenda(objDTOVenda);
            MessageBox.Show("Venda Cadastrada!", "OK");

            txtVenda.Clear();
            txtFuncionario.Clear();
        }
    }
}
