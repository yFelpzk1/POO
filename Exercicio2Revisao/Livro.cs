using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Livro
    {
        private int codigo;
        private string titulo;
        private double preco;
        
        public Livro(int codigo)
        {
            this.codigo = codigo;
        }

        public Livro(int codigo, string titulo)
        {
            this.codigo = codigo;
            this.titulo = titulo;
        }

        public Livro(int codigo, string titulo, double preco)
        {
            this.codigo = codigo;
            this.titulo = titulo;
            this.preco = preco;
        }

        public string GetInfo()
        {
            return $"Código: {codigo} | Título: {titulo} | Preço: {preco:C}";
        }

        public string GetTitulo()
        {
            return titulo;
        }

        public double GetPreco()
        {
            return preco;
        }
        public void SetPreco(double preco)
        {
            this.preco = preco;
        }

    }
}
