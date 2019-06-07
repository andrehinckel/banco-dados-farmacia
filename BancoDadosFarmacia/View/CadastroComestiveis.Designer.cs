namespace View
{
    partial class CadastroComestiveis
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
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblDataVencimento = new System.Windows.Forms.Label();
            this.dtpDataVencimento = new System.Windows.Forms.DateTimePicker();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(17, 315);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(243, 20);
            this.txtMarca.TabIndex = 23;
            this.txtMarca.Leave += new System.EventHandler(this.txtMarca_Leave);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("BankGothic Md BT", 18.25F);
            this.lblMarca.Location = new System.Drawing.Point(12, 285);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(99, 26);
            this.lblMarca.TabIndex = 22;
            this.lblMarca.Text = "Marca";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(17, 262);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(243, 20);
            this.txtQuantidade.TabIndex = 21;
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("BankGothic Md BT", 18.25F);
            this.lblQuantidade.Location = new System.Drawing.Point(12, 232);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(172, 26);
            this.lblQuantidade.TabIndex = 20;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblDataVencimento
            // 
            this.lblDataVencimento.AutoSize = true;
            this.lblDataVencimento.Font = new System.Drawing.Font("BankGothic Md BT", 18.25F);
            this.lblDataVencimento.Location = new System.Drawing.Point(12, 167);
            this.lblDataVencimento.Name = "lblDataVencimento";
            this.lblDataVencimento.Size = new System.Drawing.Size(248, 26);
            this.lblDataVencimento.TabIndex = 19;
            this.lblDataVencimento.Text = "Data Vencimento";
            // 
            // dtpDataVencimento
            // 
            this.dtpDataVencimento.Font = new System.Drawing.Font("BankGothic Md BT", 18.25F);
            this.dtpDataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVencimento.Location = new System.Drawing.Point(17, 196);
            this.dtpDataVencimento.Name = "dtpDataVencimento";
            this.dtpDataVencimento.Size = new System.Drawing.Size(243, 33);
            this.dtpDataVencimento.TabIndex = 18;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(17, 144);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(243, 20);
            this.txtValor.TabIndex = 17;
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("BankGothic Md BT", 18.25F);
            this.lblValor.Location = new System.Drawing.Point(12, 114);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(93, 26);
            this.lblValor.TabIndex = 16;
            this.lblValor.Text = "Valor";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(17, 91);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(243, 20);
            this.txtNome.TabIndex = 15;
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("BankGothic Md BT", 18.25F);
            this.lblNome.Location = new System.Drawing.Point(12, 61);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(86, 26);
            this.lblNome.TabIndex = 14;
            this.lblNome.Text = "Nome";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("BankGothic Md BT", 18.5F);
            this.btnSalvar.Location = new System.Drawing.Point(64, 341);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 68);
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(17, 38);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(243, 20);
            this.txtCodigo.TabIndex = 28;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("BankGothic Md BT", 18.25F);
            this.lblCodigo.Location = new System.Drawing.Point(12, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(109, 26);
            this.lblCodigo.TabIndex = 27;
            this.lblCodigo.Text = "Código";
            // 
            // CadastroComestiveis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 420);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblDataVencimento);
            this.Controls.Add(this.dtpDataVencimento);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "CadastroComestiveis";
            this.Text = "CadastroComestiveis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblDataVencimento;
        private System.Windows.Forms.DateTimePicker dtpDataVencimento;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
    }
}