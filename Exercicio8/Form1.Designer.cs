namespace Exercicio8
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
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            label3 = new Label();
            txtResultado = new TextBox();
            btnCalcular = new Button();
            groupBoxOperacoes = new GroupBox();
            rbSoma = new RadioButton();
            rbSubtracao = new RadioButton();
            rbDivisao = new RadioButton();
            rbMultiplicacao = new RadioButton();
            groupBoxOperacoes.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.BottomLeft;
            label1.Location = new Point(43, 32);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Num 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 98);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Num 2:";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(95, 24);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(95, 90);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImageAlign = ContentAlignment.BottomLeft;
            label3.Location = new Point(43, 186);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 4;
            label3.Text = "Resultado:";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(111, 178);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(43, 242);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(168, 46);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // groupBoxOperacoes
            // 
            groupBoxOperacoes.Controls.Add(rbMultiplicacao);
            groupBoxOperacoes.Controls.Add(rbDivisao);
            groupBoxOperacoes.Controls.Add(rbSubtracao);
            groupBoxOperacoes.Controls.Add(rbSoma);
            groupBoxOperacoes.Location = new Point(304, 24);
            groupBoxOperacoes.Name = "groupBoxOperacoes";
            groupBoxOperacoes.Size = new Size(290, 264);
            groupBoxOperacoes.TabIndex = 7;
            groupBoxOperacoes.TabStop = false;
            groupBoxOperacoes.Text = "Operações";
            // 
            // rbSoma
            // 
            rbSoma.AutoSize = true;
            rbSoma.Checked = true;
            rbSoma.Location = new Point(16, 38);
            rbSoma.Name = "rbSoma";
            rbSoma.Size = new Size(55, 19);
            rbSoma.TabIndex = 0;
            rbSoma.TabStop = true;
            rbSoma.Text = "Soma";
            rbSoma.UseVisualStyleBackColor = true;
            // 
            // rbSubtracao
            // 
            rbSubtracao.AutoSize = true;
            rbSubtracao.Location = new Point(16, 86);
            rbSubtracao.Name = "rbSubtracao";
            rbSubtracao.Size = new Size(78, 19);
            rbSubtracao.TabIndex = 1;
            rbSubtracao.Text = "Subtração";
            rbSubtracao.UseVisualStyleBackColor = true;
            // 
            // rbDivisao
            // 
            rbDivisao.AutoSize = true;
            rbDivisao.Location = new Point(16, 141);
            rbDivisao.Name = "rbDivisao";
            rbDivisao.Size = new Size(63, 19);
            rbDivisao.TabIndex = 2;
            rbDivisao.Text = "Divisão";
            rbDivisao.UseVisualStyleBackColor = true;
            // 
            // rbMultiplicacao
            // 
            rbMultiplicacao.AutoSize = true;
            rbMultiplicacao.Location = new Point(16, 190);
            rbMultiplicacao.Name = "rbMultiplicacao";
            rbMultiplicacao.Size = new Size(97, 19);
            rbMultiplicacao.TabIndex = 3;
            rbMultiplicacao.Text = "Multiplicação";
            rbMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxOperacoes);
            Controls.Add(btnCalcular);
            Controls.Add(txtResultado);
            Controls.Add(label3);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Exercicio 8";
            groupBoxOperacoes.ResumeLayout(false);
            groupBoxOperacoes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Label label3;
        private TextBox txtResultado;
        private Button btnCalcular;
        private GroupBox groupBoxOperacoes;
        private RadioButton rbMultiplicacao;
        private RadioButton rbDivisao;
        private RadioButton rbSubtracao;
        private RadioButton rbSoma;
    }
}
