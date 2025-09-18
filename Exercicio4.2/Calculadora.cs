using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    public class Calculadora
    {
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }

        public Calculadora(double num1, double num2)
        {
            this.Numero1 = num1;
            this.Numero2 = num2;
        }

        public double Somar()
        {
            return this.Numero1 + this.Numero2;
        }

        public double Subtrair()
        {
            return this.Numero1 - this.Numero2;
        }

        public double Multiplicar()
        {
            return this.Numero1 * this.Numero2;
        }

        public double Dividir()
        {
            if (this.Numero2 == 0)
            {
                throw new DivideByZeroException("Não é possível dividir por zero.");
            }
            return this.Numero1 / this.Numero2;
        }
    }
}