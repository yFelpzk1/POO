using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto
{
    internal class Produto
    {
        string nome;
        double preco;
        int quantidade;

        public string Nome { get => nome; set => nome = value; }
        public double Preco { get => preco; set => preco = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double CalcularTotal()
        {
            return Preco * Quantidade;
        }

        public string Imprimir()
        {
            return $"Produto: {Nome}\nPreço: R$ {Preco:F2}\nQuantidade: {Quantidade}\nTotal: R$ {CalcularTotal():F2}";
        }
    }
}
