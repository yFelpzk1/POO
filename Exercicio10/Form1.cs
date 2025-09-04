namespace Exercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("O campo 'Nome' é obrigatório.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            string sexo = cmbSexo.Text; 

            if (string.IsNullOrWhiteSpace(sexo))
            {
                MessageBox.Show("Por favor, selecione uma opção para 'Sexo'.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dependentes = rbSim.Checked ? "Sim" : "Não";

            string mensagem = $"Dados do funcionário:\n" +
                              $"Nome: {nome}\n" +
                              $"Dependentes: {dependentes}\n" +
                              $"Sexo: {sexo}";

            MessageBox.Show(mensagem, "Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
