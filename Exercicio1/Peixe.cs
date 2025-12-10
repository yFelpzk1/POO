using System;
using System.Collections.Generic;
using System.Text;
using static Exercicio1.Enums;

namespace Exercicio1
{
    internal class Peixe: Animal 
    {
        public TipoHabitat Habitat { get; set; }

        public Peixe(string nome, double peso, TipoHabitat habitat)
            : base(nome, peso)
        {
            Habitat = habitat;
        }

        public override string ImprimeDados()
        {
            return base.ImprimeDados() + $"\nHabitat: {Habitat}";
        }
    }
}
