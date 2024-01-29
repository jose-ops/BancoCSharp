using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCSharp.Models
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(Titular titular) : base(titular)
        {
        }

        public ContaPoupanca(Titular titular, double saldoAbertura) : base(titular, saldoAbertura)
        {
        }

        public override void ImprimirExtrato()
        {
            Console.WriteLine("*****   Extrato ******");
            Console.WriteLine("*****Conta Poupança***");
            Console.WriteLine("**********************");
            Console.WriteLine();

            Console.WriteLine("Gerado em: " + DateTime.Now);
            Console.WriteLine();

            foreach (var movimentacao in Movimentacoes)
            {
                Console.WriteLine(movimentacao.ToString());
            }
            Console.WriteLine("saldo atual: " + Saldo);
            Console.WriteLine();
            Console.WriteLine("**********************");
            Console.WriteLine("*** Fim do extrato ***");
            Console.WriteLine("**********************");
            Console.WriteLine();
        }
    }
}
