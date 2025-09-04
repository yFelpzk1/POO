namespace Exercicio3
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
            groupBoxOpcoes = new GroupBox();
            rbMostrar = new RadioButton();
            rbEsconder = new RadioButton();
            panelCheckBoxes = new Panel();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            groupBoxOpcoes.SuspendLayout();
            panelCheckBoxes.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxOpcoes
            // 
            groupBoxOpcoes.Controls.Add(panelCheckBoxes);
            groupBoxOpcoes.Controls.Add(rbEsconder);
            groupBoxOpcoes.Controls.Add(rbMostrar);
            groupBoxOpcoes.Location = new Point(142, 38);
            groupBoxOpcoes.Name = "groupBoxOpcoes";
            groupBoxOpcoes.Size = new Size(546, 452);
            groupBoxOpcoes.TabIndex = 0;
            groupBoxOpcoes.TabStop = false;
            groupBoxOpcoes.Text = "Opções";
            // 
            // rbMostrar
            // 
            rbMostrar.AutoSize = true;
            rbMostrar.Checked = true;
            rbMostrar.Location = new Point(44, 44);
            rbMostrar.Name = "rbMostrar";
            rbMostrar.Size = new Size(66, 19);
            rbMostrar.TabIndex = 0;
            rbMostrar.TabStop = true;
            rbMostrar.Text = "Mostrar";
            rbMostrar.UseVisualStyleBackColor = true;
            rbMostrar.CheckedChanged += rbMostrar_CheckedChanged;
            // 
            // rbEsconder
            // 
            rbEsconder.AutoSize = true;
            rbEsconder.Location = new Point(44, 93);
            rbEsconder.Name = "rbEsconder";
            rbEsconder.Size = new Size(73, 19);
            rbEsconder.TabIndex = 1;
            rbEsconder.Text = "Esconder";
            rbEsconder.UseVisualStyleBackColor = true;
            rbEsconder.CheckedChanged += rbEsconder_CheckedChanged;
            // 
            // panelCheckBoxes
            // 
            panelCheckBoxes.BorderStyle = BorderStyle.FixedSingle;
            panelCheckBoxes.Controls.Add(checkBox2);
            panelCheckBoxes.Controls.Add(checkBox1);
            panelCheckBoxes.Location = new Point(208, 31);
            panelCheckBoxes.Name = "panelCheckBoxes";
            panelCheckBoxes.Size = new Size(200, 100);
            panelCheckBoxes.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(17, 12);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(82, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(17, 61);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(82, 19);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 554);
            Controls.Add(groupBoxOpcoes);
            Name = "Form1";
            Text = "Exercicio 3";
            Load += Form1_Load;
            groupBoxOpcoes.ResumeLayout(false);
            groupBoxOpcoes.PerformLayout();
            panelCheckBoxes.ResumeLayout(false);
            panelCheckBoxes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxOpcoes;
        private Panel panelCheckBoxes;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private RadioButton rbEsconder;
        private RadioButton rbMostrar;
    }
}
