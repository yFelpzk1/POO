using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    internal class Produto
    {
        private string nome;
        private double preco;
        private int quantidade;

        public Produto() { }

        public Produto(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        public void SetDados(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        public double CalcularValor()
        {
            double total = preco * quantidade;
            if (quantidade >= 11 && quantidade <= 20)
                total *= 0.9;
            else if (quantidade >= 21 && quantidade <= 50)
                total *= 0.8;
            else if (quantidade > 50)
                total *= 0.75;
            return total;
        }

        public string Imprimir()
        {
            return $"Produto: {nome}\nTotal a pagar: R$ {CalcularValor():F2}";
        }
    }
}