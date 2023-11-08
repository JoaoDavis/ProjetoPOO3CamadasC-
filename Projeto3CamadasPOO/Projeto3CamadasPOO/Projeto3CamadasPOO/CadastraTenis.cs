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
    public partial class CadastraTenis : Form
    {
        public CadastraTenis()
        {
            InitializeComponent();
        }

        BLL_Tenis objBLLTenis = new BLL_Tenis();
        DTO_Tenis objDTOTenis= new DTO_Tenis();

        private void btnCadTenis_Click(object sender, EventArgs e)
        {
            try
            {
                objDTOTenis.Tamanho = txtTamanho.Text;
                objDTOTenis.Marca = txtMarca.Text;
                objDTOTenis.Cor = txtCor.Text;
                objDTOTenis.Modelo = txtModelo.Text;

                objBLLTenis.InserirTenis(objDTOTenis);
                MessageBox.Show("Tênis Cadastrado!", "OK");

                txtMarca.Clear();
                txtModelo.Clear();
                txtCor.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("erro" + ex);
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
