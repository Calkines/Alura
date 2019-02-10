using DPatterns.Dominios.DadosBancarios;
using DPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPatterns.Dominios.Requisicao {
    public class FormatoXML : IFormatoArquivo {
        public IFormatoArquivo proximoFormatoArquivo { get; private set; }

        public FormatoXML(IFormatoArquivo proximoFormatoArquivo) {
            this.proximoFormatoArquivo = proximoFormatoArquivo;
        }

        public string GerarRespostaFormatada(Requisicao requisicao, Conta conta) {
            if (requisicao.Formato == Formato.XML) {
                StringBuilder sXml = new StringBuilder();
                sXml.AppendLine("<Conta>");
                sXml.AppendLine($"<{nameof(conta.Nome)}> {conta.Nome} </{nameof(conta.Nome)}>");
                sXml.AppendLine($"<{nameof(conta.Saldo)}> {conta.Saldo} </{nameof(conta.Saldo)}>");
                sXml.AppendLine("</Conta>");
                return sXml.ToString();
            }
            if (proximoFormatoArquivo != null) {
                return proximoFormatoArquivo.GerarRespostaFormatada(requisicao, conta);
            }
            return conta.ToString();
        }
    }
}
