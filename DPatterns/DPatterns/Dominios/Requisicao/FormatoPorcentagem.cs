using DPatterns.Dominios.DadosBancarios;
using DPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPatterns.Dominios.Requisicao {
    public class FormatoPorcentagem : IFormatoArquivo {
        public IFormatoArquivo proximoFormatoArquivo { get; private set; }

        public FormatoPorcentagem(IFormatoArquivo proximoFormatoArquivo = null) {
            this.proximoFormatoArquivo = proximoFormatoArquivo;
        }

        public string GerarRespostaFormatada(Requisicao requisicao, Conta conta) {
            if (requisicao.Formato == Formato.PORCENTO) {
                return conta.Nome + '%' + conta.Saldo;
            }
            else if(proximoFormatoArquivo != null) {
                return proximoFormatoArquivo.GerarRespostaFormatada(requisicao, conta);
            }
            return conta.ToString();            
        }

    }
}
