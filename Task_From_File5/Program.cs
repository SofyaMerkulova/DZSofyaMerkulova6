using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_From_File5.ClassesGarden;

namespace Task_From_File6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Написать программу, в которой реализованы все принципы ООП. Для этого
            необходимо реализовать не менее 4 классов:реализовать не менее 4 классов:
           ● Один должен быть абстрактным
           ● Должно быть не менее 2 наследников
           ● Не менее 5 методов в каждом классе (необходимо показать свойство на
           чтение и на чтение-запись)
           ● Не менее 4 свойств
           ● Должно быть не менее 2 конструкторов в классах наследниках 
           В Main создать объекты классов, показать работу методов.*/
           Console.WriteLine("Задание 1");
                        
           EdenProject edenProject = new EdenProject("Райский сад", "Корнуолл", 22000 , 23);
            Console.WriteLine("Информация о первом саде: ");
           edenProject.InfoEdenGarden();
            string[,] newPlants = new string[,] { { "Олива" }, { "Цветы Прерий" }, { "Виноградная лоза" } };
            edenProject.PlantingNewPlants(newPlants);

            string[,] unnecessarySprouts = new string[,] { { "Ромашка" }, { "Одуванчик" } };
            edenProject.WeedingOfPlants(unnecessarySprouts);

            string[,] gardenPlants = new string[,]
            {
            { "Подсолнух" }, { "Лаванда" }, { "Чай" }, { "Пшеница" },
            { "Рожь" }, { "Кукуруза" }, { "Каучуковое дерево" }, { "Бамбук" },
            { "Бананы" }, { "Кофейные деревья" }, { "и другие растения" }};
            edenProject.GardenPlants(gardenPlants);
            edenProject.WateringPlants(75);
            edenProject.FertilizingTheSoil(5);
            Console.WriteLine(" ");

            TsitsinGarden tsitsinGarden = new TsitsinGarden("Главный ботанический сад имени Н. В. Цицина РАН", "Москва", 3610000, 79);
            Console.WriteLine("Информация о втором саде: ");
            tsitsinGarden.InfoTsitsinGarden();
            string[,] newPlantsTsi = new string[,] { { "Дуб" }, { "Роза" }, { "Хризантема" } };
            tsitsinGarden.PlantingNewPlants(newPlantsTsi);

            string[,] unnecessarySproutsTsi = new string[,] { { "Молочай" }, { "Подорожник" } };
            tsitsinGarden.WeedingOfPlants(unnecessarySproutsTsi);

            string[,] gardenPlantsTsi = new string[,]
            {
            { "Георгины" }, { "Ель" }, { "Осина" }, { "Рябина" },
            { "Жимолость" }, { "Мхи" }, { "Лишайники" }, { "Плодово-ягодные культуры" },
            { "Ценные сортовые розы" }, { "Луговые и лесные цветы" }, { "и другие растения" }};
            tsitsinGarden.GardenPlants(gardenPlantsTsi);
            tsitsinGarden.WateringPlants(75);
            tsitsinGarden.FertilizingTheSoil(820);
        }
    }
}
