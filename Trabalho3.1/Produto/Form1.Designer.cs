namespace Produto
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
            tabControl1 = new TabControl();
            tbProduto = new TabPage();
            btnSair = new Button();
            btnLimpar = new Button();
            btnCadastrar = new Button();
            label3 = new Label();
            label2 = new Label();
            txtQuantidade = new TextBox();
            txtPreco = new TextBox();
            txtNome = new TextBox();
            label1 = new Label();
            tbImprimir = new TabPage();
            dgvImprimir = new DataGridView();
            btnImprimir = new Button();
            tbExcluir = new TabPage();
            txtExcluir = new TextBox();
            btnExcluir = new Button();
            Nome = new DataGridViewTextBoxColumn();
            Preço = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tbProduto.SuspendLayout();
            tbImprimir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvImprimir).BeginInit();
            tbExcluir.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbProduto);
            tabControl1.Controls.Add(tbImprimir);
            tabControl1.Controls.Add(tbExcluir);
            tabControl1.Location = new Point(40, 40);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(730, 414);
            tabControl1.TabIndex = 0;
            // 
            // tbProduto
            // 
            tbProduto.Controls.Add(btnSair);
            tbProduto.Controls.Add(btnLimpar);
            tbProduto.Controls.Add(btnCadastrar);
            tbProduto.Controls.Add(label3);
            tbProduto.Controls.Add(label2);
            tbProduto.Controls.Add(txtQuantidade);
            tbProduto.Controls.Add(txtPreco);
            tbProduto.Controls.Add(txtNome);
            tbProduto.Controls.Add(label1);
            tbProduto.Location = new Point(4, 24);
            tbProduto.Name = "tbProduto";
            tbProduto.Padding = new Padding(3);
            tbProduto.Size = new Size(722, 386);
            tbProduto.TabIndex = 0;
            tbProduto.Text = "Produto";
            tbProduto.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(294, 302);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(133, 67);
            btnSair.TabIndex = 8;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(26, 302);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(137, 67);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar Lista";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(558, 302);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(137, 67);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 131);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 5;
            label3.Text = "Quantidade:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 77);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Preço:";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(138, 123);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 23);
            txtQuantidade.TabIndex = 3;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(138, 69);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(138, 22);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(170, 23);
            txtNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 30);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do produto:";
            // 
            // tbImprimir
            // 
            tbImprimir.Controls.Add(dgvImprimir);
            tbImprimir.Controls.Add(btnImprimir);
            tbImprimir.Location = new Point(4, 24);
            tbImprimir.Name = "tbImprimir";
            tbImprimir.Padding = new Padding(3);
            tbImprimir.Size = new Size(722, 386);
            tbImprimir.TabIndex = 1;
            tbImprimir.Text = "Impressão";
            tbImprimir.UseVisualStyleBackColor = true;
            // 
            // dgvImprimir
            // 
            dgvImprimir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImprimir.Columns.AddRange(new DataGridViewColumn[] { Nome, Preço, Quantidade, Total });
            dgvImprimir.Location = new Point(26, 16);
            dgvImprimir.Name = "dgvImprimir";
            dgvImprimir.Size = new Size(560, 351);
            dgvImprimir.TabIndex = 1;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(592, 306);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(103, 61);
            btnImprimir.TabIndex = 0;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // tbExcluir
            // 
            tbExcluir.Controls.Add(txtExcluir);
            tbExcluir.Controls.Add(btnExcluir);
            tbExcluir.Location = new Point(4, 24);
            tbExcluir.Name = "tbExcluir";
            tbExcluir.Padding = new Padding(3);
            tbExcluir.Size = new Size(722, 386);
            tbExcluir.TabIndex = 2;
            tbExcluir.Text = "Excluir Produto";
            tbExcluir.UseVisualStyleBackColor = true;
            // 
            // txtExcluir
            // 
            txtExcluir.Location = new Point(30, 33);
            txtExcluir.Name = "txtExcluir";
            txtExcluir.Size = new Size(238, 23);
            txtExcluir.TabIndex = 1;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(290, 9);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(115, 47);
            btnExcluir.TabIndex = 0;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // Preço
            // 
            Preço.HeaderText = "Preço";
            Preço.Name = "Preço";
            // 
            // Quantidade
            // 
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 498);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tbProduto.ResumeLayout(false);
            tbProduto.PerformLayout();
            tbImprimir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvImprimir).EndInit();
            tbExcluir.ResumeLayout(false);
            tbExcluir.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tbProduto;
        private Label label3;
        private Label label2;
        private TextBox txtQuantidade;
        private TextBox txtPreco;
        private TextBox txtNome;
        private Label label1;
        private TabPage tbImprimir;
        private Button btnLimpar;
        private Button btnCadastrar;
        private DataGridView dgvImprimir;
        private Button btnImprimir;
        private TabPage tbExcluir;
        private Button btnExcluir;
        private TextBox txtExcluir;
        private Button btnSair;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Preço;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Total;
    }
}
