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
    public partial class TabelaComestiveis : Form
    {
        public TabelaComestiveis()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AtualizarTabela()
        {
            ComestivelRepository repository = new ComestivelRepository();
            List<Comestivel> comestiveis = repository.ObterTodos();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < comestiveis.Count; i++)
            {
                Comestivel comestivel = comestiveis[i];
                dataGridView1.Rows.Add(new object[]
                {
                    comestivel.Id, comestivel.Nome, comestivel.Valor,
                    comestivel.DataVencimento, comestivel.Quantidade, comestivel.Marca
                });
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroComestiveis cadastro = new CadastroComestiveis();
            cadastro.ShowDialog();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            ComestivelRepository repository = new ComestivelRepository();
            repository.Delete(id);
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            ComestivelRepository repository = new ComestivelRepository();
            Comestivel comestivel = repository.ObterPeloID(id);

            CadastroComestiveis cadastroComestiveis = new CadastroComestiveis(comestivel);
            cadastroComestiveis.ShowDialog();
        }

        private void TabelaComestiveis_Activated(object sender, EventArgs e)
        {
            AtualizarTabela();
        }
    }
}
