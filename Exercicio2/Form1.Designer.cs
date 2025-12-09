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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtPrecoBase = new TextBox();
            cboTipo = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTamanho = new TextBox();
            txtTipoCarne = new TextBox();
            txtVolume = new TextBox();
            btnCadastrar = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            btnImprimir = new Button();
            btnCadastrarM = new Button();
            dgvImprimir = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvImprimir).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 43);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 96);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Preço:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 156);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "Tipo:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(79, 35);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(150, 23);
            txtNome.TabIndex = 3;
            // 
            // txtPrecoBase
            // 
            txtPrecoBase.Location = new Point(76, 88);
            txtPrecoBase.Name = "txtPrecoBase";
            txtPrecoBase.Size = new Size(150, 23);
            txtPrecoBase.TabIndex = 4;
            // 
            // cboTipo
            // 
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Pizza", "Hamburguer", "Bebida" });
            cboTipo.Location = new Point(79, 148);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(150, 23);
            cboTipo.TabIndex = 5;
            cboTipo.SelectedIndexChanged += cboTipo_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 220);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 6;
            label4.Text = "Tamanho:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 280);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 7;
            label5.Text = "Tipo Carne:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 336);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 8;
            label6.Text = "Volume:";
            // 
            // txtTamanho
            // 
            txtTamanho.Location = new Point(96, 212);
            txtTamanho.Name = "txtTamanho";
            txtTamanho.Size = new Size(133, 23);
            txtTamanho.TabIndex = 9;
            // 
            // txtTipoCarne
            // 
            txtTipoCarne.Location = new Point(104, 272);
            txtTipoCarne.Name = "txtTipoCarne";
            txtTipoCarne.Size = new Size(145, 23);
            txtTipoCarne.TabIndex = 10;
            // 
            // txtVolume
            // 
            txtVolume.Location = new Point(86, 328);
            txtVolume.Name = "txtVolume";
            txtVolume.Size = new Size(140, 23);
            txtVolume.TabIndex = 11;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(410, 289);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(128, 62);
            btnCadastrar.TabIndex = 12;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(726, 408);
            tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnCadastrar);
            tabPage1.Controls.Add(txtVolume);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Controls.Add(txtTipoCarne);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtTamanho);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txtPrecoBase);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(cboTipo);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(718, 380);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvImprimir);
            tabPage2.Controls.Add(btnCadastrarM);
            tabPage2.Controls.Add(btnImprimir);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(718, 380);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Impressão";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(584, 37);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(99, 79);
            btnImprimir.TabIndex = 0;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnCadastrarM
            // 
            btnCadastrarM.Location = new Point(584, 251);
            btnCadastrarM.Name = "btnCadastrarM";
            btnCadastrarM.Size = new Size(99, 79);
            btnCadastrarM.TabIndex = 1;
            btnCadastrarM.Text = "Imprimir Message Box";
            btnCadastrarM.UseVisualStyleBackColor = true;
            btnCadastrarM.Click += btnCadastrarM_Click;
            // 
            // dgvImprimir
            // 
            dgvImprimir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImprimir.Location = new Point(24, 19);
            dgvImprimir.Name = "dgvImprimir";
            dgvImprimir.Size = new Size(544, 342);
            dgvImprimir.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Delivery";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvImprimir).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtPrecoBase;
        private ComboBox cboTipo;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtTamanho;
        private TextBox txtTipoCarne;
        private TextBox txtVolume;
        private Button btnCadastrar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvImprimir;
        private Button btnCadastrarM;
        private Button btnImprimir;
    }
}
