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
    public partial class TabelaProdutoHigienico : Form
    {
        public TabelaProdutoHigienico()
        {
            InitializeComponent();
        }

        private void AtualizarTabela()
        {
            ProdutoHigienicoRepository repository = new ProdutoHigienicoRepository();
            List<ProdutoHigienico> produtosHigienicos = repository.ObterTodos();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < produtosHigienicos.Count; i++)
            {
                ProdutoHigienico produtoHigienico = produtosHigienicos[i];
                dataGridView1.Rows.Add(new object[]
                {
                    produtoHigienico.Id, produtoHigienico.Nome, produtoHigienico.Preco, produtoHigienico.Categoria
                });
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroProdutosHigienicos cadastroProdutosHigienicos = new CadastroProdutosHigienicos();
            cadastroProdutosHigienicos.ShowDialog();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            ProdutoHigienicoRepository repository = new ProdutoHigienicoRepository();
            repository.Delete(id);
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
        }

        private void TabelaProdutoHigienico_Activated(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            ProdutoHigienicoRepository repository = new ProdutoHigienicoRepository();
            ProdutoHigienico produtoHigienico = repository.ObterPeloID(id);

            CadastroProdutosHigienicos cadastroProdutosHigienicos = new CadastroProdutosHigienicos(produtoHigienico);
            cadastroProdutosHigienicos.ShowDialog();
        }
    }
}
