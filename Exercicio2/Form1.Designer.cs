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
            chkDormir = new CheckBox();
            chkComer = new CheckBox();
            chkCinema = new CheckBox();
            chkLerLivro = new CheckBox();
            chkEstudar = new CheckBox();
            btnVerificar = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 22);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 0;
            label1.Text = "O que eu gosto de fazer:";
            // 
            // chkDormir
            // 
            chkDormir.AutoSize = true;
            chkDormir.Location = new Point(25, 50);
            chkDormir.Name = "chkDormir";
            chkDormir.Size = new Size(63, 19);
            chkDormir.TabIndex = 1;
            chkDormir.Text = "Dormir";
            chkDormir.UseVisualStyleBackColor = true;
            // 
            // chkComer
            // 
            chkComer.AutoSize = true;
            chkComer.Location = new Point(25, 98);
            chkComer.Name = "chkComer";
            chkComer.Size = new Size(62, 19);
            chkComer.TabIndex = 2;
            chkComer.Text = "Comer";
            chkComer.UseVisualStyleBackColor = true;
            // 
            // chkCinema
            // 
            chkCinema.AutoSize = true;
            chkCinema.Location = new Point(25, 150);
            chkCinema.Name = "chkCinema";
            chkCinema.Size = new Size(91, 19);
            chkCinema.TabIndex = 3;
            chkCinema.Text = "Ir ao cinema";
            chkCinema.UseVisualStyleBackColor = true;
            // 
            // chkLerLivro
            // 
            chkLerLivro.AutoSize = true;
            chkLerLivro.Location = new Point(25, 206);
            chkLerLivro.Name = "chkLerLivro";
            chkLerLivro.Size = new Size(92, 19);
            chkLerLivro.TabIndex = 4;
            chkLerLivro.Text = "Ler um Livro";
            chkLerLivro.UseVisualStyleBackColor = true;
            // 
            // chkEstudar
            // 
            chkEstudar.AutoSize = true;
            chkEstudar.Location = new Point(25, 266);
            chkEstudar.Name = "chkEstudar";
            chkEstudar.Size = new Size(65, 19);
            chkEstudar.TabIndex = 5;
            chkEstudar.Text = "Estudar";
            chkEstudar.UseVisualStyleBackColor = true;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(25, 328);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(93, 35);
            btnVerificar.TabIndex = 6;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(198, 328);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(93, 35);
            btnSair.TabIndex = 7;
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
            Controls.Add(btnVerificar);
            Controls.Add(chkEstudar);
            Controls.Add(chkLerLivro);
            Controls.Add(chkCinema);
            Controls.Add(chkComer);
            Controls.Add(chkDormir);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox chkDormir;
        private CheckBox chkComer;
        private CheckBox chkCinema;
        private CheckBox chkLerLivro;
        private CheckBox chkEstudar;
        private Button btnVerificar;
        private Button btnSair;
    }
}
