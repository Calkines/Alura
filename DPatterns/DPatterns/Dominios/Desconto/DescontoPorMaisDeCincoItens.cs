using DPatterns.Dominios.Interfaces;
using DPatterns.Dominios.Orcamento;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPatterns.Dominios.Desconto {
    class DescontoPorMaisDeCincoItens : IDesconto {
        public IDesconto ProximoDesconto { get; set; }

        public double CalcularDesconto(Orcamento.Orcamento orcamento) {
            if (orcamento.Produtos.Count > 5) {
                orcamento.Desconto += orcamento.Valor * 0.05;
            }
            return ProximoDesconto.CalcularDesconto(orcamento);
        }
    }
}
