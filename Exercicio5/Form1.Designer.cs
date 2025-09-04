namespace Exercicio5
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
            btnClicar = new Button();
            txtContagem = new TextBox();
            SuspendLayout();
            // 
            // btnClicar
            // 
            btnClicar.Location = new Point(74, 79);
            btnClicar.Name = "btnClicar";
            btnClicar.Size = new Size(105, 71);
            btnClicar.TabIndex = 0;
            btnClicar.Text = "Clique aqui!";
            btnClicar.UseVisualStyleBackColor = true;
            btnClicar.Click += btnClicar_Click;
            // 
            // txtContagem
            // 
            txtContagem.Enabled = false;
            txtContagem.Location = new Point(210, 104);
            txtContagem.Name = "txtContagem";
            txtContagem.Size = new Size(118, 23);
            txtContagem.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtContagem);
            Controls.Add(btnClicar);
            Name = "Form1";
            Text = "Exercicio5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClicar;
        private TextBox txtContagem;
    }
}
