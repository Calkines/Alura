using DPatterns.Dominios.Interfaces;
using DPatterns.Dominios.Orcamento;
using System.Linq;

namespace DPatterns.Dominios.Desconto {
    public class CalculadoraDeDesconto {
        public double CalcularDesconto(Orcamento.Orcamento orcamento) {

            DescontoOrcamentoMaiorQue500Reais d1 = new DescontoOrcamentoMaiorQue500Reais();
            DescontoPorMaisDeCincoItens d2 = new DescontoPorMaisDeCincoItens();
            DescontoPorVendaCasada d3 = new DescontoPorVendaCasada();
            DescontoZerado descontoFinal = new DescontoZerado();
            d1.ProximoDesconto = d2;
            d2.ProximoDesconto = d3;
            d3.ProximoDesconto = descontoFinal;

            return d1.CalcularDesconto(orcamento);
        }
    }
}
