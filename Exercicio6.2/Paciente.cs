using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    public class Paciente
    {
        public string Nome { get; set; } = string.Empty;
        public double Peso { get; set; }
        public double Altura { get; set; }

        public Paciente(string nome, double peso, double altura)
        {
            this.Nome = nome;
            this.Peso = peso;
            this.Altura = altura;
        }

        public double CalcularIMC()
        {
            if (this.Altura <= 0)
            {
                return 0;
            }
            return this.Peso / (this.Altura * this.Altura);
        }

        public string ClassificarIMC()
        {
            double imc = this.CalcularIMC();

            if (imc < 18.5) return "abaixo do peso";
            if (imc >= 18.6 && imc <= 24.9) return "Peso ideal (parabéns)";
            if (imc >= 25.0 && imc <= 29.9) return "Levemente acima do peso";
            if (imc >= 30.0 && imc <= 34.9) return "Obesidade grau I";
            if (imc >= 35.0 && imc <= 39.9) return "Obesidade grau II (severa)";
            return "Obesidade III (mórbida)";
        }

        public string ImprimirDados()
        {
            double imc = CalcularIMC();
            string classificacao = ClassificarIMC();

            return $"--- Dados do Paciente ---\n" +
                   $"Nome: {this.Nome}\n" +
                   $"Peso: {this.Peso} kg\n" +
                   $"Altura: {this.Altura} m\n\n" +
                   $"IMC Calculado: {imc:F2}\n" +
                   $"Classificação: {classificacao}";
        }
    }
}
