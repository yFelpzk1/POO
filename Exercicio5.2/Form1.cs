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
                MessageBox.Show("Por favor, digite um nome.", "Entrada Inv�lida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtSalario.Text, out double salarioInicial))
            {
                MessageBox.Show("Por favor, digite um valor num�rico v�lido para o sal�rio.", "Entrada Inv�lida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Funcionario func = new Funcionario(nome, salarioInicial);

            double salarioAntigo = func.Salario;

            func.AumentarSalario();

            string dadosAtualizados = func.RetornarDados();

            string mensagemFinal = $"Dados Iniciais:\n" +
                                     $"Sal�rio Antigo: {salarioAntigo:C}\n\n" +
                                     $"--- Ap�s Aumento ---\n" +
                                     $"{dadosAtualizados}";

            MessageBox.Show(mensagemFinal, "C�lculo de Aumento Salarial", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
