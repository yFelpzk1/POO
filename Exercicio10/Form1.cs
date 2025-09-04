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
                MessageBox.Show("O campo 'Nome' � obrigat�rio.", "Erro de Valida��o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            string sexo = cmbSexo.Text; 

            if (string.IsNullOrWhiteSpace(sexo))
            {
                MessageBox.Show("Por favor, selecione uma op��o para 'Sexo'.", "Erro de Valida��o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dependentes = rbSim.Checked ? "Sim" : "N�o";

            string mensagem = $"Dados do funcion�rio:\n" +
                              $"Nome: {nome}\n" +
                              $"Dependentes: {dependentes}\n" +
                              $"Sexo: {sexo}";

            MessageBox.Show(mensagem, "Funcion�rio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
