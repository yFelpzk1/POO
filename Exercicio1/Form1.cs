using static Exercicio1.Enums;

namespace Exercicio1
{
    public partial class Form1 : Form
    {
        private Cachorro cachorro;
        private Peixe peixe;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNomeCachorro.Text;
                double peso;

                if (!double.TryParse(txtPesoCachorro.Text, out  peso))
                {
                    MessageBox.Show("Peso Inválido. Digite um número.");
                    return;
                }

                string racaTexto = txtRacaCachorro.Text?.Trim();

                if (string.IsNullOrWhiteSpace(racaTexto))
                {
                    MessageBox.Show("Informe a raça: ViraLata, Poodle, Boxer, Pastor ou Labrador.");
                    return;
                }

                if (Enum.TryParse<TipoRaca>(racaTexto, true, out var raca))
                {
                    cachorro = new Cachorro(nome, peso, raca);
                    MessageBox.Show("Cachorro cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Raça Invalida. Use: ViraLata, Poodle, Boxer, Pastor ou Labrador.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado" + ex.Message);
            }
        }

        private void btnCadastrarPeixe_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNomePeixe.Text;
                double peso;

                if (!double.TryParse(txtPesoPeixe.Text, out peso))
                {
                    MessageBox.Show("Peso Inválido. Digite um número.");
                    return;
                }

                string tipoHabitat = txtHabitat.Text?.Trim();

                if (string.IsNullOrWhiteSpace(txtHabitat.Text))
                {
                    MessageBox.Show("Informe a raça: ViraLata, Poodle, Boxer, Pastor ou Labrador.");
                    return;
                }

                if (Enum.TryParse<TipoHabitat>(txtHabitat.Text, true, out var habitat))
                {
                    peixe = new Peixe(nome, peso, habitat);
                    MessageBox.Show("Cachorro cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Habitat Invalido. Use: AguaDoce,Salgada,Ornamental.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado" + ex.Message);
            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string dados = "";

            if (cachorro != null)
            {
                dados += "Cachorro: \n" + cachorro.ImprimeDados() + "\n\n";
            }
            else
            {
                dados += "Cachorro não encontrado. \n\n";
            }

            if(peixe != null)
            {
                dados += "Peixe:\n" + peixe.ImprimeDados() + "\n\n";
            }
            else
            {
                dados += "Peixe não encontrado";
            }

            MessageBox.Show(dados, "Dados dos animais");
        }
    }
}
