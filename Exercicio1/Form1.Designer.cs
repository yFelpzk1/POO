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
            groupBoxSelecao = new GroupBox();
            rbDobrar = new RadioButton();
            rbTriplicar = new RadioButton();
            label1 = new Label();
            txtEntrada = new TextBox();
            btnAplicar = new Button();
            lblResultado = new Label();
            txtResultado = new TextBox();
            groupBoxSelecao.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxSelecao
            // 
            groupBoxSelecao.Controls.Add(txtResultado);
            groupBoxSelecao.Controls.Add(lblResultado);
            groupBoxSelecao.Controls.Add(btnAplicar);
            groupBoxSelecao.Controls.Add(txtEntrada);
            groupBoxSelecao.Controls.Add(label1);
            groupBoxSelecao.Controls.Add(rbTriplicar);
            groupBoxSelecao.Controls.Add(rbDobrar);
            groupBoxSelecao.Location = new Point(32, 22);
            groupBoxSelecao.Name = "groupBoxSelecao";
            groupBoxSelecao.Size = new Size(336, 370);
            groupBoxSelecao.TabIndex = 0;
            groupBoxSelecao.TabStop = false;
            groupBoxSelecao.Text = "Selecione:";
            // 
            // rbDobrar
            // 
            rbDobrar.AutoSize = true;
            rbDobrar.Checked = true;
            rbDobrar.Location = new Point(15, 34);
            rbDobrar.Name = "rbDobrar";
            rbDobrar.Size = new Size(61, 19);
            rbDobrar.TabIndex = 0;
            rbDobrar.TabStop = true;
            rbDobrar.Text = "Dobrar";
            rbDobrar.UseVisualStyleBackColor = true;
            // 
            // rbTriplicar
            // 
            rbTriplicar.AutoSize = true;
            rbTriplicar.Location = new Point(15, 81);
            rbTriplicar.Name = "rbTriplicar";
            rbTriplicar.Size = new Size(67, 19);
            rbTriplicar.TabIndex = 1;
            rbTriplicar.Text = "Triplicar";
            rbTriplicar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 138);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 2;
            label1.Text = "Digite um numero:";
            // 
            // txtEntrada
            // 
            txtEntrada.Location = new Point(15, 168);
            txtEntrada.Name = "txtEntrada";
            txtEntrada.Size = new Size(100, 23);
            txtEntrada.TabIndex = 3;
            // 
            // btnAplicar
            // 
            btnAplicar.Location = new Point(15, 206);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(100, 23);
            btnAplicar.TabIndex = 4;
            btnAplicar.Text = "Aplicar";
            btnAplicar.UseVisualStyleBackColor = true;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(15, 256);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(62, 15);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Resultado:";
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Location = new Point(15, 284);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxSelecao);
            Name = "Form1";
            Text = "Form1";
            groupBoxSelecao.ResumeLayout(false);
            groupBoxSelecao.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxSelecao;
        private Label lblResultado;
        private Button btnAplicar;
        private TextBox txtEntrada;
        private Label label1;
        private RadioButton rbTriplicar;
        private RadioButton rbDobrar;
        private TextBox txtResultado;
    }
}
