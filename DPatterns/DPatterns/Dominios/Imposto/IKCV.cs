using DPatterns.Dominios.Interfaces;
using DPatterns.Dominios.Orcamento;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPatterns.Dominios.Imposto {
    public class IKCV : TemplateMethodImpostoCondicional {        

        public override bool DeveUsarTaxacaoMaxima(Orcamento.Orcamento orcamento) {
            return orcamento.Valor > 500;
        }

        public override double TaxacaoMaxima(Orcamento.Orcamento orcamento) {
            return orcamento.Valor * 0.1;
        }

        public override double TaxacaoMinima(Orcamento.Orcamento orcamento) {
            return orcamento.Valor * 0.06;
        }
    }
}
