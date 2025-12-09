using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2
{
    internal abstract class ItemMenu
    {
        private string nome;
        private decimal precoBase;

        public string Nome { get => nome; set => nome = value; }
        public decimal PrecoBase { get => precoBase; set => precoBase = value; }

        public ItemMenu(string nome, decimal precoBase)
        {
            Nome = nome;
            PrecoBase = precoBase;
        }

        public abstract decimal CalcularPreco();
    }
}
