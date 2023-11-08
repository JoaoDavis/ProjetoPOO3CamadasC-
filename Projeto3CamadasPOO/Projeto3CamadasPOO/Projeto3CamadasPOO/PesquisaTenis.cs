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
    public partial class PesquisaTenis : Form
    {
        public PesquisaTenis()
        {
            InitializeComponent();
        }

        BLL_Tenis objBLLTenis = new BLL_Tenis();
        DTO_Tenis objDTOTenisBase = new DTO_Tenis();

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            bool radioID = rbID.Checked;
            bool radioModelo = rbModelo.Checked;
            bool radioMarca = rbMarca.Checked;


            if (radioID == true)
            {
                objDTOTenisBase.IdTenis = int.Parse(txtPesquisa.Text);
                dgvPesquisa.DataSource = objBLLTenis.PesquisarTenisID(objDTOTenisBase);
            }
            else if(radioMarca == true)
            {
                objDTOTenisBase.Marca = txtPesquisa.Text;
                dgvPesquisa.DataSource = objBLLTenis.PesquisarTenisMarca(objDTOTenisBase);
            }
            else if (radioModelo == true)
            {
                objDTOTenisBase.Modelo = txtPesquisa.Text;
                dgvPesquisa.DataSource = objBLLTenis.PesquisarTenisModelo(objDTOTenisBase);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            this.Hide();
            menu.ShowDialog();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
