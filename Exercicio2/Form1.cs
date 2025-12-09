namespace Exercicio2
{
    public partial class Form1 : Form
    {
        private Pedido pedido = new Pedido();
        public Form1()
        {
            InitializeComponent();
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cboTipo.SelectedItem.ToString();

            if (tipo == "Pizza")
            {
                txtTamanho.Enabled = true;
                txtTipoCarne.Enabled = false;
                txtVolume.Enabled = false;
                txtTipoCarne.Clear();
                txtVolume.Clear();
            }
            else if (tipo == "Hamburguer")
            {
                txtTamanho.Enabled = false;
                txtTipoCarne.Enabled = true;
                txtVolume.Enabled = false;
                txtTamanho.Clear();
                txtVolume.Clear();
            }
            else if (tipo == "Bebida")
            {
                txtTamanho.Enabled = false;
                txtTipoCarne.Enabled = false;
                txtVolume.Enabled = true;
                txtTamanho.Clear();
                txtTipoCarne.Clear();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string tipo = cboTipo.SelectedItem.ToString();
                string nome = txtNome.Text;
                decimal preco = decimal.Parse(txtPrecoBase.Text);

                if(tipo == "Pizza")
                {
                    string tamanho = txtTamanho.Text;
                    var pizza = new Pizza(nome, preco, tamanho);
                    pedido.AdicionarItem(pizza);
                }
                else if(tipo == "Hamburguer")
                {
                    string carne = txtTipoCarne.Text;
                    var burguer = new Hamburguer(nome, preco, carne);
                    
                    pedido.AdicionarItem(burguer);
                }
                else if(tipo == "Bebida")
                {
                    int volume = int.Parse(txtVolume.Text);
                    var bebida = new Bebida(nome, preco, volume);
                    pedido.AdicionarItem(bebida);
                }

                MessageBox.Show("Pedido Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro inesperado" + ex.Message);
            }

            txtNome.Clear();
            txtPrecoBase.Clear();
            txtTipoCarne.Clear();
            txtTamanho.Clear();
            txtVolume.Clear();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            var dados = pedido.ObterDadosParaGrid();
            dgvImprimir.DataSource = null;
            dgvImprimir.DataSource = dados;
        }

        private void btnCadastrarM_Click(object sender, EventArgs e)
        {
            pedido.ImprimirMessageBox();
        }
    }
}
