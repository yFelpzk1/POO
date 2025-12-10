using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1
{
    internal class Animal
    {
        private string nome;
        private double peso;

        public string Nome { get => nome; set => nome = value; }
        public double Peso { get => peso; set => peso = value; }

        public Animal(string nome, double peso)
        {
            Nome = nome;
            Peso = peso;
        }

        public virtual string ImprimeDados()
        {
            return $"Nome: {Nome} \nPeso: {Peso} kg";
        }
    }
}
