using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1
{
    internal class Musica: Midia
    {
        private string artista;

        public string Artista { get => artista; set => artista = value; }

        public Musica(string titulo, int duracao, string artista) : base(titulo, duracao)
        {
            this.artista = artista;
        }

        public override string Reproduzir()
        {
            return $"Reproduzindo música: {Titulo} de {Artista}";
        }
    }
}
