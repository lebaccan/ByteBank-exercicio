using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank_exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente primeiraContaCorrente = new ContaCorrente();

            primeiraContaCorrente.saldo = 200;

            Console.WriteLine("Saldo Primeira Conta: " + primeiraContaCorrente.saldo);

            primeiraContaCorrente.saldo += 100;
            Console.WriteLine("Saldo Primeira Conta Atualizado: " + primeiraContaCorrente.saldo);

            ContaCorrente segundaContaCorrente = new ContaCorrente();

            segundaContaCorrente.saldo = 50;
            Console.WriteLine("Primeira Conta tem: " + primeiraContaCorrente.saldo);
            Console.WriteLine("Segunda Conta tem: " + segundaContaCorrente.saldo);



            Console.ReadLine();

        }
    }
}
