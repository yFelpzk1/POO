using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio
{
    internal class Funcionario
    {
        private string nome;
        private string cargo;
        private double salarioBase;

        public string Nome { get => nome; set => nome = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public double SalarioBase { get => salarioBase; set => salarioBase = value; }

        public virtual double CalcularSalario()
        {
            return SalarioBase;
        }
    }
}
