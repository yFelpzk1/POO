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
            lblNome = new Label();
            txtNome = new TextBox();
            lblDepartamento = new Label();
            txtDepartamento = new TextBox();
            lblSalHr = new Label();
            lblTrHoras = new Label();
            txtSalarioHora = new TextBox();
            txtSalarioMes = new TextBox();
            btnMostraDados = new Button();
            btnSalarioMensal = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(21, 33);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(70, 25);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(260, 23);
            txtNome.TabIndex = 1;
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Location = new Point(21, 66);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(86, 15);
            lblDepartamento.TabIndex = 2;
            lblDepartamento.Text = "Departamento:";
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(113, 58);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(217, 23);
            txtDepartamento.TabIndex = 3;
            // 
            // lblSalHr
            // 
            lblSalHr.AutoSize = true;
            lblSalHr.Location = new Point(21, 128);
            lblSalHr.Name = "lblSalHr";
            lblSalHr.Size = new Size(93, 15);
            lblSalHr.TabIndex = 4;
            lblSalHr.Text = "Salário por hora:";
            // 
            // lblTrHoras
            // 
            lblTrHoras.AutoSize = true;
            lblTrHoras.Location = new Point(21, 98);
            lblTrHoras.Name = "lblTrHoras";
            lblTrHoras.Size = new Size(147, 15);
            lblTrHoras.TabIndex = 5;
            lblTrHoras.Text = "Horas trabalhadas no mês:";
            // 
            // txtSalarioHora
            // 
            txtSalarioHora.Location = new Point(120, 120);
            txtSalarioHora.Name = "txtSalarioHora";
            txtSalarioHora.Size = new Size(210, 23);
            txtSalarioHora.TabIndex = 6;
            // 
            // txtSalarioMes
            // 
            txtSalarioMes.Location = new Point(174, 90);
            txtSalarioMes.Name = "txtSalarioMes";
            txtSalarioMes.Size = new Size(156, 23);
            txtSalarioMes.TabIndex = 7;
            // 
            // btnMostraDados
            // 
            btnMostraDados.Location = new Point(21, 202);
            btnMostraDados.Name = "btnMostraDados";
            btnMostraDados.Size = new Size(93, 36);
            btnMostraDados.TabIndex = 8;
            btnMostraDados.Text = "Mostra Dados";
            btnMostraDados.UseVisualStyleBackColor = true;
            btnMostraDados.Click += btnMostraDados_Click;
            // 
            // btnSalarioMensal
            // 
            btnSalarioMensal.Location = new Point(192, 202);
            btnSalarioMensal.Name = "btnSalarioMensal";
            btnSalarioMensal.Size = new Size(93, 36);
            btnSalarioMensal.TabIndex = 9;
            btnSalarioMensal.Text = "Salário Mensal";
            btnSalarioMensal.UseVisualStyleBackColor = true;
            btnSalarioMensal.Click += btnSalarioMensal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalarioMensal);
            Controls.Add(btnMostraDados);
            Controls.Add(txtSalarioMes);
            Controls.Add(txtSalarioHora);
            Controls.Add(lblTrHoras);
            Controls.Add(lblSalHr);
            Controls.Add(txtDepartamento);
            Controls.Add(lblDepartamento);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Label lblDepartamento;
        private TextBox txtDepartamento;
        private Label lblSalHr;
        private Label lblTrHoras;
        private TextBox txtSalarioHora;
        private TextBox txtSalarioMes;
        private Button btnMostraDados;
        private Button btnSalarioMensal;
    }
}
