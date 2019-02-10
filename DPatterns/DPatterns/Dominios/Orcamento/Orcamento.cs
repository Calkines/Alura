using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPatterns.Dominios.Orcamento {
    public class Orcamento {
        public double Valor
        {
            get
            {
                return Produtos.Sum(x => x.Valor);
            }
        }
        public double Desconto { get; set; }
        public List<Produto> Produtos { get; private set; }

        public Orcamento(List<Produto> produtos) {            
            this.Produtos = produtos;
        }
    }
}
