using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnCadastroComestiveis_Click(object sender, EventArgs e)
        {
            TabelaComestiveis cadastro = new TabelaComestiveis();
            cadastro.ShowDialog();
        }

        private void btnCadastroProdutosHigienicos_Click(object sender, EventArgs e)
        {
            TabelaProdutoHigienico tabelaProdutoHigienico = new TabelaProdutoHigienico();
            tabelaProdutoHigienico.ShowDialog();
        }

        private void btnRemedios_Click(object sender, EventArgs e)
        {

            TabelaCadastroRemedios tabelaCadastroRemedios = new TabelaCadastroRemedios();
            tabelaCadastroRemedios.ShowDialog();

        }
    }
}
