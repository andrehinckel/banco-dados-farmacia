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

        public CadastroProdutosHigienicos(ProdutoHigienico produtoHigienico)
        {
            InitializeComponent();
            txtCodigo.Text = produtoHigienico.Id.ToString(); ;
            txtNome.Text = produtoHigienico.Nome;
            cbCategoria.SelectedItem = produtoHigienico.Categoria;
            mtbPreco.Text = produtoHigienico.Preco.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0)
            {
                ProdutoHigienico produtoHigienico = new ProdutoHigienico();
                produtoHigienico.Nome = txtNome.Text;
                produtoHigienico.Preco = Convert.ToDecimal(mtbPreco.Text.Replace("R$", ""));
                produtoHigienico.Categoria = cbCategoria.SelectedItem.ToString();
                ProdutoHigienicoRepository repository = new ProdutoHigienicoRepository();
                repository.Inserir(produtoHigienico);
                Close();
            }
            if(txtCodigo.Text.Length == 1)
            {
                ProdutoHigienico produtoHigienico = new ProdutoHigienico();
                produtoHigienico.Id = Convert.ToInt32(txtCodigo.Text);
                produtoHigienico.Nome = txtNome.Text;
                produtoHigienico.Preco = Convert.ToDecimal(mtbPreco.Text.Replace("R$", ""));
                produtoHigienico.Categoria = cbCategoria.SelectedItem.ToString();
                ProdutoHigienicoRepository repository = new ProdutoHigienicoRepository();
                repository.Update(produtoHigienico);

                MessageBox.Show("Editado com sucesso");
                Close();
            }
        }

        private void mtbPreco_Leave(object sender, EventArgs e)
        {
           
        }
    }
}
