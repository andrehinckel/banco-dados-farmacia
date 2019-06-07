using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class CadastroComestiveis : Form
    {
        System.Text.RegularExpressions.Regex num = new System.Text.RegularExpressions.Regex("[^A-z]");

        public CadastroComestiveis()
        {
            InitializeComponent();
        }
         public CadastroComestiveis(Comestivel comestivel)
         {
            InitializeComponent();
            txtCodigo.Text = comestivel.Id.ToString();
            txtNome.Text = comestivel.Nome;
            txtValor.Text = Convert.ToString(comestivel.Valor);
            dtpDataVencimento.Value = Convert.ToDateTime(comestivel.DataVencimento);
            txtQuantidade.Text = Convert.ToString(comestivel.Quantidade);
            txtMarca.Text = comestivel.Marca;
         }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text.Length == 0)
            {
                Comestivel comestivel = new Comestivel();
                comestivel.Nome = txtNome.Text;
                comestivel.Valor = Convert.ToDecimal(txtValor.Text);
                comestivel.DataVencimento = Convert.ToDateTime(dtpDataVencimento.Value);
                comestivel.Quantidade = Convert.ToInt32(txtQuantidade.Text);
                comestivel.Marca = txtMarca.Text;
                ComestivelRepository repository = new ComestivelRepository();
                repository.Inserir(comestivel);
                Close();
            }
            else
            {
                Comestivel comestivel = new Comestivel();
                comestivel.Id = Convert.ToInt32(txtCodigo.Text);
                comestivel.Nome = txtNome.Text;
                comestivel.Valor = Convert.ToDecimal(txtValor.Text);
                comestivel.DataVencimento = Convert.ToDateTime(dtpDataVencimento.Value);
                comestivel.Quantidade = Convert.ToInt32(txtQuantidade.Text);
                comestivel.Marca = txtMarca.Text;
                ComestivelRepository repository = new ComestivelRepository();
                repository.Update(comestivel);

                MessageBox.Show("Editado com sucesso");
                Close();
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal valor = Convert.ToDecimal(txtValor.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Deve conter somente números");
                txtValor.Focus();
                return;
            }
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal quantidade = Convert.ToDecimal(txtQuantidade.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Deve conter somente números");
                txtQuantidade.Focus();
                return;
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            
            if(num.IsMatch(this.txtNome.Text))
            {
                MessageBox.Show("Nome deve conter somente caracteres");
                txtNome.Focus();
                return;
            }
        }

        private void txtMarca_Leave(object sender, EventArgs e)
        {
            if (num.IsMatch(this.txtMarca.Text))
            {
                MessageBox.Show("Marca deve conter somente caracteres");
                txtMarca.Focus();
                return;
            }
        }
    }
}
