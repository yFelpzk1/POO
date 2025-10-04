using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alula10Exercicio6
{
    public class Aluno
    {
        private string codigo;
        private string nome;
        private double nota1;
        private double nota2;
        private double media;

        public Aluno() { }

        public Aluno(string codigo, string nome, double nota1, double nota2)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.nota1 = nota1;
            this.nota2 = nota2;
        }   

        public void CalcularMedia()
        {
            media = (nota1 + nota2) / 2;
        }

        public string VerificarAprovacao()
        {
          if (media >= 6)
          {
            return "Aprovado";
          }
          else
          {
            return "Reprovado";
          }
        }

        public string ImprimirDados()
        {
            return $"Código: {codigo}\nNome: {nome}\nNota 1: "  +
                $" {nota1}\nNota 2: {nota2}\nMédia: {media}\nSituação: {VerificarAprovacao()}";
        }
    }
}
