namespace Exercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnSair1.Click += btnSair_Click;
            btnSair2.Click += btnSair_Click;
            btnSair3.Click += btnSair_Click;
            btnSair4.Click += btnSair_Click;

        }

        List<Refrigerante> listaRefrigerante = new List<Refrigerante>();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                    string.IsNullOrWhiteSpace(txtPreco.Text) ||
                    string.IsNullOrWhiteSpace(txtQtdEstoque.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.");
                    return;
                }

                string nome = txtNome.Text;
                double preco = double.Parse(txtPreco.Text);
                int quantidade = int.Parse(txtQtdEstoque.Text);

                Refrigerante novo = new Refrigerante(nome, preco, quantidade);
                listaRefrigerante.Add(novo);

                MessageBox.Show("Refrigerante cadastrado com sucesso!");

                txtNome.Clear();
                txtPreco.Clear();
                txtQtdEstoque.Clear();

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Formato inválido: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar refrigerante: " + ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvEstoque.DataSource = null;
            dgvEstoque.DataSource = listaRefrigerante;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeBuscado = txtNomeVenda.Text;
                int qtdVendida = int.Parse(txtQtdVenda.Text);

                Refrigerante r = listaRefrigerante.FirstOrDefault(x => x.Nome == nomeBuscado);

                if (r == null)
                {
                    MessageBox.Show("Refrigerante não encontrado.");
                    return;
                }

                if (r.Quantidade < qtdVendida)
                {
                    MessageBox.Show("Estoque insuficiente para a venda.");
                    return;
                }

                double total = r.Preco * qtdVendida;
                r.Quantidade -= qtdVendida;

                MessageBox.Show($"Venda realizada com sucesso! Total: R$ {total:F2}");

                txtNomeVenda.Clear();
                txtQtdVenda.Clear();

                dgvEstoque.DataSource = null;
                dgvEstoque.DataSource = listaRefrigerante;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Formato inválido: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar venda: " + ex.Message);
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            string nomeBuscado = txtProcurar.Text;

            var resultado = listaRefrigerante.Where(r => r.Nome.Contains(nomeBuscado,
                StringComparison.OrdinalIgnoreCase)).ToList();

            if (resultado.Count == 0)
            {
                MessageBox.Show("Refrigerante não encontrado.");
                return;
            }

            txtProcurar.Clear();

            dgvProcurar.DataSource = null;
            dgvProcurar.DataSource = resultado;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string nomeExcluir = txtExcluir.Text;

            Refrigerante r = listaRefrigerante.FirstOrDefault(x => x.Nome == nomeExcluir);

            if (r == null)
            {
                MessageBox.Show("Refrigerante não encontrado.");
                return;
            }

            listaRefrigerante.Remove(r);
            MessageBox.Show("Refrigerante excluído com sucesso!");

            dgvEstoque.DataSource = null;
            dgvEstoque.DataSource = listaRefrigerante;

            txtExcluir.Clear();
        }
    }
}
