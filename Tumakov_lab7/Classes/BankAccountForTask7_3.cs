using System;

namespace Tumakov_lab7.Classes
{
    internal class BankAccountForTask7_3
    {
        private string accountNumber3;
        private double balance3;
        private AccountType3 accountType3;
        public enum AccountType3
        {
            Текущий,
            Сберегательный
        }
        public BankAccountForTask7_3(string accountNumber3, double balance3, AccountType3 accountType3)
        {
            this.accountNumber3 = accountNumber3;
            this.balance3 = balance3;
            this.accountType3 = accountType3;
        }
        public string GetAccountNumber3()
        {
            return accountNumber3;
        }
        public double GetBalance3()
        {
            return balance3;

        }
        public AccountType3 GetAccountType3()
        {
            return accountType3;
        }
        public void InfoAccount3()
        {
            Console.WriteLine($"Ваш номер счёта: {accountNumber3}");
            Console.WriteLine($"Баланс счёта до пополнения или снятия: {balance3}");
            Console.WriteLine($"Тип вашего счёта: {accountType3}");
        }
        public void AccountReplenishment(double i)
        {
            balance3 += i;
            Console.WriteLine($"Баланс после пополнения: {balance3}");
        }
        public void WithdrawalFromTheAccount(double i)
        {
            if (i > balance3)
            {
                Console.WriteLine("Недостаточно средств,выберете сумму меньше");
                return;
            }

            balance3 -= i;
            Console.WriteLine($"Баланс после снятия: {balance3}");
        }
    }
}
