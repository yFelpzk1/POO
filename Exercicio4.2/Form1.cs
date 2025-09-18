namespace Exercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            bool num1Valido = double.TryParse(txtNumero1.Text, out double num1);
            bool num2Valido = double.TryParse(txtNumero2.Text, out double num2);

            if (!num1Valido || !num2Valido)
            {
                MessageBox.Show("Por favor, digite n�meros v�lidos em ambos os campos.",
                                "Entrada Inv�lida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            Calculadora minhaCalc = new Calculadora(num1, num2);

            double resultadoSoma = minhaCalc.Somar();
            double resultadoSubtracao = minhaCalc.Subtrair();
            double resultadoMultiplicacao = minhaCalc.Multiplicar();

            string resultadoDivisao;
            try
            {
                resultadoDivisao = minhaCalc.Dividir().ToString("F2");
            }
            catch (DivideByZeroException ex)
            {
                resultadoDivisao = ex.Message;
            }

            string mensagemFinal = $"Resultados para os n�meros {num1} e {num2}:\n\n" +
                                     $"Soma: {resultadoSoma}\n" +
                                     $"Subtra��o: {resultadoSubtracao}\n" +
                                     $"Multiplica��o: {resultadoMultiplicacao}\n" +
                                     $"Divis�o: {resultadoDivisao}";

            MessageBox.Show(mensagemFinal, "Resultados da Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
