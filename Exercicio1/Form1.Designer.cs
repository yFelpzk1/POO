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
            txtNomeCachorro = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPesoCachorro = new TextBox();
            txtRacaCachorro = new TextBox();
            btnCadastrar = new Button();
            btnImprimir = new Button();
            txtHabitat = new TextBox();
            txtPesoPeixe = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtNomePeixe = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnCadastrarPeixe = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 109);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txtNomeCachorro
            // 
            txtNomeCachorro.Location = new Point(105, 101);
            txtNomeCachorro.Name = "txtNomeCachorro";
            txtNomeCachorro.Size = new Size(188, 23);
            txtNomeCachorro.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 164);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 2;
            label2.Text = "Peso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 228);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 3;
            label3.Text = "Raça:";
            // 
            // txtPesoCachorro
            // 
            txtPesoCachorro.Location = new Point(105, 156);
            txtPesoCachorro.Name = "txtPesoCachorro";
            txtPesoCachorro.Size = new Size(188, 23);
            txtPesoCachorro.TabIndex = 4;
            // 
            // txtRacaCachorro
            // 
            txtRacaCachorro.Location = new Point(105, 220);
            txtRacaCachorro.Name = "txtRacaCachorro";
            txtRacaCachorro.Size = new Size(188, 23);
            txtRacaCachorro.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(115, 283);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(129, 51);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(281, 376);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(139, 62);
            btnImprimir.TabIndex = 7;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // txtHabitat
            // 
            txtHabitat.Location = new Point(472, 228);
            txtHabitat.Name = "txtHabitat";
            txtHabitat.Size = new Size(188, 23);
            txtHabitat.TabIndex = 13;
            // 
            // txtPesoPeixe
            // 
            txtPesoPeixe.Location = new Point(472, 164);
            txtPesoPeixe.Name = "txtPesoPeixe";
            txtPesoPeixe.Size = new Size(188, 23);
            txtPesoPeixe.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(409, 236);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 11;
            label4.Text = "Hibatat:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(423, 172);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 10;
            label5.Text = "Peso:";
            // 
            // txtNomePeixe
            // 
            txtNomePeixe.Location = new Point(472, 109);
            txtNomePeixe.Name = "txtNomePeixe";
            txtNomePeixe.Size = new Size(188, 23);
            txtNomePeixe.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(423, 117);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 8;
            label6.Text = "Nome:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(530, 49);
            label7.Name = "label7";
            label7.Size = new Size(45, 21);
            label7.TabIndex = 14;
            label7.Text = "Peixe";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(144, 49);
            label8.Name = "label8";
            label8.Size = new Size(74, 21);
            label8.TabIndex = 15;
            label8.Text = "Cachorro";
            // 
            // btnCadastrarPeixe
            // 
            btnCadastrarPeixe.Location = new Point(497, 283);
            btnCadastrarPeixe.Name = "btnCadastrarPeixe";
            btnCadastrarPeixe.Size = new Size(129, 51);
            btnCadastrarPeixe.TabIndex = 16;
            btnCadastrarPeixe.Text = "Cadastrar";
            btnCadastrarPeixe.UseVisualStyleBackColor = true;
            btnCadastrarPeixe.Click += btnCadastrarPeixe_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 450);
            Controls.Add(btnCadastrarPeixe);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtHabitat);
            Controls.Add(txtPesoPeixe);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtNomePeixe);
            Controls.Add(label6);
            Controls.Add(btnImprimir);
            Controls.Add(btnCadastrar);
            Controls.Add(txtRacaCachorro);
            Controls.Add(txtPesoCachorro);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNomeCachorro);
            Controls.Add(label1);
            Name = "Form1";
            Text = "PetShop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNomeCachorro;
        private Label label2;
        private Label label3;
        private TextBox txtPesoCachorro;
        private TextBox txtRacaCachorro;
        private Button btnCadastrar;
        private Button btnImprimir;
        private TextBox txtHabitat;
        private TextBox txtPesoPeixe;
        private Label label4;
        private Label label5;
        private TextBox txtNomePeixe;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnCadastrarPeixe;
    }
}
