namespace CadastroDeProdutos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNomeProduto = new Label();
            lblCodigo = new Label();
            label3 = new Label();
            label4 = new Label();
            CadastroNome = new TextBox();
            numericCodigo = new NumericUpDown();
            numericPreco = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnDeletar = new Button();
            btnLimpar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericCodigo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPreco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Location = new Point(225, 137);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(133, 20);
            lblNomeProduto.TabIndex = 0;
            lblNomeProduto.Text = "Nome do produto:";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(225, 216);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(117, 20);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Digite o codigo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 272);
            label3.Name = "label3";
            label3.Size = new Size(188, 20);
            label3.TabIndex = 2;
            label3.Text = "Digite o preço do produto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(197, 319);
            label4.Name = "label4";
            label4.Size = new Size(145, 20);
            label4.TabIndex = 3;
            label4.Text = "Digite a quantidade:";
            // 
            // CadastroNome
            // 
            CadastroNome.Location = new Point(364, 137);
            CadastroNome.Name = "CadastroNome";
            CadastroNome.Size = new Size(307, 27);
            CadastroNome.TabIndex = 4;
            // 
            // numericCodigo
            // 
            numericCodigo.Location = new Point(348, 209);
            numericCodigo.Name = "numericCodigo";
            numericCodigo.Size = new Size(92, 27);
            numericCodigo.TabIndex = 5;
            // 
            // numericPreco
            // 
            numericPreco.DecimalPlaces = 2;
            numericPreco.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericPreco.Location = new Point(348, 272);
            numericPreco.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numericPreco.Name = "numericPreco";
            numericPreco.Size = new Size(92, 27);
            numericPreco.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown1.Location = new Point(348, 319);
            numericUpDown1.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(92, 27);
            numericUpDown1.TabIndex = 7;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(225, 478);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(325, 478);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(425, 478);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(94, 29);
            btnDeletar.TabIndex = 10;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(525, 478);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 29);
            btnLimpar.TabIndex = 11;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(btnLimpar);
            Controls.Add(btnDeletar);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(numericUpDown1);
            Controls.Add(numericPreco);
            Controls.Add(numericCodigo);
            Controls.Add(CadastroNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblCodigo);
            Controls.Add(lblNomeProduto);
            Name = "Form1";
            Text = "Cadastro De Produtos";
            ((System.ComponentModel.ISupportInitialize)numericCodigo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPreco).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeProduto;
        private Label lblCodigo;
        private Label label3;
        private Label label4;
        private TextBox CadastroNome;
        private NumericUpDown numericCodigo;
        private NumericUpDown numericPreco;
        private NumericUpDown numericUpDown1;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnDeletar;
        private Button btnLimpar;
    }
}
