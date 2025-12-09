using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1
{
    internal class Playlist
    {
        private List<Midia> midias = new List<Midia>();


        public void AdicionarMidia(Midia m)
        {
            midias.Add(m);
        }

        public void RemoverMidia(string titulo)
        {
            Midia item = midias.FirstOrDefault(m =>
            m.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));

            if (item != null)
            {
                midias.Remove(item);
                MessageBox.Show("Mídia removida com sucesso!");
            }
            else
            {
                MessageBox.Show("Título não encontrado.");
            }
        }

        public void ExibirPlaylist()
        {
            if (midias.Count == 0)
            {
                MessageBox.Show("Playlist vazia!");
                return;
            }

            string dados = "";
            foreach (Midia m in midias)
            {
                string tipo = m is Musica ? "Musica" : "Podcast";
                string extra = m is Musica ? ((Musica)m).Artista : ((Podcast)m).Apresentador;
                dados += $"Título: {m.Titulo}\n" +
                 $"Duração: {m.Duracao} min\n" +
                 $"Tipo: {tipo}\n" +
                 $"Artista/Apresentador: {extra}\n" +
                 $"Reprodução: {m.Reproduzir()}\n" +
                 $"-----------------------------\n";
            }

            MessageBox.Show(dados, "Playlist");
        }

        public List<Midia> ObterMidias()
        {
            return midias;
        }
    }
}
