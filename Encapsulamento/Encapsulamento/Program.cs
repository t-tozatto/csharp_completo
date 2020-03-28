using System;
using System.Globalization;

namespace Exercicio_Banco_Secao_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;
            Console.Write("Entre o número da conta: ");
            int numeroConta = Convert.ToInt16(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            if (Console.ReadLine().Equals("s"))
            {
                Console.Write("Entre o valor de depósito inicial: ");
                conta = new Conta(numeroConta, titular, Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture));
            }
            else
                conta = new Conta(numeroConta, titular);

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.Write(conta);

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            conta.Deposito(Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            conta.Saque(Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}
