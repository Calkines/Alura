using DPatterns.Dominios.DadosBancarios;
using DPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPatterns.Dominios.Requisicao {
    public class GeradorDeRespostasFormatadas {
        public string GerarRespostaFormatada(Requisicao requisicao, Conta conta) {            
            
            IFormatoArquivo formatoPorcentagem = new FormatoPorcentagem();
            IFormatoArquivo formatoCSV = new FormatoCSV(formatoPorcentagem);
            IFormatoArquivo formatoXML = new FormatoXML(formatoCSV);            

            return formatoXML.GerarRespostaFormatada(requisicao,conta);
        }
    }
}
