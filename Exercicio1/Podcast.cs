using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1
{
    internal class Podcast: Midia
    {
        private string apresentador;

        public string Apresentador { get => apresentador; set => apresentador = value; }

        public Podcast(string titulo, int duracao, string apresentador) : base(titulo, duracao)
        {
            this.apresentador = apresentador;
        }

        public override string Reproduzir()
        {
            return $"Reproduzindo podcast: {Titulo} apresentado por {Apresentador}";
        }
    }
}
