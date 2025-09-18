using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public class Retangulo
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Retangulo(double baseRet, double alturaRet)
        {
            this.Base = baseRet;
            this.Altura = alturaRet;
        }

        public double CalcularArea()
        {
            return this.Base * this.Altura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (this.Base + this.Altura);
        }

        public string RetornarValores()
        {
            return $"Base: {this.Base}\nAltura: {this.Altura}";
        }
    }
}