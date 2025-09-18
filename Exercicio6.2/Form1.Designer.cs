namespace Exercicio6
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
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 52);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 116);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Peso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 188);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Altura:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(99, 44);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(152, 23);
            txtNome.TabIndex = 3;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(99, 108);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(152, 23);
            txtPeso.TabIndex = 4;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(98, 180);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(152, 23);
            txtAltura.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(99, 262);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(151, 56);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 450);
            Controls.Add(btnCalcular);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "IMC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Button btnCalcular;
    }
}
