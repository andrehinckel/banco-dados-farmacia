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
    public partial class EditarCadastroComestiveis : Form
    {
        public EditarCadastroComestiveis()
        {
            InitializeComponent();
        }

        public EditarCadastroComestiveis(Comestivel comestivel)
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
}
