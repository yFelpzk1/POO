using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2
{
    internal class Hamburguer: ItemMenu
    {
        private string tipoCarne;

        public string TipoCarne { get => tipoCarne; set => tipoCarne = value; }

        public Hamburguer(string nome, decimal precoBase, string tipoCarne) :base (nome, precoBase)
        {
            TipoCarne = tipoCarne;
        }

        public override decimal CalcularPreco()
        {
            switch (tipoCarne.ToLower())
            {
                case "bovina": return PrecoBase + 8;
                case "frango": return PrecoBase + 5;
                case "vegetariano": return PrecoBase + 6;
                default: return PrecoBase;
            }
        }
    }
}
