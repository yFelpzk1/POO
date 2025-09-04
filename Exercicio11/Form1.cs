namespace Exercicio11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            bool aValido = int.TryParse(txtEntradaA.Text, out int numA);
            bool bValido = int.TryParse(txtEntradaB.Text, out int numB);
            bool cValido = int.TryParse(txtEntradaC.Text, out int numC);

            if (aValido && bValido && cValido)
            {
                List<int> numeros = new List<int>();
                numeros.Add(numA);
                numeros.Add(numB);
                numeros.Add(numC);

                numeros.Sort();

                txtSaida1.Text = numeros[0].ToString();
                txtSaida2.Text = numeros[1].ToString();
                txtSaida3.Text = numeros[2].ToString();
            }
            else
            {
                MessageBox.Show("Por favor, digite números inteiros válidos em todos os campos (A, B e C).",
                                "Entrada Inválida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
    }
}
