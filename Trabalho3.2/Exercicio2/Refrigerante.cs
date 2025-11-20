using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Refrigerante
    {
        string nome;
        double preco;
        int quantidade;

        public string Nome { get => nome; set => nome = value; }
        public double Preco { get => preco; set => preco = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }

        public Refrigerante(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        public double EfetuarVenda(int qtdVendida)
        {
            if (Quantidade >= qtdVendida)
            {
                Quantidade -= qtdVendida;
                return qtdVendida * Preco;

            }
            else
            {
                throw new InvalidOperationException("Quantidade insuficiente para a venda.");
            }
        }
    }
}
