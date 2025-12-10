using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1
{
    internal class Multiplicacao : IOperacaoMatematica
    {
        public int Calcular(int a, int b)
        {
            return a * b;
        }
    }
}
