namespace Exercicio8
{
    public partial class Form1 : Form
    {
        public double Somar(double a, double b)
        {
            return a + b;
        }

        public double Subtrair(double a, double b)
        {
            return a - b;
        }

        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public double Dividir(double a, double b)
        {
            return a / b;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            bool num1Valido = double.TryParse(txtNum1.Text, out double num1);
            bool num2Valido = double.TryParse(txtNum2.Text, out double num2);

            if (num1Valido && num2Valido)
            {
                double resultado = 0;
               
                if (rbSoma.Checked)
                {
                    resultado = Somar(num1, num2);
                }
                else if (rbSubtracao.Checked)
                {
                    resultado = Subtrair(num1, num2);
                }
                else if (rbMultiplicacao.Checked)
                {
                    resultado = Multiplicar(num1, num2);
                }
                else if (rbDivisao.Checked)
                {                   
                    if (num2 == 0)
                    {
                        MessageBox.Show("Não é possível dividir por zero.", "Operação Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; 
                    }
                    resultado = Dividir(num1, num2);
                }
                txtResultado.Text = resultado.ToString("F2"); 
            }
            else
            {
                MessageBox.Show("Por favor, digite números válidos em ambos os campos.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
