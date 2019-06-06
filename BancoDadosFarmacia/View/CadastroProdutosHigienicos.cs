using Model;
using Repository;
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
    public partial class CadastroProdutosHigienicos : Form
    {
        public CadastroProdutosHigienicos()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProdutoHigienico produtoHigienico = new ProdutoHigienico();
            produtoHigienico.Nome = txtNome.Text;
            produtoHigienico.Preco = Convert.ToDecimal(mtbPreco.Text.Replace("R$", ""));
            produtoHigienico.Categoria = cbCategoria.SelectedItem.ToString();
            ProdutoHigienicoRepository repository = new ProdutoHigienicoRepository();
            repository.Inserir(produtoHigienico);
            Close();
        }
    }
}
