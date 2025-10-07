using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }

        // o método saldo está encapsulado pelos médotos Sacar(), Deposito() e
        // ExibirSaldo() que são os únicos que podem manipulá-lo diretamente
        private decimal saldo;

        public void Sacar(decimal valor)
        {
            Console.WriteLine($"Tentativa de saque de {valor:C}");
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine($"Saque realizado.");
            }
            else
            {
                Console.WriteLine($"Não foi possível realizar o saque. Verifique o seu saldo.");
            }
        }

        public void Deposito(decimal valor)
        {
            Console.WriteLine($"Tentativa de depósito de {valor:C}");
            saldo += valor;
            Console.WriteLine("Depósito realizado.");
        }
        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo disponível: {saldo:C}");
        }
    }
}