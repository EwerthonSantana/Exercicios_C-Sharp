using Conta_Bancaria.Entities.Exceptions;

namespace Conta_Bancaria.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                throw new DomainException("Erro: Valor do saque maior do que o saldo!");
            }
            if (amount > WithdrawLimit)
            {
                throw new DomainException("Erro: Valor do saque é maior do que o limite!");
            }

            Balance -= amount;
        }
    }
}
