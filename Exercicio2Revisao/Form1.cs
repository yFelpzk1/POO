namespace Exercicio2
{
    public partial class Form1 : Form
    {
        Livro[] livros = new Livro[3];
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtCodigo.Text);
                string titulo = txtTitulo.Text;
                double preco = double.Parse(txtPreco.Text);

                if (contador == 0)
                {
                    livros[contador] = new Livro(codigo);
                    livros[contador].SetPreco(preco); 
                }
                else if (contador == 1)
                {
                    livros[contador] = new Livro(codigo, titulo);
                    livros[contador].SetPreco(preco); 
                }
                else if (contador == 2)
                {
                    livros[contador] = new Livro(codigo, titulo, preco);
                }

                MessageBox.Show("Livro cadastrado com sucesso!", "Cadastro");

                contador++;

                if (contador == 3)
                {
                    double total = 0;
                    string resumo = "Resumo dos livros:\n\n";

                    foreach (var livro in livros)
                    {
                        resumo += livro.GetInfo() + "\n";
                        total += livro.GetPreco();
                    }

                    resumo += $"\nTotal a pagar: {total:C}";
                    MessageBox.Show(resumo, "Resultado Final");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro: Digite valores numéricos válidos para código e preço.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: " + ex.Message);
            }
        }
    }
}
