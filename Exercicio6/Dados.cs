using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    public class Dados
    {
        private string nome;
        private string sobrenome;
        private int idade;
        private string sexo;
        private string titulacao;
        private string naturalidade;
        private string endereco;
        private string cidade;
        private string estado;

        public Dados() { }

        public Dados(string nome, string sobrenome, int idade, string sexo, string titulacao, string naturalidade, string endereco, string cidade, string estado)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.idade = idade;
            this.sexo = sexo;
            this.titulacao = titulacao;
            this.naturalidade = naturalidade;
            this.endereco = endereco;
            this.cidade = cidade;
            this.estado = estado;
        }

        public string ImprimirDados()
        {
            return $"O(a){titulacao} {nome} é natural de {naturalidade} e hoje reside na rua {endereco} {cidade} {estado}";
        }
    }
}
