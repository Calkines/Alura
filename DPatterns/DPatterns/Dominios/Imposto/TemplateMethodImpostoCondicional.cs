using DPatterns.Dominios.Interfaces;
using DPatterns.Dominios.Orcamento;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPatterns.Dominios.Imposto {
    public abstract class TemplateMethodImpostoCondicional : IImposto {
        public double Calcular(Orcamento.Orcamento orcamento) {
            if (DeveUsarTaxacaoMaxima(orcamento)) {
                return TaxacaoMaxima(orcamento);
            }
            return TaxacaoMinima(orcamento);
        }

        public abstract bool DeveUsarTaxacaoMaxima(Orcamento.Orcamento orcamento);
        public abstract double TaxacaoMaxima(Orcamento.Orcamento orcamento);
        public abstract double TaxacaoMinima(Orcamento.Orcamento orcamento);
    }
}
