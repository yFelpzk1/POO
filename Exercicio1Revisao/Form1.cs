namespace Exercicio
{
    public partial class Form1 : Form
    {
        Produto produto1 = new Produto();
        Produto produto2 = new Produto();
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                double preco = double.Parse(txtPreco.Text);
                int quantidade = int.Parse(txtQuantidade.Text);

                if (contador == 0)
                {
                    produto1.SetDados(nome, preco, quantidade);
                    contador++;
                    MessageBox.Show("Produto 1 cadastrado com sucesso!\nCadastre o segundo produto.");
                    LimparCampos();
                }
                else if (contador == 1)
                {
                    produto2.SetDados(nome, preco, quantidade);
                    contador = 0;
                    MessageBox.Show(produto1.Imprimir() + "\n\n" + produto2.Imprimir());
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtPreco.Text = "";
            txtQuantidade.Text = "";
            txtNome.Focus();
        }
    }
}
