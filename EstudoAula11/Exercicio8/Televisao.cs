using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace Exercicio8
{
    public class Televisao
    {
        private string marca;
        private string modelo;
        private DateTime data_lancamento;
        private double preco;
        private bool lcd;
        private double polegadas;


        public Televisao() { }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public DateTime Data_lancamento
        {
            get { return data_lancamento; }
            set { data_lancamento = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public bool Lcd
        {
            get { return lcd; }
            set { lcd = value; }
        }

        public double Polegadas
        {
            get { return polegadas; }
            set { polegadas = value; }
        }

        public double PrecoVenda()
        {
            return preco * 1.10;
        }
    }
}
