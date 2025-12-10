using System;
using System.Collections.Generic;
using System.Text;
using static Exercicio1.Enums;

namespace Exercicio1
{
    internal class Cachorro: Animal
    {
        public TipoRaca Raca { get; set; }

        public Cachorro(string nome, double peso, TipoRaca raca)
            : base(nome, peso)
        {
            Raca = raca;
        }

        public override string ImprimeDados()
        {
            return base.ImprimeDados() + $"\nRaça: {Raca}";
        }
    }
}
