namespace Exercicio
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
            label3 = new Label();
            txtNome = new TextBox();
            txtSalarioBase = new TextBox();
            cboCargo = new ComboBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnCadastrar = new Button();
            tabPage2 = new TabPage();
            btnImprimirDGV = new Button();
            btnImprimir = new Button();
            dgvListagem = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListagem).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 57);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 122);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Cargo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 196);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Salario Base:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(91, 49);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(164, 23);
            txtNome.TabIndex = 3;
            // 
            // txtSalarioBase
            // 
            txtSalarioBase.Location = new Point(119, 188);
            txtSalarioBase.Name = "txtSalarioBase";
            txtSalarioBase.Size = new Size(164, 23);
            txtSalarioBase.TabIndex = 4;
            // 
            // cboCargo
            // 
            cboCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCargo.FormattingEnabled = true;
            cboCargo.Items.AddRange(new object[] { "Programador", "Designer", "Gerente" });
            cboCargo.Location = new Point(91, 114);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(133, 23);
            cboCargo.TabIndex = 5;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(34, 26);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(732, 412);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnCadastrar);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Controls.Add(txtSalarioBase);
            tabPage1.Controls.Add(cboCargo);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(724, 384);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastrar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(576, 299);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(110, 64);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnImprimirDGV);
            tabPage2.Controls.Add(btnImprimir);
            tabPage2.Controls.Add(dgvListagem);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(724, 384);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Listar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnImprimirDGV
            // 
            btnImprimirDGV.Location = new Point(600, 202);
            btnImprimirDGV.Name = "btnImprimirDGV";
            btnImprimirDGV.Size = new Size(107, 105);
            btnImprimirDGV.TabIndex = 2;
            btnImprimirDGV.Text = "Imprimir em dgv";
            btnImprimirDGV.UseVisualStyleBackColor = true;
            btnImprimirDGV.Click += btnImprimirDGV_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(600, 35);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(107, 105);
            btnImprimir.TabIndex = 1;
            btnImprimir.Text = "Imprimir em Message";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // dgvListagem
            // 
            dgvListagem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListagem.Location = new Point(42, 35);
            dgvListagem.Name = "dgvListagem";
            dgvListagem.Size = new Size(540, 318);
            dgvListagem.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Folha de Pagamento";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListagem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtSalarioBase;
        private ComboBox cboCargo;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnCadastrar;
        private TabPage tabPage2;
        private Button btnImprimir;
        private DataGridView dgvListagem;
        private Button btnImprimirDGV;
    }
}
