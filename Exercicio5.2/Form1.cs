namespace Exercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Por favor, digite um nome.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtSalario.Text, out double salarioInicial))
            {
                MessageBox.Show("Por favor, digite um valor numérico válido para o salário.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Funcionario func = new Funcionario(nome, salarioInicial);

            double salarioAntigo = func.Salario;

            func.AumentarSalario();

            string dadosAtualizados = func.RetornarDados();

            string mensagemFinal = $"Dados Iniciais:\n" +
                                     $"Salário Antigo: {salarioAntigo:C}\n\n" +
                                     $"--- Após Aumento ---\n" +
                                     $"{dadosAtualizados}";

            MessageBox.Show(mensagemFinal, "Cálculo de Aumento Salarial", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
