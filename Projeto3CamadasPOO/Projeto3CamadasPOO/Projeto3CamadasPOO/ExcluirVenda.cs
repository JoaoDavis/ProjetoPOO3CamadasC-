using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace Projeto3CamadasPOO
{
    public partial class ExcluirVenda : Form
    {
        public ExcluirVenda()
        {
            InitializeComponent();
        }

        BLL_Venda objBLLVenda = new BLL_Venda();
        DTO_Venda objDTOVenda = new DTO_Venda();

        private void btnExcluiVenda_Click(object sender, EventArgs e)
        {
            bool radioID = rbID.Checked;

            if (radioID == true)
            {
                objDTOVenda.IdVenda = int.Parse(txtPesquisa.Text);
                dgvPesquisa.DataSource = objBLLVenda.ExcluiVenda(objDTOVenda);
                MessageBox.Show("Venda Excluido");
                //dgvPesquisa.DataSource = objBLLVenda.PesquisarTodos(objDTOVenda);
            }
        }

        private void ExcluirVenda_Load(object sender, EventArgs e)
        {
            //dgvPesquisa.DataSource = objBLLVenda.PesquisarTodos(objDTOVenda);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            this.Hide();
            menu.ShowDialog();
        }
    }
}
