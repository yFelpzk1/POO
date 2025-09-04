namespace Exercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            List<string> gostos = new List<string>();

            if (chkDormir.Checked)
            {
                gostos.Add(chkDormir.Text);
            }
            if (chkComer.Checked)
            {
                gostos.Add(chkComer.Text);
            }
            if (chkCinema.Checked)
            {
                gostos.Add(chkCinema.Text);
            }
            if (chkLerLivro.Checked)
            {
                gostos.Add(chkLerLivro.Text);
            }
            if (chkEstudar.Checked)
            {
                gostos.Add(chkEstudar.Text);
            }

            if (gostos.Count > 0)
            {
                string resultadoFinal = string.Join(", ", gostos);

                MessageBox.Show(resultadoFinal, "Gostos Selecionados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nenhuma opção foi selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
