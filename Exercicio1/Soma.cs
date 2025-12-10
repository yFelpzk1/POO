using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1
{
    internal class Soma : IOperacaoMatematica
    {
        public int Calcular(int a,int b)
        {
            return a + b;
        }
    }
}
