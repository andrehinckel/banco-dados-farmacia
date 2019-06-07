namespace View
{
    partial class CadastroRemedios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblSolido = new System.Windows.Forms.Label();
            this.lblContraIndicacoes = new System.Windows.Forms.Label();
            this.txtContraIndicacoes = new System.Windows.Forms.TextBox();
            this.lblBula = new System.Windows.Forms.Label();
            this.txtBula = new System.Windows.Forms.TextBox();
            this.lblFaixa = new System.Windows.Forms.Label();
            this.lblPrecisaReceita = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.rbPrecisaReceitaSim = new System.Windows.Forms.RadioButton();
            this.rbPrecisaReceitaNao = new System.Windows.Forms.RadioButton();
            this.cbFaixa = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.rbSolidoSim = new System.Windows.Forms.RadioButton();
            this.rbSolidoNao = new System.Windows.Forms.RadioButton();
            this.gbSolido = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Generico = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbGenericoNao = new System.Windows.Forms.RadioButton();
            this.rbGenericoSim = new System.Windows.Forms.RadioButton();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gbSolido.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("BankGothic Md BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 60);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(83, 25);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(17, 89);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(254, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("BankGothic Md BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(12, 112);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(149, 25);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblSolido
            // 
            this.lblSolido.AutoSize = true;
            this.lblSolido.Font = new System.Drawing.Font("BankGothic Md BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolido.Location = new System.Drawing.Point(6, 16);
            this.lblSolido.Name = "lblSolido";
            this.lblSolido.Size = new System.Drawing.Size(102, 25);
            this.lblSolido.TabIndex = 5;
            this.lblSolido.Text = "Sólido";
            // 
            // lblContraIndicacoes
            // 
            this.lblContraIndicacoes.AutoSize = true;
            this.lblContraIndicacoes.Font = new System.Drawing.Font("BankGothic Md BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraIndicacoes.Location = new System.Drawing.Point(16, 172);
            this.lblContraIndicacoes.Name = "lblContraIndicacoes";
            this.lblContraIndicacoes.Size = new System.Drawing.Size(264, 25);
            this.lblContraIndicacoes.TabIndex = 7;
            this.lblContraIndicacoes.Text = "Contra Indicações";
            // 
            // txtContraIndicacoes
            // 
            this.txtContraIndicacoes.Location = new System.Drawing.Point(17, 200);
            this.txtContraIndicacoes.Multiline = true;
            this.txtContraIndicacoes.Name = "txtContraIndicacoes";
            this.txtContraIndicacoes.Size = new System.Drawing.Size(254, 44);
            this.txtContraIndicacoes.TabIndex = 8;
            // 
            // lblBula
            // 
            this.lblBula.AutoSize = true;
            this.lblBula.Font = new System.Drawing.Font("BankGothic Md BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBula.Location = new System.Drawing.Point(17, 248);
            this.lblBula.Name = "lblBula";
            this.lblBula.Size = new System.Drawing.Size(77, 25);
            this.lblBula.TabIndex = 9;
            this.lblBula.Text = "Bula";
            // 
            // txtBula
            // 
            this.txtBula.Location = new System.Drawing.Point(17, 276);
            this.txtBula.Name = "txtBula";
            this.txtBula.Size = new System.Drawing.Size(254, 20);
            this.txtBula.TabIndex = 10;
            // 
            // lblFaixa
            // 
            this.lblFaixa.AutoSize = true;
            this.lblFaixa.Font = new System.Drawing.Font("BankGothic Md BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaixa.Location = new System.Drawing.Point(12, 300);
            this.lblFaixa.Name = "lblFaixa";
            this.lblFaixa.Size = new System.Drawing.Size(82, 25);
            this.lblFaixa.TabIndex = 11;
            this.lblFaixa.Text = "Faixa";
            // 
            // lblPrecisaReceita
            // 
            this.lblPrecisaReceita.AutoSize = true;
            this.lblPrecisaReceita.Font = new System.Drawing.Font("BankGothic Md BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecisaReceita.Location = new System.Drawing.Point(5, 16);
            this.lblPrecisaReceita.Name = "lblPrecisaReceita";
            this.lblPrecisaReceita.Size = new System.Drawing.Size(225, 25);
            this.lblPrecisaReceita.TabIndex = 13;
            this.lblPrecisaReceita.Text = "Precisa Receita";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("BankGothic Md BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(205, 375);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(140, 49);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // rbPrecisaReceitaSim
            // 
            this.rbPrecisaReceitaSim.AutoSize = true;
            this.rbPrecisaReceitaSim.Font = new System.Drawing.Font("BankGothic Md BT", 18.75F);
            this.rbPrecisaReceitaSim.Location = new System.Drawing.Point(6, 44);
            this.rbPrecisaReceitaSim.Name = "rbPrecisaReceitaSim";
            this.rbPrecisaReceitaSim.Size = new System.Drawing.Size(76, 30);
            this.rbPrecisaReceitaSim.TabIndex = 16;
            this.rbPrecisaReceitaSim.TabStop = true;
            this.rbPrecisaReceitaSim.Text = "Sim";
            this.rbPrecisaReceitaSim.UseVisualStyleBackColor = true;
            // 
            // rbPrecisaReceitaNao
            // 
            this.rbPrecisaReceitaNao.AutoSize = true;
            this.rbPrecisaReceitaNao.Font = new System.Drawing.Font("BankGothic Md BT", 18.75F);
            this.rbPrecisaReceitaNao.Location = new System.Drawing.Point(124, 44);
            this.rbPrecisaReceitaNao.Name = "rbPrecisaReceitaNao";
            this.rbPrecisaReceitaNao.Size = new System.Drawing.Size(86, 30);
            this.rbPrecisaReceitaNao.TabIndex = 17;
            this.rbPrecisaReceitaNao.TabStop = true;
            this.rbPrecisaReceitaNao.Text = "Não";
            this.rbPrecisaReceitaNao.UseVisualStyleBackColor = true;
            // 
            // cbFaixa
            // 
            this.cbFaixa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFaixa.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.cbFaixa.FormattingEnabled = true;
            this.cbFaixa.Items.AddRange(new object[] {
            "Preta",
            "Vermelha",
            "Amarela",
            "Branca"});
            this.cbFaixa.Location = new System.Drawing.Point(17, 328);
            this.cbFaixa.Name = "cbFaixa";
            this.cbFaixa.Size = new System.Drawing.Size(254, 25);
            this.cbFaixa.TabIndex = 18;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Fitoterápico",
            "Alopático",
            "Homeopático",
            "Similar",
            "Genérico",
            "Referência",
            "Manipulado"});
            this.cbCategoria.Location = new System.Drawing.Point(17, 136);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(254, 25);
            this.cbCategoria.TabIndex = 19;
            // 
            // rbSolidoSim
            // 
            this.rbSolidoSim.AutoSize = true;
            this.rbSolidoSim.Font = new System.Drawing.Font("BankGothic Md BT", 18.75F);
            this.rbSolidoSim.Location = new System.Drawing.Point(6, 44);
            this.rbSolidoSim.Name = "rbSolidoSim";
            this.rbSolidoSim.Size = new System.Drawing.Size(76, 30);
            this.rbSolidoSim.TabIndex = 20;
            this.rbSolidoSim.TabStop = true;
            this.rbSolidoSim.Text = "Sim";
            this.rbSolidoSim.UseVisualStyleBackColor = true;
            // 
            // rbSolidoNao
            // 
            this.rbSolidoNao.AutoSize = true;
            this.rbSolidoNao.Font = new System.Drawing.Font("BankGothic Md BT", 18.75F);
            this.rbSolidoNao.Location = new System.Drawing.Point(99, 44);
            this.rbSolidoNao.Name = "rbSolidoNao";
            this.rbSolidoNao.Size = new System.Drawing.Size(86, 30);
            this.rbSolidoNao.TabIndex = 21;
            this.rbSolidoNao.TabStop = true;
            this.rbSolidoNao.Text = "Não";
            this.rbSolidoNao.UseVisualStyleBackColor = true;
            // 
            // gbSolido
            // 
            this.gbSolido.Controls.Add(this.rbSolidoSim);
            this.gbSolido.Controls.Add(this.rbSolidoNao);
            this.gbSolido.Controls.Add(this.lblSolido);
            this.gbSolido.Location = new System.Drawing.Point(289, 276);
            this.gbSolido.Name = "gbSolido";
            this.gbSolido.Size = new System.Drawing.Size(254, 78);
            this.gbSolido.TabIndex = 22;
            this.gbSolido.TabStop = false;
            this.gbSolido.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPrecisaReceita);
            this.groupBox2.Controls.Add(this.rbPrecisaReceitaSim);
            this.groupBox2.Controls.Add(this.rbPrecisaReceitaNao);
            this.groupBox2.Location = new System.Drawing.Point(289, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 79);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // Generico
            // 
            this.Generico.AutoSize = true;
            this.Generico.Font = new System.Drawing.Font("BankGothic Md BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generico.Location = new System.Drawing.Point(5, 19);
            this.Generico.Name = "Generico";
            this.Generico.Size = new System.Drawing.Size(135, 25);
            this.Generico.TabIndex = 24;
            this.Generico.Text = "Genérico";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGenericoNao);
            this.groupBox1.Controls.Add(this.rbGenericoSim);
            this.groupBox1.Controls.Add(this.Generico);
            this.groupBox1.Location = new System.Drawing.Point(289, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 83);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // rbGenericoNao
            // 
            this.rbGenericoNao.AutoSize = true;
            this.rbGenericoNao.Font = new System.Drawing.Font("BankGothic Md BT", 18.75F);
            this.rbGenericoNao.Location = new System.Drawing.Point(92, 47);
            this.rbGenericoNao.Name = "rbGenericoNao";
            this.rbGenericoNao.Size = new System.Drawing.Size(86, 30);
            this.rbGenericoNao.TabIndex = 26;
            this.rbGenericoNao.TabStop = true;
            this.rbGenericoNao.Text = "Não";
            this.rbGenericoNao.UseVisualStyleBackColor = true;
            // 
            // rbGenericoSim
            // 
            this.rbGenericoSim.AutoSize = true;
            this.rbGenericoSim.Font = new System.Drawing.Font("BankGothic Md BT", 18.75F);
            this.rbGenericoSim.Location = new System.Drawing.Point(10, 47);
            this.rbGenericoSim.Name = "rbGenericoSim";
            this.rbGenericoSim.Size = new System.Drawing.Size(76, 30);
            this.rbGenericoSim.TabIndex = 26;
            this.rbGenericoSim.TabStop = true;
            this.rbGenericoSim.Text = "Sim";
            this.rbGenericoSim.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(17, 37);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(254, 20);
            this.txtCodigo.TabIndex = 43;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("BankGothic Md BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(12, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(106, 25);
            this.lblCodigo.TabIndex = 42;
            this.lblCodigo.Text = "Código";
            // 
            // CadastroRemedios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 437);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbSolido);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbFaixa);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblFaixa);
            this.Controls.Add(this.txtBula);
            this.Controls.Add(this.lblBula);
            this.Controls.Add(this.txtContraIndicacoes);
            this.Controls.Add(this.lblContraIndicacoes);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "CadastroRemedios";
            this.Text = "CadastroRemedios";
            this.Load += new System.EventHandler(this.CadastroRemedios_Load);
            this.gbSolido.ResumeLayout(false);
            this.gbSolido.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblSolido;
        private System.Windows.Forms.Label lblContraIndicacoes;
        private System.Windows.Forms.TextBox txtContraIndicacoes;
        private System.Windows.Forms.Label lblBula;
        private System.Windows.Forms.TextBox txtBula;
        private System.Windows.Forms.Label lblFaixa;
        private System.Windows.Forms.Label lblPrecisaReceita;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.RadioButton rbPrecisaReceitaSim;
        private System.Windows.Forms.RadioButton rbPrecisaReceitaNao;
        private System.Windows.Forms.ComboBox cbFaixa;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.RadioButton rbSolidoSim;
        private System.Windows.Forms.RadioButton rbSolidoNao;
        private System.Windows.Forms.GroupBox gbSolido;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Generico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbGenericoNao;
        private System.Windows.Forms.RadioButton rbGenericoSim;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
    }
}