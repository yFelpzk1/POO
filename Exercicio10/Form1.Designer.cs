namespace Exercicio10
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
            txtNome = new TextBox();
            label2 = new Label();
            label3 = new Label();
            rbSim = new RadioButton();
            rbNao = new RadioButton();
            cmbSexo = new ComboBox();
            btnMostrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 26);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(82, 18);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(150, 23);
            txtNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 146);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 2;
            label2.Text = "Sexo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 82);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 3;
            label3.Text = "Depedentes:";
            // 
            // rbSim
            // 
            rbSim.AutoSize = true;
            rbSim.Location = new Point(111, 82);
            rbSim.Name = "rbSim";
            rbSim.Size = new Size(45, 19);
            rbSim.TabIndex = 4;
            rbSim.Text = "Sim";
            rbSim.UseVisualStyleBackColor = true;
            // 
            // rbNao
            // 
            rbNao.AutoSize = true;
            rbNao.Checked = true;
            rbNao.Location = new Point(173, 82);
            rbNao.Name = "rbNao";
            rbNao.Size = new Size(47, 19);
            rbNao.TabIndex = 5;
            rbNao.TabStop = true;
            rbNao.Text = "Não";
            rbNao.UseVisualStyleBackColor = true;
            // 
            // cmbSexo
            // 
            cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "Masculino", "Feminino", "Outro" });
            cmbSexo.Location = new Point(82, 138);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(121, 23);
            cmbSexo.TabIndex = 6;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(81, 206);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 7;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMostrar);
            Controls.Add(cmbSexo);
            Controls.Add(rbNao);
            Controls.Add(rbSim);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Exercicio 10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private Label label3;
        private RadioButton rbSim;
        private RadioButton rbNao;
        private ComboBox cmbSexo;
        private Button btnMostrar;
    }
}
