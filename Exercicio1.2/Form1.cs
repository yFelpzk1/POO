using System;
using System.Windows.Forms;

namespace Exercicio1
{
    public partial class Form1 : Form
    {
        private Empregado empregado;

        public Form1()
        {
            InitializeComponent();
            empregado = new Empregado();
        }

        private void btnMostraDados_Click(object sender, EventArgs e)
        {
            if (LerEValidarDados())
            {
                string dados = empregado.MostraDados();
                MessageBox.Show(dados, "Dados do Empregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalarioMensal_Click(object sender, EventArgs e)
        {
            if (LerEValidarDados())
            {
                double salario = empregado.CalculaSalarioMensal();
                MessageBox.Show($"O sal�rio mensal calculado �: {salario:C}", "Sal�rio Mensal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool LerEValidarDados()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtDepartamento.Text))
            {
                MessageBox.Show("Os campos Nome e Departamento s�o obrigat�rios.", "Erro de Valida��o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!double.TryParse(txtSalarioMes.Text, out double horas))
            {
                MessageBox.Show("Por favor, digite um valor num�rico v�lido para as Horas.", "Erro de Valida��o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!double.TryParse(txtSalarioHora.Text, out double salarioHora))
            {
                MessageBox.Show("Por favor, digite um valor num�rico v�lido para o Sal�rio por Hora.", "Erro de Valida��o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            empregado.Nome = txtNome.Text;
            empregado.Departamento = txtDepartamento.Text;
            empregado.HorasTrabalhadasNoMes = horas;
            empregado.SalarioPorHora = salarioHora;

            return true;
        }
    }
}