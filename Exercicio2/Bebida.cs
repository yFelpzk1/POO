using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Exercicio2
{
    internal class Bebida: ItemMenu
    {
        private int volume;

        public int Volume { get => volume; set => volume = value; }

        public Bebida(string nome,decimal precoBase, int volume) :base(nome, precoBase)
        {
            Volume = volume;
        }

        public override decimal CalcularPreco()
        {
            if (Volume <= 300)
            {
                return PrecoBase + 2;
            }
            else if(Volume <= 600)
            {
                return PrecoBase + 4;
            }
            else return PrecoBase + 6;
        }
    }
}
