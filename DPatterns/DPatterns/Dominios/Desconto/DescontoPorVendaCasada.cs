using DPatterns.Dominios.Interfaces;
using DPatterns.Dominios.Orcamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPatterns.Dominios.Desconto {
    public class DescontoPorVendaCasada : IDesconto {
        public IDesconto ProximoDesconto { get; set; }

        public double CalcularDesconto(Orcamento.Orcamento orcamento) {
            bool possuiCaneta = orcamento.Produtos.Any(x => x.Descricao == "CANETA");
            bool possuiLapis = orcamento.Produtos.Any(x => x.Descricao == "LAPIS");
            if (possuiCaneta && possuiLapis) {
                orcamento.Desconto += orcamento.Valor * 0.05;
            }
            return ProximoDesconto.CalcularDesconto(orcamento);
        }
    }
}
