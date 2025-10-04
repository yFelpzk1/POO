namespace Alula10Exercicio6
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
            btnCalcular = new Button();
            txtCodigo = new TextBox();
            txtNome = new TextBox();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 40);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 105);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 179);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Nota 1:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 251);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "Nota2:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(43, 336);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(109, 47);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(98, 32);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(114, 23);
            txtCodigo.TabIndex = 5;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(91, 97);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(114, 23);
            txtNome.TabIndex = 6;
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(92, 171);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(114, 23);
            txtNota1.TabIndex = 7;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(91, 243);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(114, 23);
            txtNota2.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 544);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(txtNome);
            Controls.Add(txtCodigo);
            Controls.Add(btnCalcular);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Média Aritmética";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCalcular;
        private TextBox txtCodigo;
        private TextBox txtNome;
        private TextBox txtNota1;
        private TextBox txtNota2;
    }
}
