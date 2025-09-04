namespace Exercicio4
{
    public partial class Form1 : Form
    {
        public double CalcularMedia(double n1, double n2, double n3, double n4)
        {
            double soma = n1 + n2 + n3 + n4;
            return soma / 4.0;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            bool n1Valido = double.TryParse(txtNumero1.Text, out double n1);
            bool n2Valido = double.TryParse(txtNumero2.Text, out double n2);
            bool n3Valido = double.TryParse(txtNumero3.Text, out double n3);
            bool n4Valido = double.TryParse(txtNumero4.Text, out double n4);

            if (n1Valido && n2Valido && n3Valido && n4Valido)
            {
                double media = CalcularMedia(n1, n2, n3, n4);

                txtResultado.Text = media.ToString("F2");
            }
            else
            {
                MessageBox.Show("Por favor, digite números válidos em todos os campos.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
