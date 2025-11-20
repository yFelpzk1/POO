namespace Exercicio2
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
            label3 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnSair = new Button();
            btnCadastrar = new Button();
            txtQtdEstoque = new TextBox();
            txtPreco = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            btnSair1 = new Button();
            btnListar = new Button();
            dgvEstoque = new DataGridView();
            tabPage3 = new TabPage();
            btnSair2 = new Button();
            btnVender = new Button();
            txtQtdVenda = new TextBox();
            txtNomeVenda = new TextBox();
            label5 = new Label();
            label4 = new Label();
            tabPage4 = new TabPage();
            dgvProcurar = new DataGridView();
            btnSair3 = new Button();
            btnProcurar = new Button();
            txtProcurar = new TextBox();
            label6 = new Label();
            tabPage5 = new TabPage();
            btnSair4 = new Button();
            btnExcluir = new Button();
            txtExcluir = new TextBox();
            label7 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProcurar).BeginInit();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 37);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(40, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(690, 376);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnSair);
            tabPage1.Controls.Add(btnCadastrar);
            tabPage1.Controls.Add(txtQtdEstoque);
            tabPage1.Controls.Add(txtPreco);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(682, 348);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(41, 278);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(117, 51);
            btnSair.TabIndex = 9;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(520, 278);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(117, 51);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtQtdEstoque
            // 
            txtQtdEstoque.Location = new Point(164, 187);
            txtQtdEstoque.Name = "txtQtdEstoque";
            txtQtdEstoque.Size = new Size(114, 23);
            txtQtdEstoque.TabIndex = 7;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(87, 105);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(191, 23);
            txtPreco.TabIndex = 6;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(90, 29);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(188, 23);
            txtNome.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 113);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Preço:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 195);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 3;
            label1.Text = "Quantidade Estoque:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnSair1);
            tabPage2.Controls.Add(btnListar);
            tabPage2.Controls.Add(dgvEstoque);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(682, 348);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Estoque";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSair1
            // 
            btnSair1.Location = new Point(590, 136);
            btnSair1.Name = "btnSair1";
            btnSair1.Size = new Size(86, 72);
            btnSair1.TabIndex = 2;
            btnSair1.Text = "Sair";
            btnSair1.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(590, 34);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(86, 72);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // dgvEstoque
            // 
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoque.Location = new Point(33, 34);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.Size = new Size(542, 290);
            dgvEstoque.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnSair2);
            tabPage3.Controls.Add(btnVender);
            tabPage3.Controls.Add(txtQtdVenda);
            tabPage3.Controls.Add(txtNomeVenda);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label4);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(682, 348);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Venda";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSair2
            // 
            btnSair2.Location = new Point(50, 264);
            btnSair2.Name = "btnSair2";
            btnSair2.Size = new Size(124, 62);
            btnSair2.TabIndex = 5;
            btnSair2.Text = "Sair";
            btnSair2.UseVisualStyleBackColor = true;
            // 
            // btnVender
            // 
            btnVender.Location = new Point(530, 264);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(124, 62);
            btnVender.TabIndex = 4;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // txtQtdVenda
            // 
            txtQtdVenda.Location = new Point(128, 109);
            txtQtdVenda.Name = "txtQtdVenda";
            txtQtdVenda.Size = new Size(141, 23);
            txtQtdVenda.TabIndex = 3;
            // 
            // txtNomeVenda
            // 
            txtNomeVenda.Location = new Point(99, 40);
            txtNomeVenda.Name = "txtNomeVenda";
            txtNomeVenda.Size = new Size(170, 23);
            txtNomeVenda.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 117);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 1;
            label5.Text = "Quantidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 48);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 0;
            label4.Text = "Nome:";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dgvProcurar);
            tabPage4.Controls.Add(btnSair3);
            tabPage4.Controls.Add(btnProcurar);
            tabPage4.Controls.Add(txtProcurar);
            tabPage4.Controls.Add(label6);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(682, 348);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Procurar Refrigerante";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvProcurar
            // 
            dgvProcurar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProcurar.Location = new Point(41, 51);
            dgvProcurar.Name = "dgvProcurar";
            dgvProcurar.Size = new Size(487, 277);
            dgvProcurar.TabIndex = 4;
            // 
            // btnSair3
            // 
            btnSair3.Location = new Point(534, 85);
            btnSair3.Name = "btnSair3";
            btnSair3.Size = new Size(123, 35);
            btnSair3.TabIndex = 3;
            btnSair3.Text = "Sair";
            btnSair3.UseVisualStyleBackColor = true;
            // 
            // btnProcurar
            // 
            btnProcurar.Location = new Point(534, 22);
            btnProcurar.Name = "btnProcurar";
            btnProcurar.Size = new Size(123, 35);
            btnProcurar.TabIndex = 2;
            btnProcurar.Text = "Procurar";
            btnProcurar.UseVisualStyleBackColor = true;
            btnProcurar.Click += btnProcurar_Click;
            // 
            // txtProcurar
            // 
            txtProcurar.Location = new Point(102, 22);
            txtProcurar.Name = "txtProcurar";
            txtProcurar.Size = new Size(148, 23);
            txtProcurar.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 25);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 0;
            label6.Text = "Procurar:";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(btnSair4);
            tabPage5.Controls.Add(btnExcluir);
            tabPage5.Controls.Add(txtExcluir);
            tabPage5.Controls.Add(label7);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(682, 348);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Excluir";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnSair4
            // 
            btnSair4.Location = new Point(366, 128);
            btnSair4.Name = "btnSair4";
            btnSair4.Size = new Size(139, 53);
            btnSair4.TabIndex = 3;
            btnSair4.Text = "Sair";
            btnSair4.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(36, 128);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(139, 53);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtExcluir
            // 
            txtExcluir.Location = new Point(253, 30);
            txtExcluir.Name = "txtExcluir";
            txtExcluir.Size = new Size(252, 23);
            txtExcluir.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 38);
            label7.Name = "label7";
            label7.Size = new Size(211, 15);
            label7.TabIndex = 0;
            label7.Text = "Digite o refrigerante que deseja excluir:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProcurar).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnSair;
        private Button btnCadastrar;
        private TextBox txtQtdEstoque;
        private TextBox txtPreco;
        private TextBox txtNome;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Button btnSair1;
        private Button btnListar;
        private DataGridView dgvEstoque;
        private Button btnSair2;
        private Button btnVender;
        private TextBox txtQtdVenda;
        private TextBox txtNomeVenda;
        private Label label5;
        private Label label4;
        private Button btnSair3;
        private Button btnProcurar;
        private TextBox txtProcurar;
        private Label label6;
        private DataGridView dgvProcurar;
        private Label label7;
        private Button btnSair4;
        private Button btnExcluir;
        private TextBox txtExcluir;
    }
}
