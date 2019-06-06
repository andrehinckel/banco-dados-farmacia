namespace View
{
    partial class TabelaCadastroRemedios
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGenerico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSolido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContraIndicacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecisaReceita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnNome,
            this.ColumnGenerico,
            this.ColumnCategoria,
            this.ColumnSolido,
            this.ColumnContraIndicacoes,
            this.ColumnBula,
            this.ColumnFaixa,
            this.ColumnPrecisaReceita});
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(943, 498);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("BankGothic Md BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(768, 12);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(187, 51);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("BankGothic Md BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(575, 12);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(187, 51);
            this.btnApagar.TabIndex = 2;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Código";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnGenerico
            // 
            this.ColumnGenerico.HeaderText = "Genérico";
            this.ColumnGenerico.Name = "ColumnGenerico";
            this.ColumnGenerico.ReadOnly = true;
            // 
            // ColumnCategoria
            // 
            this.ColumnCategoria.HeaderText = "Categoria";
            this.ColumnCategoria.Name = "ColumnCategoria";
            this.ColumnCategoria.ReadOnly = true;
            // 
            // ColumnSolido
            // 
            this.ColumnSolido.HeaderText = "Sólido";
            this.ColumnSolido.Name = "ColumnSolido";
            this.ColumnSolido.ReadOnly = true;
            // 
            // ColumnContraIndicacoes
            // 
            this.ColumnContraIndicacoes.HeaderText = "Contra Indicações";
            this.ColumnContraIndicacoes.Name = "ColumnContraIndicacoes";
            this.ColumnContraIndicacoes.ReadOnly = true;
            // 
            // ColumnBula
            // 
            this.ColumnBula.HeaderText = "Bula";
            this.ColumnBula.Name = "ColumnBula";
            this.ColumnBula.ReadOnly = true;
            // 
            // ColumnFaixa
            // 
            this.ColumnFaixa.HeaderText = "Faixa";
            this.ColumnFaixa.Name = "ColumnFaixa";
            this.ColumnFaixa.ReadOnly = true;
            // 
            // ColumnPrecisaReceita
            // 
            this.ColumnPrecisaReceita.HeaderText = "Precisa Receita";
            this.ColumnPrecisaReceita.Name = "ColumnPrecisaReceita";
            this.ColumnPrecisaReceita.ReadOnly = true;
            // 
            // TabelaCadastroRemedios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 579);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TabelaCadastroRemedios";
            this.Text = "TabelaCadastroRemedios";
            this.Activated += new System.EventHandler(this.TabelaCadastroRemedios_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGenerico;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSolido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContraIndicacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecisaReceita;
    }
}