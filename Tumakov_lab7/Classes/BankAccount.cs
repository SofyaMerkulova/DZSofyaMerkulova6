using System;

namespace Tumakov_lab7
{
    internal class BankAccount
    {
        private string accountNumber;
        private double balance;
        private AccountType accountType;
        public enum AccountType
        {
            Текущий,
            Сберегательный
        }
        public BankAccount(string accountNumber, double balance, AccountType accountType)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.accountType = accountType;
        }
        public string GetAccountNumber()
        {
            return accountNumber;
        }
        public double GetBalance()
        {
            return balance;

        }
        public AccountType GetAccountType()
        {
            return accountType;
        }
        public void InfoAccount()
        {
            Console.WriteLine($"Ваш номер счёта: {accountNumber}");
            Console.WriteLine($"Баланс счёта: {balance}");
            Console.WriteLine($"Тип вашего счёта: {accountType}");
        }
    }
}
