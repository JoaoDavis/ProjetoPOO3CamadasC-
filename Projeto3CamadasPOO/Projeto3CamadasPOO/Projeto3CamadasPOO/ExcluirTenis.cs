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
    public partial class ExcluirTenis : Form
    {
        public ExcluirTenis()
        {
            InitializeComponent();
        }

        BLL_Tenis objBLLTenis = new BLL_Tenis();
        DTO_Tenis objDTOTenisBase = new DTO_Tenis();

        private void ExcluirTenis_Load(object sender, EventArgs e)
        {
            dgvPesquisa.DataSource = objBLLTenis.PesquisaTodos(objDTOTenisBase);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            bool radioID = rbID.Checked;

            if (radioID == true)
            {
                objDTOTenisBase.IdTenis = int.Parse(txtPesquisa.Text);
                dgvPesquisa.DataSource = objBLLTenis.ExcluiTenis(objDTOTenisBase);
                MessageBox.Show("Tenis Excluido");
                dgvPesquisa.DataSource = objBLLTenis.PesquisaTodos(objDTOTenisBase);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            this.Hide();
            menu.ShowDialog();

        }
    }
}
