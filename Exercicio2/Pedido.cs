using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2
{
    internal class Pedido
    {
        public List<ItemMenu> Itens { get; set; } = new List<ItemMenu>();

        public void AdicionarItem(ItemMenu item)
        {
            Itens.Add(item);
        }

        public decimal CalcularTotal()
        {
            return Itens.Sum(i => i.CalcularPreco());
        }

        public List<object> ObterDadosParaGrid()
        {
            return Itens.Select(m => new
            {
                Titulo = m.Nome,
                PrecoBase = m.PrecoBase,
                PrecoFinal = m.CalcularPreco(),
                Tipo = m is Pizza ? "Pizza" : m is Hamburguer ? "Hamburguer" : "Bebida",
                Extra = m is Pizza ? ((Pizza)m).Tamanho :
                        m is Hamburguer ? ((Hamburguer)m).TipoCarne :
                        ((Bebida)m).Volume + " ml"
            }).ToList<object>();
        }

        public void ImprimirMessageBox()
        {
            if (Itens.Count == 0)
            {
                MessageBox.Show("Nenhum item no pedido!");
                return;
            }

            string dados = "";
            foreach (var m in Itens)
            {
                string tipo = m is Pizza ? "Pizza" : m is Hamburguer ? "Hamburguer" : "Bebida";
                string extra = m is Pizza ? ((Pizza)m).Tamanho :
                               m is Hamburguer ? ((Hamburguer)m).TipoCarne :
                               ((Bebida)m).Volume + " ml";

                dados += $"Nome: {m.Nome}\n" +
                         $"Preço Base: {m.PrecoBase:C}\n" +
                         $"Preço Final: {m.CalcularPreco():C}\n" +
                         $"Tipo: {tipo}\n" +
                         $"Extra: {extra}\n" +
                         $"-----------------------------\n";
            }

            dados += $"TOTAL: {CalcularTotal():C}";
            MessageBox.Show(dados, "Pedido");
        }
    }
}
