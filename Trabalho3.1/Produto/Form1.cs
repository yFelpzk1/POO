namespace Produto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtPreco.Text = "";
            txtQuantidade.Text = "";
            txtNome.Focus();
        }

        List<Produto> listaProdutos = new List<Produto>();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                double preco = double.Parse(txtPreco.Text);
                int quantidade = int.Parse(txtQuantidade.Text);

                if (string.IsNullOrWhiteSpace(nome))
                {
                    MessageBox.Show("O nome do produto não pode ser vazio.");
                    return;
                }

                Produto novoProduto = new Produto(nome, preco, quantidade);
                listaProdutos.Add(novoProduto);

                MessageBox.Show("Produto cadastrado com sucesso!");
                LimparCampos();
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato de dado inválido. Verifique os valores inseridos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar produto: " + ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (listaProdutos.Count == 0)
            {
                MessageBox.Show("Não há produtos cadastrados para limpar os campos.");
            }
            else
            {
                listaProdutos.Clear();
                MessageBox.Show("Lista de produtos esvaziada com sucesso!");
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (listaProdutos.Count == 0)
            {
                MessageBox.Show("Nenhum produto cadastrado para exibir.");
                return;
            }
            else
            {
                dgvImprimir.Rows.Clear();

                foreach(Produto p in listaProdutos)
                {
                    dgvImprimir.Rows.Add(p.Nome, p.Preco.ToString("F2"), p.Quantidade, p.CalcularTotal().ToString("F2"));
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (listaProdutos.Count == 0)
            {
                MessageBox.Show("Nenhum produto cadastrado para excluir.");
                return;
            }

            string nomeExcluir = txtExcluir.Text.Trim();

            if (string.IsNullOrWhiteSpace(nomeExcluir))
            {
                MessageBox.Show("Por favor, insira o nome do produto a ser excluído.");
                return;
            }

            Produto produtoEncontrado = listaProdutos.FirstOrDefault(p => p.Nome.Equals(nomeExcluir, StringComparison.OrdinalIgnoreCase));

            if (produtoEncontrado != null)
            {
                listaProdutos.Remove(produtoEncontrado);
                MessageBox.Show($"Produto '{nomeExcluir}' excluído com sucesso.");
            }
            else
            {
                MessageBox.Show($"Produto '{nomeExcluir}' não encontrado na lista.");
            }
        }
    }
}
