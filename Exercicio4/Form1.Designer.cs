namespace Exercicio4
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
            txtNumero1 = new TextBox();
            txtNumero4 = new TextBox();
            txtNumero3 = new TextBox();
            txtNumero2 = new TextBox();
            btnCalcular = new Button();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 36);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Número 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 182);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Número 4:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 128);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Número 3:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 80);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 3;
            label4.Text = "Número 2:";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(122, 28);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 4;
            // 
            // txtNumero4
            // 
            txtNumero4.Location = new Point(122, 174);
            txtNumero4.Name = "txtNumero4";
            txtNumero4.Size = new Size(100, 23);
            txtNumero4.TabIndex = 5;
            // 
            // txtNumero3
            // 
            txtNumero3.Location = new Point(122, 120);
            txtNumero3.Name = "txtNumero3";
            txtNumero3.Size = new Size(100, 23);
            txtNumero3.TabIndex = 6;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(122, 72);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 7;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(36, 274);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(95, 49);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Média";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Location = new Point(158, 288);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(120, 23);
            txtResultado.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero3);
            Controls.Add(txtNumero4);
            Controls.Add(txtNumero1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Exercicio4";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNumero1;
        private TextBox txtNumero4;
        private TextBox txtNumero3;
        private TextBox txtNumero2;
        private Button btnCalcular;
        private TextBox txtResultado;
    }
}
