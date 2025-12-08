using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio
{
    internal class Designer: Funcionario
    {
        public override double CalcularSalario()
        {
            return SalarioBase * 1.15;
        }
    }
}
