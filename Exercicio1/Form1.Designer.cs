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
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            btnCalcular = new Button();
            cboSoma = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 71);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 142);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Numero 2:";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(151, 63);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(158, 23);
            txtNumero1.TabIndex = 2;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(151, 134);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(158, 23);
            txtNumero2.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(594, 339);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(159, 77);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // cboSoma
            // 
            cboSoma.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSoma.FormattingEnabled = true;
            cboSoma.Items.AddRange(new object[] { "Soma", "Subtração", "Multiplicação", "Divisão" });
            cboSoma.Location = new Point(151, 199);
            cboSoma.Name = "cboSoma";
            cboSoma.Size = new Size(158, 23);
            cboSoma.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 202);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 6;
            label3.Text = "Operação:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(cboSoma);
            Controls.Add(btnCalcular);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Soma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private Button btnCalcular;
        private ComboBox cboSoma;
        private Label label3;
    }
}
