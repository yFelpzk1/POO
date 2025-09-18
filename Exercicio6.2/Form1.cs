namespace Exercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O campo Nome � obrigat�rio.", "Entrada Inv�lida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtPeso.Text, out double peso) || !double.TryParse(txtAltura.Text, out double altura))
            {
                MessageBox.Show("Por favor, digite valores num�ricos v�lidos para Peso e Altura.", "Entrada Inv�lida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (altura <= 0)
            {
                MessageBox.Show("A Altura deve ser um valor maior que zero.", "Entrada Inv�lida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Paciente paciente = new Paciente(txtNome.Text, peso, altura);

            string dadosCompletos = paciente.ImprimirDados();

            MessageBox.Show(dadosCompletos, "Diagn�stico do Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
