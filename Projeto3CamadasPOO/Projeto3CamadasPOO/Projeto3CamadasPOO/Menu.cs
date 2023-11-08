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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCadTenis_Click(object sender, EventArgs e)
        {
            CadastraTenis cadTenis = new CadastraTenis();

            this.Hide();
            cadTenis.ShowDialog();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            PesquisaTenis pesquisa= new PesquisaTenis();        

            this.Hide();
            pesquisa.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirTenis excluirTenis = new ExcluirTenis();

            this.Hide();
            excluirTenis.ShowDialog();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            CadFornecedor fornecedor = new CadFornecedor();

            this.Hide();
            fornecedor.ShowDialog();
        }

        private void btnPesqFornecedor_Click(object sender, EventArgs e)
        {
            PesquisaFornecedor pesquisaFornecedor = new PesquisaFornecedor();

            this.Hide();
            pesquisaFornecedor.ShowDialog();
        }

        private void btnExcFornecedor_Click(object sender, EventArgs e)
        {
            ExcluirFornecedor excluirFornecedor= new ExcluirFornecedor();

            this.Hide();
            excluirFornecedor.ShowDialog();
        }

        private void btnCadVenda_Click(object sender, EventArgs e)
        {
            CadastraVenda cadastra= new CadastraVenda();

            this.Hide();
            cadastra.ShowDialog();
        }

        private void btnAlteraTenis_Click(object sender, EventArgs e)
        {
            AlteraTenis altera= new AlteraTenis();

            this.Hide();
            altera.ShowDialog();
        }

        private void btnAlteraFornecedor_Click(object sender, EventArgs e)
        {
            AlteraFornecedor altera= new AlteraFornecedor();

            this.Hide();
            altera.ShowDialog();
        }

        private void btnAlteraVenda_Click(object sender, EventArgs e)
        {
            AlteraVenda altera= new AlteraVenda();

            this.Hide();
            altera.ShowDialog();
        }

        private void btnPesquisaVenda_Click(object sender, EventArgs e)
        {
            PesquisaVenda pesquisaVenda = new PesquisaVenda();

            this.Hide();
            pesquisaVenda.ShowDialog();
        }

        private void btnExcVenda_Click(object sender, EventArgs e)
        {
            ExcluirVenda excluirVenda = new ExcluirVenda();

            this.Hide();
            excluirVenda.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            DTO_Usuario objDTOUsuario = new DTO_Usuario();
            BLL_Usuario objBLLUsuario = new BLL_Usuario();

        }

        private void btnalteraVend_Click(object sender, EventArgs e)
        {
            AlteraVendedor alteraVendedor = new AlteraVendedor();

            this.Hide();
            alteraVendedor.ShowDialog();
        }

        private void btnCadVendedor_Click(object sender, EventArgs e)
        {
            CadastraVendedor cadastraVendedor = new CadastraVendedor();

            this.Hide();
            cadastraVendedor.ShowDialog();
        }

        private void btnPessqVend_Click(object sender, EventArgs e)
        {
            PesquisaVendedor pesquisaVendedor = new PesquisaVendedor();

            this.Hide();
            pesquisaVendedor.ShowDialog();
        }

        private void btnExcVend_Click(object sender, EventArgs e)
        {
            ExcluirVendedor excluirVendedor = new ExcluirVendedor();

            this.Hide();
            excluirVendedor.ShowDialog();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
        }
    }
}
