using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BancoCSharp.Models
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(Titular titular) : base(titular)
        {
        }

        public ContaCorrente(Titular titular, double saldoAbertura) : base(titular, saldoAbertura)
        {
        }

        public override void ImprimirExtrato() 
        {
            Console.WriteLine("*****  Extrato *******");
            Console.WriteLine("*****Conta Corrente***");
            Console.WriteLine("**********************");
            Console.WriteLine();

            Console.WriteLine("Gerado em: " + DateTime.Now);
            Console.WriteLine();

            foreach(var movimentacao in Movimentacoes)
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

        //metodo override subescrevendo 
    }
}
