namespace Exercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                int resultado = 0;

                if (rbAntecessor.Checked)
                {
                    resultado = numero - 1;
                }
                else if (rbSucessor.Checked)
                {
                    resultado = numero + 1;
                }

                txtNumero.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, digite um número inteiro válido.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
