using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, double salario)
        {
            this.Nome = nome;
            this.Salario = salario;
        }

        public void AumentarSalario()
        {
            if (this.Salario <= 1500)
            {
                this.Salario *= 1.25;
            }
            else if (this.Salario > 1500 && this.Salario <= 4000)
            {
                this.Salario *= 1.20;
            }
            else if (this.Salario > 4000 && this.Salario <= 6500)
            {
                this.Salario *= 1.15;
            }
        }

        public string RetornarDados()
        {
            return $"Nome: {this.Nome}\nSalário Atualizado: {this.Salario:C}";
        }
    }
}