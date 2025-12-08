namespace Exercicio
{
    public partial class Form1 : Form
    {
        List<Funcionario> listaFuncionarios = new List<Funcionario>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboCargo.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um cargo!");
                    return;
                }

                string nome = txtNome.Text;
                string cargo = cboCargo.SelectedItem.ToString();
                double salarioBase = double.Parse(txtSalarioBase.Text);

                Funcionario f;

                if (cargo == "Programador")
                {
                    f = new Programador();
                }
                else if (cargo == "Designer")
                {
                    f = new Designer();
                }
                else
                {
                    f = new Gerente();
                }

                f.Nome = nome;
                f.Cargo = cargo;
                f.SalarioBase = salarioBase;

                listaFuncionarios.Add(f);

                MessageBox.Show("Funcionário cadastrado com successo!");

                txtNome.Clear();
                txtSalarioBase.Clear();
                cboCargo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado" + ex.Message);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (listaFuncionarios.Count == 0)
            {
                MessageBox.Show("Nenhum funcionário cadastrado!");
                return;
            }

            string dados = "";

            foreach (Funcionario f in listaFuncionarios)
            {
                dados += "\nNome: " + f.Nome +
                        "\nCargo: " + f.Cargo +
                        "\nSalário Base: " + f.SalarioBase.ToString("C") +
                        "\nSalário Bruto: " + f.CalcularSalario().ToString("C") +
                        "\n--------------------------";
            }

            MessageBox.Show(dados, "Folha de Pagamento");
        }

        private void btnImprimirDGV_Click(object sender, EventArgs e)
        {
            if (listaFuncionarios.Count == 0)
            {
                MessageBox.Show("Nenhum funcionário cadastrado!");
                return;
            }

            var dados = listaFuncionarios.Select(f => new
            {
                Nome = f.Nome,
                Cargo = f.Cargo,
                SalarioBase = f.SalarioBase,
                SalarioBruto = f.CalcularSalario()
            }).ToList();

            dgvListagem.DataSource = null;   // limpa o grid
            dgvListagem.DataSource = dados;  // carrega os dados
        }
    }
}
