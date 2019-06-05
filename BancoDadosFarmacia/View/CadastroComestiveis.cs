﻿using Model;
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
    public partial class CadastroComestiveis : Form
    {
        public CadastroComestiveis()
        {
            InitializeComponent();
        }
      
        private void btnSalvar_Click(object sender, EventArgs e)
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
    }
}
