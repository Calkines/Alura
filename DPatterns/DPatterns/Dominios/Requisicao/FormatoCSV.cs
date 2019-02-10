using DPatterns.Dominios.DadosBancarios;
using DPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPatterns.Dominios.Requisicao {
    public class FormatoCSV : IFormatoArquivo {
        public IFormatoArquivo proximoFormatoArquivo { get; private set; }

        public FormatoCSV(IFormatoArquivo proximoFormatoArquivo) {
            this.proximoFormatoArquivo = proximoFormatoArquivo;
        }

        public string GerarRespostaFormatada(Requisicao requisicao, Conta conta) {
            if (requisicao.Formato == Formato.CSV) {
                return conta.Nome + ';' + conta.Saldo;
            }
            if (proximoFormatoArquivo != null) {
                return proximoFormatoArquivo.GerarRespostaFormatada(requisicao, conta);
            }
            return conta.ToString();
        }
    }
}
