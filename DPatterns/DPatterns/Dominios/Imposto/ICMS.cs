using DPatterns.Dominios.Interfaces;

namespace DPatterns.Dominios.Imposto {
    public class ICMS : IImposto{
        public double Calcular(Orcamento.Orcamento orcamento) {
            return orcamento.Valor * 0.18;
        }
    }
}
