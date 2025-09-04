namespace Exercicio5
{
    public partial class Form1 : Form
    {
        private int numeroDeCliques = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClicar_Click(object sender, EventArgs e)
        {

            numeroDeCliques++;
            txtContagem.Text = numeroDeCliques.ToString();
        }
    }
}
