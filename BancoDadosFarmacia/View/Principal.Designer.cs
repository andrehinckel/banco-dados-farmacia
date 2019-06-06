namespace View
{
    partial class Principal
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
            this.btnCadastroComestiveis = new System.Windows.Forms.Button();
            this.btnCadastroProdutosHigienicos = new System.Windows.Forms.Button();
            this.btnRemedios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastroComestiveis
            // 
            this.btnCadastroComestiveis.Font = new System.Drawing.Font("BankGothic Md BT", 30.25F);
            this.btnCadastroComestiveis.Location = new System.Drawing.Point(182, 221);
            this.btnCadastroComestiveis.Name = "btnCadastroComestiveis";
            this.btnCadastroComestiveis.Size = new System.Drawing.Size(322, 203);
            this.btnCadastroComestiveis.TabIndex = 0;
            this.btnCadastroComestiveis.Text = "Cadastro Comestiveis";
            this.btnCadastroComestiveis.UseVisualStyleBackColor = true;
            this.btnCadastroComestiveis.Click += new System.EventHandler(this.btnCadastroComestiveis_Click);
            // 
            // btnCadastroProdutosHigienicos
            // 
            this.btnCadastroProdutosHigienicos.Font = new System.Drawing.Font("BankGothic Md BT", 30.25F);
            this.btnCadastroProdutosHigienicos.Location = new System.Drawing.Point(350, 12);
            this.btnCadastroProdutosHigienicos.Name = "btnCadastroProdutosHigienicos";
            this.btnCadastroProdutosHigienicos.Size = new System.Drawing.Size(322, 203);
            this.btnCadastroProdutosHigienicos.TabIndex = 1;
            this.btnCadastroProdutosHigienicos.Text = "Cadastro Produtos Higiênicos";
            this.btnCadastroProdutosHigienicos.UseVisualStyleBackColor = true;
            this.btnCadastroProdutosHigienicos.Click += new System.EventHandler(this.btnCadastroProdutosHigienicos_Click);
            // 
            // btnRemedios
            // 
            this.btnRemedios.Font = new System.Drawing.Font("BankGothic Md BT", 30.25F);
            this.btnRemedios.Location = new System.Drawing.Point(12, 12);
            this.btnRemedios.Name = "btnRemedios";
            this.btnRemedios.Size = new System.Drawing.Size(322, 203);
            this.btnRemedios.TabIndex = 2;
            this.btnRemedios.Text = "Cadastro Remédios";
            this.btnRemedios.UseVisualStyleBackColor = true;
            this.btnRemedios.Click += new System.EventHandler(this.btnRemedios_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 433);
            this.Controls.Add(this.btnRemedios);
            this.Controls.Add(this.btnCadastroProdutosHigienicos);
            this.Controls.Add(this.btnCadastroComestiveis);
            this.Name = "Principal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroComestiveis;
        private System.Windows.Forms.Button btnCadastroProdutosHigienicos;
        private System.Windows.Forms.Button btnRemedios;
    }
}

