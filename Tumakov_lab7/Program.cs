using System;
using Tumakov_lab7.Classes;
using static Tumakov_lab7.BankAccount;

namespace Tumakov_lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskFirst();
            SecondTask();
            ThirdTask();
            FourthTask();

        }
        static void TaskFirst()
        {
            /*Упражнение 7.1 Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип
            банковского счета (использовать перечислимый тип из упр. 3.1). Предусмотреть методы для
            доступа к данным – заполнения и чтения. Создать объект класса, заполнить его поля и
            вывести информацию об объекте класса на печать.*/
            Console.WriteLine("Упражнение 7.1");
            BankAccount yourAccount = new BankAccount("333999777", 533333333.789, AccountType.Текущий);
            Console.WriteLine("Информация о вашем счёте в банке: ");
            yourAccount.InfoAccount();
            Console.WriteLine(" ");

        }
        static void SecondTask()
        {
            /*Упражнение 7.2 Изменить класс счет в банке из упражнения 7.1 таким образом, чтобы
            номер счета генерировался сам и был уникальным. Для этого надо создать в классе
            статическую переменную и метод, который увеличивает значение этого переменной.*/
            Console.WriteLine("Упражнение 7.2");
            BankAccountRandom myAccount = new BankAccountRandom(53333333.789, BankAccountRandom.AccountTypeRandom.Текущий);
            Console.WriteLine("Информация о вашем счёте в банке: ");
            myAccount.InfoAccountR();
            Console.WriteLine(" ");
        }
        static void ThirdTask()
        {
            /*Упражнение 7.3 Добавить в класс счет в банке два метода: снять со счета и положить на
            счет. Метод снять со счета проверяет, возможно ли снять запрашиваемую сумму, и в случае
            положительного результата изменяет баланс.*/
            Console.WriteLine("Упражнение 7.3");
            BankAccountForTask7_3 yourAccount3 = new BankAccountForTask7_3("333999777", 53333333.789 , BankAccountForTask7_3.AccountType3.Текущий);
            Console.WriteLine("Информация о вашем счёте в банке: ");
            yourAccount3.InfoAccount3();
            yourAccount3.AccountReplenishment(10000000); 
            yourAccount3.WithdrawalFromTheAccount(600000);
            Console.WriteLine(" ");
        }
        static void FourthTask()
        {
            /*Домашнее задание 7.1 Реализовать класс для описания здания (уникальный номер здания,
            высота, этажность, количество квартир, подъездов). Поля сделать закрытыми,
            предусмотреть методы для заполнения полей и получения значений полей для печати.
            Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества
            квартир на этаже и т.д. Предусмотреть возможность, чтобы уникальный номер здания
            генерировался программно. Для этого в классе предусмотреть статическое поле, которое бы
            хранило последний использованный номер здания, и предусмотреть метод, который
            увеличивал бы значение этого поля.*/
            Console.WriteLine("Домашнее задание 7.1");
            Buildings buildings1 = new Buildings(100, 5 , 10 , 20);
            Buildings buildings2 = new Buildings(150, 3, 15 , 30);
            Buildings buildings3 = new Buildings(200, 4, 20, 40);
            Buildings buildings4 = new Buildings(300, 6, 25, 50);
            Buildings buildings5 = new Buildings(350, 7, 25, 50);
            Console.WriteLine("Информация о здании первом: ");
            buildings1.InfoBuildings();
            Console.WriteLine(" ");
            Console.WriteLine(" Информация о здании втором: ");
            buildings2.InfoBuildings();
            Console.WriteLine(" ");
            Console.WriteLine("Информация о третьем здании: ");
            buildings3.InfoBuildings();
            Console.WriteLine(" ");
            Console.WriteLine("Информация о четвертом здании: ");
            buildings4.InfoBuildings();
            Console.WriteLine(" ");
            Console.WriteLine("Информация о пятом здании: ");
            buildings5.InfoBuildings();
            Console.WriteLine(" ");
        }
    }
       
    }