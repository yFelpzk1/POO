using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1
{
    internal abstract class Midia
    {
        private string titulo;
        private int duracao;

        public string Titulo { get => titulo; set => titulo = value; }
        public int Duracao { get => duracao; set => duracao = value; }

        public Midia(string titulo, int duracao)
        {
            this.titulo = titulo;
            this.duracao = duracao;
        }

        public abstract string Reproduzir();
    }
}
