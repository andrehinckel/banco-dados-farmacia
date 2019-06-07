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

        public CadastroRemedios(Remedio remedio)
        {
            InitializeComponent();
            txtCodigo.Text = remedio.Id.ToString();
            txtNome.Text = remedio.Nome;
            txtBula.Text = remedio.Bula;
            txtContraIndicacoes.Text = remedio.ContraIndicacoes;
            cbCategoria.SelectedItem = remedio.Categoria;
            cbFaixa.SelectedItem = remedio.Faixa;
            rbGenericoSim.Checked = remedio.Generico;
            if (remedio.Generico)
            {
                rbGenericoSim.Checked = true;
            }
            else
            {
                rbGenericoNao.Checked = true;
            }
            rbPrecisaReceitaSim.Checked = remedio.PrecisaReceita;
            if (remedio.PrecisaReceita)
            {
                rbPrecisaReceitaSim.Checked = true;
            }
            else
            {
                rbPrecisaReceitaNao.Checked = true;
            }
            rbSolidoSim.Checked = remedio.Solido;
            if (remedio.Solido)
            {
                rbSolidoSim.Checked = true;
            }
            else
            {
                rbSolidoNao.Checked = true;
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text.Length == 0)
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
            else
            {
                Remedio remedio = new Remedio();
                remedio.Id = Convert.ToInt32(txtCodigo.Text);
                remedio.Nome = txtNome.Text;
                remedio.Generico = rbGenericoSim.Checked;
                remedio.Categoria = cbCategoria.SelectedItem.ToString();
                remedio.Solido = rbSolidoSim.Checked;
                remedio.ContraIndicacoes = txtContraIndicacoes.Text;
                remedio.Bula = txtBula.Text;
                remedio.Faixa = cbFaixa.SelectedItem.ToString();
                remedio.PrecisaReceita = rbPrecisaReceitaSim.Checked;
                RemedioRepository repository = new RemedioRepository();
                repository.Update(remedio);

                MessageBox.Show("Editado com sucesso");
                Close();
            }
        }

        private void CadastroRemedios_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
           
        }
    }
}
