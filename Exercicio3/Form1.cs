namespace Exercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rbMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMostrar.Checked)
            {
                panelCheckBoxes.Visible = true;
            }
        }

        private void rbEsconder_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEsconder.Checked)
            {
                panelCheckBoxes.Visible = false;
            }
        }
    }
}
