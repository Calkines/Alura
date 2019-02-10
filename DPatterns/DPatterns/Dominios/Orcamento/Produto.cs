using System;
using System.Collections.Generic;
using System.Text;

namespace DPatterns.Dominios.Orcamento {
    public class Produto {

        public string Descricao { get; set; }
        public double Valor { get; set; }

        public Produto(string descricao, double valor) {
            this.Descricao = descricao;
            this.Valor = valor;
        }
    }
}
