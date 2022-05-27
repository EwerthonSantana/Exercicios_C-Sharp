using System;
using System.Globalization;
using Conta_Bancaria.Entities;
using Conta_Bancaria.Entities.Exceptions;

namespace Conta_Bancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Entre com os dados da conta");
                Console.Write("Número: ");
                int accountNumber = int.Parse(Console.ReadLine());
                Console.Write("Titular: ");
                string accountHolder = Console.ReadLine();
                Console.Write("Depósito inicial: ");
                double accountInitialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Limite do saque: ");
                double accountWithdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new(accountNumber, accountHolder, accountInitialBalance, accountWithdrawLimit);
               
                Console.Write("Informe o valor para saque: ");
                double accountWithdraw = double.Parse(Console.ReadLine());

                account.Withdraw(accountWithdraw);

                Console.WriteLine();
                Console.Write("Novo depósito: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));

            }
            catch(DomainException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
