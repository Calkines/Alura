using System;
using System.Collections.Generic;
using System.Text;

namespace DPatterns.Dominios.Requisicao {
    public class Requisicao {
        public Formato Formato { get; private set; }

        public Requisicao(Formato formato) {
            this.Formato = formato;
        }
    }

    public enum Formato {
        XML,
        CSV,
        PORCENTO
    }
}
