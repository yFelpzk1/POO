namespace Alula10Exercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                    string.IsNullOrWhiteSpace(txtNome.Text) ||
                    string.IsNullOrWhiteSpace(txtNota1.Text) ||
                    string.IsNullOrWhiteSpace(txtNota2.Text))
                {
                    MessageBox.Show("Preencha todos os campos antes de calcular.");
                    return;
                }

                string codigo = txtCodigo.Text;
                string nome = txtNome.Text;
                double nota1 = double.Parse(txtNota1.Text);
                double nota2 = double.Parse(txtNota2.Text);

                Aluno aluno = new Aluno(codigo, nome, nota1, nota2);
                aluno.CalcularMedia();
                MessageBox.Show(aluno.ImprimirDados());
            }
            catch(FormatException)
            {
                MessageBox.Show("Formato de número inválido. Por favor, insira um valor numérico para as notas.");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }
    }
}
