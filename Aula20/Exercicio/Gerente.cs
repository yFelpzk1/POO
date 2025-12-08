using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio
{
    internal class Gerente : Funcionario
    {
        public override double CalcularSalario()
        {
            return SalarioBase + 1000;
        }
    }
}
