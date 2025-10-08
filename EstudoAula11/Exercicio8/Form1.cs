namespace Exercicio8
{
    public partial class Form1 : Form
    {
        Televisao tv;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                tv = new Televisao();

                tv.Marca = txtMarca.Text;
                tv.Modelo = txtModelo.Text;
                tv.Data_lancamento = DateTime.Parse(txtDataLancamento.Text);
                tv.Preco = double.Parse(txtPreco.Text);
                tv.Lcd = chkLcd.Checked;
                tv.Polegadas = double.Parse(txtPolegadas.Text);
                double precoVenda = tv.PrecoVenda();

                MessageBox.Show($"O preço de venda da TV {tv.Marca} {tv.Modelo} é: R$ {precoVenda:F2}");
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
