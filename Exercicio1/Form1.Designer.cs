namespace Exercicio1
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
            label1 = new Label();
            label2 = new Label();
            cboTipoMidia = new ComboBox();
            label3 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnCadastrar = new Button();
            txtApresentador = new TextBox();
            txtArtista = new TextBox();
            txtDuracao = new TextBox();
            txtTitulo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            tabPage2 = new TabPage();
            btnExibirM = new Button();
            btnExibir = new Button();
            dgvExibir = new DataGridView();
            tabPage3 = new TabPage();
            btnRemover = new Button();
            txtRemover = new TextBox();
            label6 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExibir).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 25);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Titulo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 136);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 1;
            label2.Text = "Tipo de Midia:";
            // 
            // cboTipoMidia
            // 
            cboTipoMidia.AutoCompleteCustomSource.AddRange(new string[] { "Musica", "Podcast" });
            cboTipoMidia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoMidia.FormattingEnabled = true;
            cboTipoMidia.Items.AddRange(new object[] { "Musica", "Podcast" });
            cboTipoMidia.Location = new Point(121, 133);
            cboTipoMidia.Name = "cboTipoMidia";
            cboTipoMidia.Size = new Size(151, 23);
            cboTipoMidia.TabIndex = 2;
            cboTipoMidia.SelectedIndexChanged += cboTipoMidia_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 75);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 3;
            label3.Text = "Duração:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(41, 31);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(706, 394);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnCadastrar);
            tabPage1.Controls.Add(txtApresentador);
            tabPage1.Controls.Add(txtArtista);
            tabPage1.Controls.Add(txtDuracao);
            tabPage1.Controls.Add(txtTitulo);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(cboTipoMidia);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(698, 366);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(537, 280);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(135, 65);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtApresentador
            // 
            txtApresentador.Location = new Point(121, 238);
            txtApresentador.Name = "txtApresentador";
            txtApresentador.Size = new Size(164, 23);
            txtApresentador.TabIndex = 9;
            // 
            // txtArtista
            // 
            txtArtista.Location = new Point(85, 182);
            txtArtista.Name = "txtArtista";
            txtArtista.Size = new Size(164, 23);
            txtArtista.TabIndex = 8;
            // 
            // txtDuracao
            // 
            txtDuracao.Location = new Point(95, 67);
            txtDuracao.Name = "txtDuracao";
            txtDuracao.Size = new Size(164, 23);
            txtDuracao.TabIndex = 7;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(79, 17);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(228, 23);
            txtTitulo.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 246);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 5;
            label5.Text = "Apresentador:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 190);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 4;
            label4.Text = "Artista:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnExibirM);
            tabPage2.Controls.Add(btnExibir);
            tabPage2.Controls.Add(dgvExibir);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(698, 366);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Listar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExibirM
            // 
            btnExibirM.Location = new Point(591, 180);
            btnExibirM.Name = "btnExibirM";
            btnExibirM.Size = new Size(89, 110);
            btnExibirM.TabIndex = 2;
            btnExibirM.Text = "Exibir MessageBox";
            btnExibirM.UseVisualStyleBackColor = true;
            btnExibirM.Click += btnExibirM_Click;
            // 
            // btnExibir
            // 
            btnExibir.Location = new Point(591, 20);
            btnExibir.Name = "btnExibir";
            btnExibir.Size = new Size(89, 110);
            btnExibir.TabIndex = 1;
            btnExibir.Text = "Exibir";
            btnExibir.UseVisualStyleBackColor = true;
            btnExibir.Click += btnExibir_Click;
            // 
            // dgvExibir
            // 
            dgvExibir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExibir.Location = new Point(23, 20);
            dgvExibir.Name = "dgvExibir";
            dgvExibir.Size = new Size(550, 328);
            dgvExibir.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnRemover);
            tabPage3.Controls.Add(txtRemover);
            tabPage3.Controls.Add(label6);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(698, 366);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Remoção";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(531, 20);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(137, 105);
            btnRemover.TabIndex = 2;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // txtRemover
            // 
            txtRemover.Location = new Point(204, 20);
            txtRemover.Name = "txtRemover";
            txtRemover.Size = new Size(178, 23);
            txtRemover.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 28);
            label6.Name = "label6";
            label6.Size = new Size(175, 15);
            label6.TabIndex = 0;
            label6.Text = "Digite o titulo que seja remover:";
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
            ((System.ComponentModel.ISupportInitialize)dgvExibir).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cboTipoMidia;
        private Label label3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox txtApresentador;
        private TextBox txtArtista;
        private TextBox txtDuracao;
        private TextBox txtTitulo;
        private Label label5;
        private Label label4;
        private TabPage tabPage2;
        private Button btnCadastrar;
        private Button btnExibir;
        private DataGridView dgvExibir;
        private TabPage tabPage3;
        private Button btnRemover;
        private TextBox txtRemover;
        private Label label6;
        private Button btnExibirM;
    }
}
