using DPatterns.Dominios.Interfaces;
using System.Linq;

namespace DPatterns.Dominios.Desconto {
    public class DescontoOrcamentoMaiorQue500Reais : IDesconto {
        public IDesconto ProximoDesconto { get; set; }
        public double CalcularDesconto(Orcamento.Orcamento orcamento) {
            if (orcamento.Valor >= 500) {
                orcamento.Desconto += orcamento.Valor * 0.07;
            }
            return ProximoDesconto.CalcularDesconto(orcamento);
        }
    }
}
