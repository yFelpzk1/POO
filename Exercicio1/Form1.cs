namespace Exercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtEntrada.Text, out double numero))
            {
                double resultado = 0;

                if (rbDobrar.Checked)
                {
                    resultado = numero * 2;
                }
                else 
                {
                    resultado = numero * 3;
                }
                txtResultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, digite um número válido.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEntrada.Focus(); 
                txtEntrada.SelectAll(); 
            }
        }
    }
}
