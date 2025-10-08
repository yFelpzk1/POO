namespace Exercicio8
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnCalcular = new Button();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            txtDataLancamento = new TextBox();
            txtPreco = new TextBox();
            txtPolegadas = new TextBox();
            chkLcd = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 38);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Marca:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 86);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Modelo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 260);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 2;
            label3.Text = "LCD:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 138);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 3;
            label4.Text = "Data de lançamento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 322);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 4;
            label5.Text = "Polegadas:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 199);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 5;
            label6.Text = "Preço de custo:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(42, 389);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(116, 46);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(91, 30);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(128, 23);
            txtMarca.TabIndex = 7;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(99, 78);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(128, 23);
            txtModelo.TabIndex = 8;
            // 
            // txtDataLancamento
            // 
            txtDataLancamento.Location = new Point(164, 130);
            txtDataLancamento.Name = "txtDataLancamento";
            txtDataLancamento.Size = new Size(128, 23);
            txtDataLancamento.TabIndex = 9;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(136, 191);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(128, 23);
            txtPreco.TabIndex = 10;
            // 
            // txtPolegadas
            // 
            txtPolegadas.Location = new Point(112, 314);
            txtPolegadas.Name = "txtPolegadas";
            txtPolegadas.Size = new Size(128, 23);
            txtPolegadas.TabIndex = 12;
            // 
            // chkLcd
            // 
            chkLcd.AutoSize = true;
            chkLcd.Location = new Point(80, 261);
            chkLcd.Name = "chkLcd";
            chkLcd.Size = new Size(15, 14);
            chkLcd.TabIndex = 13;
            chkLcd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 498);
            Controls.Add(chkLcd);
            Controls.Add(txtPolegadas);
            Controls.Add(txtPreco);
            Controls.Add(txtDataLancamento);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(btnCalcular);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Televisão";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnCalcular;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private TextBox txtDataLancamento;
        private TextBox txtPreco;
        private TextBox txtPolegadas;
        private CheckBox chkLcd;
    }
}
