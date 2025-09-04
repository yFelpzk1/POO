namespace Exercicio11
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
            txtEntradaA = new TextBox();
            txtEntradaB = new TextBox();
            txtEntradaC = new TextBox();
            btnOrdenar = new Button();
            txtSaida3 = new TextBox();
            txtSaida2 = new TextBox();
            txtSaida1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 36);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 0;
            label1.Text = "A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 92);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 1;
            label2.Text = "B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 146);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 2;
            label3.Text = "C";
            // 
            // txtEntradaA
            // 
            txtEntradaA.Location = new Point(70, 28);
            txtEntradaA.Name = "txtEntradaA";
            txtEntradaA.Size = new Size(100, 23);
            txtEntradaA.TabIndex = 3;
            // 
            // txtEntradaB
            // 
            txtEntradaB.Location = new Point(70, 84);
            txtEntradaB.Name = "txtEntradaB";
            txtEntradaB.Size = new Size(100, 23);
            txtEntradaB.TabIndex = 4;
            // 
            // txtEntradaC
            // 
            txtEntradaC.Location = new Point(70, 138);
            txtEntradaC.Name = "txtEntradaC";
            txtEntradaC.Size = new Size(100, 23);
            txtEntradaC.TabIndex = 5;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(193, 28);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(158, 133);
            btnOrdenar.TabIndex = 6;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // txtSaida3
            // 
            txtSaida3.Enabled = false;
            txtSaida3.Location = new Point(368, 138);
            txtSaida3.Name = "txtSaida3";
            txtSaida3.Size = new Size(100, 23);
            txtSaida3.TabIndex = 7;
            // 
            // txtSaida2
            // 
            txtSaida2.Enabled = false;
            txtSaida2.Location = new Point(368, 84);
            txtSaida2.Name = "txtSaida2";
            txtSaida2.Size = new Size(100, 23);
            txtSaida2.TabIndex = 8;
            // 
            // txtSaida1
            // 
            txtSaida1.Enabled = false;
            txtSaida1.Location = new Point(368, 28);
            txtSaida1.Name = "txtSaida1";
            txtSaida1.Size = new Size(100, 23);
            txtSaida1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSaida1);
            Controls.Add(txtSaida2);
            Controls.Add(txtSaida3);
            Controls.Add(btnOrdenar);
            Controls.Add(txtEntradaC);
            Controls.Add(txtEntradaB);
            Controls.Add(txtEntradaA);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Exercicio 11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEntradaA;
        private TextBox txtEntradaB;
        private TextBox txtEntradaC;
        private Button btnOrdenar;
        private TextBox txtSaida3;
        private TextBox txtSaida2;
        private TextBox txtSaida1;
    }
}
