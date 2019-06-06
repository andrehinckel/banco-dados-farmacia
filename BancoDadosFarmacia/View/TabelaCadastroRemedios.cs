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
    public partial class TabelaCadastroRemedios : Form
    {
            
        public TabelaCadastroRemedios()
        {
            InitializeComponent();
        }
        private void AtualizarTabela()
        {
            RemedioRepository repository = new RemedioRepository();
            List<Remedio> remedios = repository.ObterTodos();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < remedios.Count; i++)
            {
                Remedio remedio = remedios[i];
                dataGridView1.Rows.Add(new object[]
                {
                    remedio.Id, remedio.Nome, remedio.Generico, remedio.Categoria, remedio.Solido, remedio.ContraIndicacoes, remedio.Bula, remedio.Faixa, remedio.PrecisaReceita
                });
            }
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroRemedios cadastro = new CadastroRemedios();
            cadastro.ShowDialog();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            RemedioRepository repository = new RemedioRepository();
            repository.Delete(id);
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
        }

        private void TabelaCadastroRemedios_Activated(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            RemedioRepository repository = new RemedioRepository();
            Remedio remedio = repository.ObterPeloId(id);

            EditarCadastroRemedios Cadastroeditar = new EditarCadastroRemedios(remedio);
            Cadastroeditar.ShowDialog();
        }
    }
}
