using DPatterns.Dominios.DadosBancarios;
using DPatterns.Dominios.Requisicao;

namespace DPatterns.Interfaces {
    public interface IFormatoArquivo {
        IFormatoArquivo proximoFormatoArquivo { get; }
        string GerarRespostaFormatada(Requisicao requisicao,Conta conta);
    }
}
