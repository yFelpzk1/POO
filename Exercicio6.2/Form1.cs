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
                MessageBox.Show("O campo Nome é obrigatório.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtPeso.Text, out double peso) || !double.TryParse(txtAltura.Text, out double altura))
            {
                MessageBox.Show("Por favor, digite valores numéricos válidos para Peso e Altura.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (altura <= 0)
            {
                MessageBox.Show("A Altura deve ser um valor maior que zero.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Paciente paciente = new Paciente(txtNome.Text, peso, altura);

            string dadosCompletos = paciente.ImprimirDados();

            MessageBox.Show(dadosCompletos, "Diagnóstico do Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
