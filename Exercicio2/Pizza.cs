using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2
{
    internal class Pizza : ItemMenu
    {
        private string tamanho;

        public string Tamanho { get => tamanho; set => tamanho = value; }

        public Pizza(string nome, decimal precoBase, string tamanho) : base(nome, precoBase)
        {
            Tamanho = tamanho;
        }

        public override decimal CalcularPreco()
        {
            switch (Tamanho.ToLower())
            {
                case "pequena": return PrecoBase + 5;
                case "media": return PrecoBase + 10;
                case "grande": return PrecoBase + 15;
                default: return PrecoBase;
            }
        }
    }
}
