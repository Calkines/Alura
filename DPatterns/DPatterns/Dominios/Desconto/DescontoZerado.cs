using DPatterns.Dominios.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPatterns.Dominios.Desconto {
    public class DescontoZerado : IDesconto{
        public IDesconto ProximoDesconto { get; set; }

        public double CalcularDesconto(Orcamento.Orcamento orcamento) {
            return 0;
        }
    }
}
