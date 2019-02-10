using DPatterns.Dominios.Interfaces;
using DPatterns.Dominios.Orcamento;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPatterns.Dominios.Imposto {
    public class IPVA : IImposto {
        public double Calcular(Orcamento.Orcamento orcamento) {
            return orcamento.Valor * 0.01;
        }
    }
}
