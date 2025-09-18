using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Quadrado{
        public double Lado { get; set; }
        public double Area { get; private set; }
        public double Perimetro { get; private set; }

        public Quadrado(double lado)
        {
            this.Lado = lado;
        }

        public void CalcularArea()
        {
            this.Area = this.Lado * this.Lado;
        }

        public void CalcularPerimetro()
        {
            this.Perimetro = 4 * this.Lado;
        }

        public string Imprimir()
        {
            return $"--- Dados do Quadrado ---\n" +
                   $"Lado: {this.Lado}\n" +
                   $"Área: {this.Area}\n" +
                   $"Perímetro: {this.Perimetro}";
        }
    }
}
