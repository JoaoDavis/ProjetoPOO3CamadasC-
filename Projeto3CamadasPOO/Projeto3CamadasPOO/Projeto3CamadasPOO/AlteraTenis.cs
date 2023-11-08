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
using BLL;

namespace Projeto3CamadasPOO
{
    public partial class AlteraTenis : Form
    {
        public AlteraTenis()
        {
            InitializeComponent();
        }

        BLL_TenisBase objBLLTenis = new BLL_TenisBase();
        DTO_Tenis objDTOTenis = new DTO_Tenis();


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            bool radioID = rbID.Checked;


            if (radioID == true)
            {
                objDTOTenis.IdTenis = int.Parse(txtID.Text);
                objDTOTenis.Tamanho = txtTamanho.Text;
                objDTOTenis.Marca = txtMarca.Text;
                objDTOTenis.Cor = txtCor.Text;
                objDTOTenis.Modelo = txtModelo.Text;
                objBLLTenis.AlterarTenis(objDTOTenis);

                MessageBox.Show("Tênis Alterado!", "OK");

                txtTamanho.Clear();
                txtMarca.Clear();
                txtModelo.Clear();
                txtCor.Clear();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            this.Hide();
            menu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool radioID = rbID.Checked;

            if (radioID == true)
            {
                objDTOTenis.IdTenis = int.Parse(txtID.Text);
                txtCor.Text = objBLLTenis.RetornaCor(objDTOTenis);
                txtTamanho.Text = objBLLTenis.RetornaTamanho(objDTOTenis);
                txtModelo.Text = objBLLTenis.RetornaModelo(objDTOTenis);
                txtMarca.Text = objBLLTenis.RetornaMarca(objDTOTenis);
            }
        }
    }
}
