using DPatterns.Dominios.Interfaces;
using DPatterns.Dominios.Orcamento;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPatterns.Dominios.Imposto {
    public class ICPA : TemplateMethodImpostoCondicional {        

        public override bool DeveUsarTaxacaoMaxima(Orcamento.Orcamento orcamento) {
            return orcamento.Valor > 500 && possuiItemMaiorQue100Reais(orcamento);
        }

        public override double TaxacaoMaxima(Orcamento.Orcamento orcamento) {            
            return orcamento.Valor * 0.09;
        }

        public override double TaxacaoMinima(Orcamento.Orcamento orcamento) {
            return orcamento.Valor * 0.04;
        }

        private bool possuiItemMaiorQue100Reais(Orcamento.Orcamento orcamento) {
            foreach (var item in orcamento.Produtos) {
                if (item.Valor > 100) return true;                
            }
            return false;
        }
    }
}
