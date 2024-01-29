using BancoCSharp.Enums;

namespace BancoCSharp.Models
{
    public class Movimentacao
    {
        private DateTime DataHoraMovimentacao { get; set; }
        private eTipoMovimentacao TipoMovimentacao { get; set; }
        private Double Valor { get; set; }

        public Movimentacao(eTipoMovimentacao tipoMovimentacao, double valor)
        {
            TipoMovimentacao = tipoMovimentacao;
            DataHoraMovimentacao = DateTime.Now;
            Valor = valor;

        }
        public override string ToString()
        {
            var valor = (this.TipoMovimentacao == eTipoMovimentacao.SAQUE ||
                         this.TipoMovimentacao == eTipoMovimentacao.TRASNFERENCIA )
                ? "R$ " + Valor //se true executa esse
                : "R$ " + Valor; // se false, esse

            return $"{DataHoraMovimentacao}hs, {TipoMovimentacao}______________{Valor}";
        }
    }
}
