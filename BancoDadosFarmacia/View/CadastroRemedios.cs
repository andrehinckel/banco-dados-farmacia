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
    public partial class CadastroRemedios : Form
    {

        public CadastroRemedios()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Remedio remedio = new Remedio();
            remedio.Nome = txtNome.Text;
            remedio.Generico = rbGenericoSim.Checked;
            remedio.Categoria = cbCategoria.SelectedItem.ToString();
            remedio.Solido = rbSolidoSim.Checked;
            remedio.ContraIndicacoes = txtContraIndicacoes.Text;
            remedio.Bula = txtBula.Text;
            remedio.Faixa = cbFaixa.SelectedItem.ToString();
            remedio.PrecisaReceita = rbPrecisaReceitaSim.Checked;
            RemedioRepository repository = new RemedioRepository();
            repository.Inserir(remedio);
            Close();
        }

        private void CadastroRemedios_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
