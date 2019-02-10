using DPatterns.Dominios.Interfaces;
using System.Linq;

namespace DPatterns.Dominios.Imposto {
    public class ISS : IImposto {        

        public double Calcular(Orcamento.Orcamento orcamento) {           
            return orcamento.Valor * 0.04;
        }
    }
}
