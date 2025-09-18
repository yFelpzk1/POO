using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Empregado
    {
        // Adicione '= string.Empty;' para inicializar as propriedades.
        public string Nome { get; set; } = string.Empty;
        public string Departamento { get; set; } = string.Empty;

        public double HorasTrabalhadasNoMes { get; set; }
        public double SalarioPorHora { get; set; }

        // O resto da classe continua igual...
        public double CalculaSalarioMensal()
        {
            return HorasTrabalhadasNoMes * SalarioPorHora;
        }

        public string MostraDados()
        {
            return $"Nome: {this.Nome}\n" +
                   $"Departamento: {this.Departamento}\n" +
                   $"Horas Trabalhadas: {this.HorasTrabalhadasNoMes}\n" +
                   $"Salário por Hora: {this.SalarioPorHora:C}";
        }
    }
}

