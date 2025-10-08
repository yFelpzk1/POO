namespace Exercicio7
{
    public partial class Form1 : Form
    {
        Dados dados;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarDados_Click(object sender, EventArgs e)
        {
            try
            {
               dados = new Dados();

                string nome = txtNome.Text;
                string sobrenome = txtSobrenome.Text;
                int idade = int.Parse(txtIdade.Text);
                string sexo = txtSexo.Text;
                string titulacao = txtTitulacao.Text;
                string naturalidade = txtNaturalidade.Text;
                string endereco = txtEndereco.Text;
                string cidade = txtCidade.Text;
                string estado = txtEstado.Text;

                dados = new Dados(nome, sobrenome, idade, sexo, titulacao, naturalidade, endereco, cidade, estado);

                MessageBox.Show(dados.ImprimirDados());


            }
            catch(FormatException)
            {
                MessageBox.Show("Formato inválido. Verifique os dados inseridos.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }
    }
}
