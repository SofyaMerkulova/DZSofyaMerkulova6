using System;
namespace Tumakov_lab7.Classes
{
    internal class BankAccountRandom
    {

        private string accountNumberRand;
        private double balanceRand;
        private AccountTypeRandom accountTypeRand;
        private static int accountNumberNewRand = 0;
        public enum AccountTypeRandom
        {
            Текущий,
            Сберегательный
        }
        public BankAccountRandom( double balanceRand, AccountTypeRandom accountTypeRand)
        {
            this.balanceRand = balanceRand;
            this.accountTypeRand = accountTypeRand;
            this.accountNumberRand = GenerateUniqueAccountNumber();
        }
        public static string GenerateUniqueAccountNumber()
        {
            accountNumberNewRand++;
            return $"Номер счёта:{accountNumberNewRand:D10}";
        }
        public string GetAccountNumberR()
        {
                return accountNumberRand;
        }
        public double GetBalanceR()
        {
                return balanceRand;

        }
        public AccountTypeRandom GetAccountTypeR()
        {
                return accountTypeRand;
        }

        public void InfoAccountR()
        {
                Console.WriteLine($"Ваш номер счёта: {accountNumberNewRand:D10}");
                Console.WriteLine($"Баланс счёта: {balanceRand}");
                Console.WriteLine($"Тип вашего счёта: {accountTypeRand}");
        }
        
    }
}

