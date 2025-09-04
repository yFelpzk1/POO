namespace Exercicio6
{
    public partial class Form1 : Form
    {
        public long CalcularFatorial(int numero)
        {
            if (numero == 0)
            {
                return 1;
            }

            long resultado = 1;
            for (int i = 1; i <= numero; i++)
            {
                resultado = resultado * i;
            }

            return resultado;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int numeroEntrada))
            {           
                if (numeroEntrada >= 0)
                {
                    long resultadoFatorial = CalcularFatorial(numeroEntrada);

                    txtResultado.Text = resultadoFatorial.ToString();
                }
                else
                {
                    MessageBox.Show("Por favor, digite um n�mero n�o negativo.", "Entrada Inv�lida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, digite um n�mero inteiro v�lido.", "Entrada Inv�lida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
