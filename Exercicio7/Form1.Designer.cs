namespace Exercicio7
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
            txtNumero = new TextBox();
            rbAntecessor = new RadioButton();
            rbSucessor = new RadioButton();
            btnCalcular = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 46);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Número:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(96, 38);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // rbAntecessor
            // 
            rbAntecessor.AutoSize = true;
            rbAntecessor.Checked = true;
            rbAntecessor.Location = new Point(102, 84);
            rbAntecessor.Name = "rbAntecessor";
            rbAntecessor.Size = new Size(83, 19);
            rbAntecessor.TabIndex = 2;
            rbAntecessor.TabStop = true;
            rbAntecessor.Text = "Antecessor";
            rbAntecessor.UseVisualStyleBackColor = true;
            // 
            // rbSucessor
            // 
            rbSucessor.AutoSize = true;
            rbSucessor.Location = new Point(102, 134);
            rbSucessor.Name = "rbSucessor";
            rbSucessor.Size = new Size(71, 19);
            rbSucessor.TabIndex = 3;
            rbSucessor.Text = "Sucessor";
            rbSucessor.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(36, 192);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(91, 41);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNumero);
            groupBox1.Controls.Add(btnCalcular);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(rbSucessor);
            groupBox1.Controls.Add(rbAntecessor);
            groupBox1.Location = new Point(12, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 260);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Antecessor e Sucessor:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Exercicio 7";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private RadioButton rbAntecessor;
        private RadioButton rbSucessor;
        private Button btnCalcular;
        private GroupBox groupBox1;
    }
}
