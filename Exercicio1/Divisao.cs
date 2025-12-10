using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1
{
    internal class Divisao : IOperacaoMatematica
    {
        public int Calcular(int a, int b)
        {
            if (b == 0)
            {
                return 0; 
            }
            else
            {
                return a / b;
            }
            
        }
    }
}
