using DPatterns.Dominios.DadosBancarios;
using DPatterns.Dominios.Desconto;
using DPatterns.Dominios.Imposto;
using DPatterns.Dominios.Orcamento;
using DPatterns.Dominios.Requisicao;
using System;

namespace DPatterns {
    class Program {
        static void Main(string[] args) {
            

            Console.WriteLine("Sistema de requisição com formato");

            Orcamento orc = new Orcamento(new System.Collections.Generic.List<Produto>() {
                new Produto("Maça",5.00),
                new Produto("Banana",2.50),
                new Produto("Kiwi", 12.00),
                new Produto("Manga", 7.00),
                new Produto("Pêra", 3.00),
                new Produto("Goiaba", 4.50),
                new Produto("LAPIS", 4.50),
                new Produto("CANETA", 4.50),
                new Produto("Televisor 50\"", 4660.50),
            });


            IKCV imp = new IKCV();

            CalculadorDeImposto cImposto = new CalculadorDeImposto();
            Console.WriteLine(cImposto.CalcularImpostos(orc, imp));


            Console.ReadKey();
        }
    }
}


//Console.WriteLine("Sistema de orçamentos teste");

//Orcamento orc = new Orcamento(new System.Collections.Generic.List<Produto>() {
//    new Produto("Maça",5.00),
//    new Produto("Banana",2.50),
//    new Produto("Kiwi", 12.00),
//    new Produto("Manga", 7.00),
//    new Produto("Pêra", 3.00),
//    new Produto("Goiaba", 4.50),
//    new Produto("LAPIS", 4.50),
//    new Produto("CANETA", 4.50),
//    new Produto("Televisor 50\"", 4660.50),
//});                                  


//CalculadoraDeDesconto cDesconto = new CalculadoraDeDesconto();
//cDesconto.CalcularDesconto(orc);
//Console.WriteLine($"O valor do desconto nesta compra é: {orc.Desconto.ToString("C")}.\nO total da compra é: {orc.Valor.ToString("C")}");



//Conta conta = new Conta("Rafael",1000);            

//Requisicao req = new Requisicao(Formato.PORCENTO);

//GeradorDeRespostasFormatadas gResp = new GeradorDeRespostasFormatadas();
//Console.WriteLine(gResp.GerarRespostaFormatada(req, conta));