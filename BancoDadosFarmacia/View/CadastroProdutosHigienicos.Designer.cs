namespace View
{
    partial class CadastroProdutosHigienicos
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
            this.lblPreco = new System.Windows.Forms.Label();
            this.mtbPreco = new System.Windows.Forms.MaskedTextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("BankGothic Md BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(83, 25);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(17, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("BankGothic Md BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(12, 61);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(93, 25);
            this.lblPreco.TabIndex = 2;
            this.lblPreco.Text = "Preço";
            // 
            // mtbPreco
            // 
            this.mtbPreco.Location = new System.Drawing.Point(17, 89);
            this.mtbPreco.Mask = "$00000,00";
            this.mtbPreco.Name = "mtbPreco";
            this.mtbPreco.Size = new System.Drawing.Size(100, 20);
            this.mtbPreco.TabIndex = 3;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("BankGothic Md BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(12, 112);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(149, 25);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoria";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Sabonete",
            "Perfume",
            "Shampoo",
            "Cotonete"});
            this.cbCategoria.Location = new System.Drawing.Point(17, 141);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(144, 21);
            this.cbCategoria.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("BankGothic Md BT", 18F);
            this.btnSalvar.Location = new System.Drawing.Point(26, 168);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(123, 36);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // CadastroProdutosHigienicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 215);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.mtbPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "CadastroProdutosHigienicos";
            this.Text = "CadastroProdutosHigienicos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.MaskedTextBox mtbPreco;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btnSalvar;
    }
}