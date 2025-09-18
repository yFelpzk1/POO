namespace Exercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtLado.Text, out double lado))
            {
                MessageBox.Show("Por favor, digite um valor numérico válido para o Lado.",
                                "Entrada Inválida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            Quadrado meuQuadrado = new Quadrado(lado);

            meuQuadrado.CalcularArea();
            meuQuadrado.CalcularPerimetro();

            string dados = meuQuadrado.Imprimir();

            MessageBox.Show(dados, "Resultados do Quadrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
