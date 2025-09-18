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
            txtArea = new TextBox();
            txtPerimetro = new TextBox();
            btnCalcular = new Button();
            txtLado = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 148);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Area:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 98);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Perimetro:";
            // 
            // txtArea
            // 
            txtArea.Location = new Point(103, 140);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(92, 23);
            txtArea.TabIndex = 2;
            txtArea.TextChanged += textBox1_TextChanged;
            // 
            // txtPerimetro
            // 
            txtPerimetro.Location = new Point(103, 90);
            txtPerimetro.Name = "txtPerimetro";
            txtPerimetro.Size = new Size(92, 23);
            txtPerimetro.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(103, 257);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(92, 53);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtLado
            // 
            txtLado.Location = new Point(103, 190);
            txtLado.Name = "txtLado";
            txtLado.Size = new Size(92, 23);
            txtLado.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 198);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 6;
            label3.Text = "Lado:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 450);
            Controls.Add(label3);
            Controls.Add(txtLado);
            Controls.Add(btnCalcular);
            Controls.Add(txtPerimetro);
            Controls.Add(txtArea);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtArea;
        private TextBox txtPerimetro;
        private Button btnCalcular;
        private TextBox txtLado;
        private Label label3;
    }
}
