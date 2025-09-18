namespace Exercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            bool baseValida = double.TryParse(txtBase.Text, out double baseRet);
            bool alturaValida = double.TryParse(txtAltura.Text, out double alturaRet);

            if (!baseValida || !alturaValida)
            {
                MessageBox.Show("Por favor, digite valores numéricos válidos para a base e a altura.",
                                "Entrada Inválida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            Retangulo meuRetangulo = new Retangulo(baseRet, alturaRet);

            double area = meuRetangulo.CalcularArea();
            double perimetro = meuRetangulo.CalcularPerimetro();
            string valoresBaseAltura = meuRetangulo.RetornarValores();

            string resultadoFinal = $"{valoresBaseAltura}\n\n" +
                                    $"Área calculada: {area}\n" +
                                    $"Perímetro calculado: {perimetro}";

            MessageBox.Show(resultadoFinal, "Resultados do Retângulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
