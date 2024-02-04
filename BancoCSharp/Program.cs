// See https://aka.ms/new-console-template for more information

using BancoCSharp.Enums;
using BancoCSharp.Models;

Console.WriteLine("**********************");
Console.WriteLine("*****Banco CSharp*****");
Console.WriteLine("**********************");
Console.WriteLine(  );

var titular01 = new Titular("jose pinto", "12345678901", "96587412", new Endereco
{
    CEP = "09877-120",
    Rua = "Rua da madeira",
    Numero = 21

});
var titular02 = new Titular("Maria pinto", "12345678234", "321345678", new Endereco
{
    CEP = "09877-120",
    Rua = "Rua da madeira",
    Numero = 21

});

var conta1 = new ContaCorrente(titular01, 100.0);
var conta2 = new ContaInvestimento(titular02);
var conta3 = new ContaPoupanca(titular02);

conta1.Depositar(10.0);
conta1.Sacar(50.0);
conta1.Depositar(100.0);
//conta2.Depositar(500.0);
//conta2.Sacar(1000.0);
//conta2.Transferir(conta3, 100.0);

//conta3.Sacar(25.0);

conta1.ImprimirExtrato();
conta2.ImprimirExtrato();
conta3.ImprimirExtrato();

