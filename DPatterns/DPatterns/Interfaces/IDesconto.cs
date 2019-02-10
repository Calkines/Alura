namespace DPatterns.Dominios.Interfaces {
    public interface IDesconto {
        IDesconto ProximoDesconto { get; set; }
        double CalcularDesconto(Orcamento.Orcamento orcamento);
    }
}