using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Exercicio1
{
    public partial class Form1 : Form
    {

        private Playlist playlist = new Playlist();
        public Form1()
        {
            InitializeComponent();

        }

        private void cboTipoMidia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cboTipoMidia.SelectedItem.ToString();

            if (tipo == "Musica")
            {
                txtArtista.Enabled = true;
                txtApresentador.Enabled = false;
                txtApresentador.Clear();
            }
            else if (tipo == "Podcast")
            {
                txtApresentador.Enabled = true;
                txtArtista.Enabled = false;
                txtArtista.Clear();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string titulo = txtTitulo.Text;
                int duracao = int.Parse(txtDuracao.Text);

                if (cboTipoMidia.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um tipo de mídia.");
                    return;
                }

                if (cboTipoMidia.SelectedItem.ToString() == "Musica")
                {
                    string artista = txtArtista.Text;
                    Musica m = new Musica(titulo, duracao, artista);
                    playlist.AdicionarMidia(m);
                }
                else if (cboTipoMidia.SelectedItem.ToString() == "Podcast")
                {
                    string apresentador = txtApresentador.Text;
                    Podcast p = new Podcast(titulo, duracao, apresentador);
                    playlist.AdicionarMidia(p);
                }

                MessageBox.Show("Midia adicionada à playlist!");

                txtTitulo.Clear();
                txtDuracao.Clear();
                txtArtista.Clear();
                txtApresentador.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            var dados = playlist.ObterMidias()
            .Select(m => new
        {
            Titulo = m.Titulo,
            Duracao = m.Duracao,
            Tipo = m is Musica ? "Música" : "Podcast",
            ArtistaOuApresentador = m is Musica ? ((Musica)m).Artista : ((Podcast)m).Apresentador,
            Reproducao = m.Reproduzir()
        }).ToList();

            dgvExibir.DataSource = null;
            dgvExibir.DataSource = dados;
        }

        private void btnExibirM_Click(object sender, EventArgs e)
        {
            playlist.ExibirPlaylist();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string titulo = txtRemover.Text;

            if (string.IsNullOrWhiteSpace(titulo))
            {
                MessageBox.Show("Digite um titulo para remover!");
                return;
            }

            playlist.RemoverMidia(titulo);
        }
    }
}
