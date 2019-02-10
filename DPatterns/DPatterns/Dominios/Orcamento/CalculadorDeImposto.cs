using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DPatterns.Dominios.Interfaces;

namespace DPatterns.Dominios.Orcamento {
    public class CalculadorDeImposto {
        public double CalcularImpostos(Orcamento orcamento, IImposto Imposto) {
            return Imposto.Calcular(orcamento);
        }
    }
}
