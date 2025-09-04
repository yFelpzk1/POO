namespace Exercicio9
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
            txtNomeAluno = new TextBox();
            label2 = new Label();
            txtNotaAluno = new TextBox();
            btnCalcularConceito = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 42);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite o nome do aluno:";
            // 
            // txtNomeAluno
            // 
            txtNomeAluno.Location = new Point(135, 60);
            txtNomeAluno.Name = "txtNomeAluno";
            txtNomeAluno.Size = new Size(182, 23);
            txtNomeAluno.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 128);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 2;
            label2.Text = "Digite a nota do aluno:";
            // 
            // txtNotaAluno
            // 
            txtNotaAluno.Location = new Point(135, 156);
            txtNotaAluno.Name = "txtNotaAluno";
            txtNotaAluno.Size = new Size(182, 23);
            txtNotaAluno.TabIndex = 3;
            // 
            // btnCalcularConceito
            // 
            btnCalcularConceito.Location = new Point(135, 222);
            btnCalcularConceito.Name = "btnCalcularConceito";
            btnCalcularConceito.Size = new Size(135, 30);
            btnCalcularConceito.TabIndex = 4;
            btnCalcularConceito.Text = "Calcular conceito";
            btnCalcularConceito.UseVisualStyleBackColor = true;
            btnCalcularConceito.Click += btnCalcularConceito_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(333, 222);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(135, 30);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSair);
            Controls.Add(btnCalcularConceito);
            Controls.Add(txtNotaAluno);
            Controls.Add(label2);
            Controls.Add(txtNomeAluno);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Exercicio 9";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNomeAluno;
        private Label label2;
        private TextBox txtNotaAluno;
        private Button btnCalcularConceito;
        private Button btnSair;
    }
}
