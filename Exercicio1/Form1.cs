namespace Exercicio1
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
                int num1 = int.Parse(txtNumero1.Text);
                int num2 = int.Parse(txtNumero2.Text);

                IOperacaoMatematica operacao;

                operacao = new Soma();

                int resultado =  operacao.Calcular(num1, num2);

                switch (cboSoma.Text)
                {
                    case "Soma":
                        operacao = new Soma();
                        break;
                    case "Subtração":
                        operacao = new Subtracao();
                        break;
                    case "Multiplicação":
                        operacao = new Multiplicacao();
                        break;
                    case "Divisão":
                        operacao = new Divisao();
                        break;
                }

                if (operacao != null)
                {
                    int res = operacao.Calcular(num1, num2);
                    MessageBox.Show("Resultado: " + res);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Erro inesperado:" + ex.Message);
            }
        }
    }
}
