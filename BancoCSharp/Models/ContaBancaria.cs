
using BancoCSharp.Enums;

namespace BancoCSharp.Models
{
    public abstract class ContaBancaria
    {
        #region Atributos

        public Titular Titular { get; set; }
        public double Saldo { get; private set; }
        public DateTime DataAbertura { get; private set; }
        protected List<Movimentacao> Movimentacoes { get; set; }


        protected readonly double VALOR_MINIMO = 10.0;//  protected o filho pode alterado de alguma forma 
        #endregion

        #region Construtor
        public ContaBancaria(Titular titular, double saldoAbertura)
        {
            Titular = titular;
            Saldo = saldoAbertura;
            DataAbertura = DateTime.Now;

            Movimentacoes = new List<Movimentacao>()
            {
               new Movimentacao(eTipoMovimentacao.ABERTURA_CONTA, saldoAbertura)
            };

            //var  movimentacao = new Movimentacao(eTipoMovimentacao.ABERTURA_CONTA, Saldo);  
            //Movimentacoes.Add(new Movimentacao(eTipoMovimentacao.ABERTURA_CONTA, Saldo));
        }

        public ContaBancaria(Titular titular)
        {
            Titular = titular;
            Saldo = 0;
            DataAbertura = DateTime.Now;

            Movimentacoes = new List<Movimentacao>()
            {
               new Movimentacao(eTipoMovimentacao.ABERTURA_CONTA, Saldo)
            };
        }
        #endregion

        #region Metodos
        public void Depositar(double valor)
        {
            if (valor < VALOR_MINIMO)
            {
                throw new Exception("O valor minimo para deposito é R$" + VALOR_MINIMO);
            }

            Saldo += valor;
            Movimentacoes.Add(new Movimentacao(eTipoMovimentacao.DEPOSITO, valor));
        }

        public double Sacar(double valor)
        {
            if (valor < VALOR_MINIMO)
            {
                throw new Exception("O valor minimo para saque é R$" + VALOR_MINIMO);

            }
            else if (valor > Saldo)
            {
                throw new Exception("Saldo insulficiente para Saque, Saldo atual R$" + Saldo);
            }

            Saldo -= valor;

            Movimentacoes.Add(new Movimentacao(eTipoMovimentacao.SAQUE, valor));

            return valor;
        }

        public void Transferir(ContaBancaria contaDestino, double valor)
        {
            if (valor < VALOR_MINIMO)
            {
                throw new Exception("Valor minimo para transferencia é de R$, Saldo atual é de R$" + VALOR_MINIMO);
            }
            else if (valor > Saldo)
            {
                throw new Exception();
            };

            contaDestino.Depositar(valor);
            Saldo -= valor;
            Movimentacoes.Add(new Movimentacao(eTipoMovimentacao.TRASNFERENCIA, valor));

        }

        public abstract void ImprimirExtrato();

        //Quando eh criado um methodo **virtual** quer dizer que esse methodo pode ser subescrito se quiser ou nao se o filho quiser

        // se **ABSTRACT** obrigado a todos os filhos implementar esse metodo 
    }
    #endregion
}

