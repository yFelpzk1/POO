namespace Exercicio9
{
    public partial class Form1 : Form
    {
        public string CalcularConceito(double nota)
        {
            if (nota >= 9.0 && nota <= 10.0)
            {
                return "A";
            }
            else if (nota >= 7.0 && nota <= 8.9)
            {
                return "B";
            }
            else if (nota >= 5.0 && nota <= 6.9)
            {
                return "C";
            }
            else
            {
                return "D";
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularConceito_Click(object sender, EventArgs e)
        {
            string nome = txtNomeAluno.Text;

            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Por favor, digite o nome do aluno.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (double.TryParse(txtNotaAluno.Text, out double nota))
            {
                if (nota >= 0 && nota <= 10)
                {
                    string conceito = CalcularConceito(nota);

                    string mensagem = $"{nome} seu conceito é {conceito}";

                    MessageBox.Show(mensagem, "Resultado do Conceito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor, digite uma nota entre 0 e 10.", "Nota Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, digite um valor numérico para a nota.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
