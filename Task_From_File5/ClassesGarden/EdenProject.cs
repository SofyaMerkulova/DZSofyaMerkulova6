using System;
using System.Reflection.Emit;

namespace Task_From_File5.ClassesGarden
{
    using System;

    internal class EdenProject : BotanicalGarden
    {
        public EdenProject(string name, string region, int numberOfArea, int age)
            : base(name, region, numberOfArea, age)
        { }
        public override void PlantingNewPlants(string[,] newPlants)
        {
            Console.WriteLine($"В ботаническом саде {Name} сажают новые растения:");
            for (int i = 0; i < newPlants.GetLength(0); i++)
            {
                Console.WriteLine($" * {newPlants[i, 0]}");
            }
        }
        public override void WateringPlants(double soilMoisture)
        {
            if (soilMoisture < 80)
            {
                Console.WriteLine("Поливаем растения до необходимой влажности: 80-95% (соответствует экваториальному поясу, где находится сад).");
            }
            else
            {
                Console.WriteLine("Поливка не требуется, влажность почвы достаточная.");
            }
        }
        public override void WeedingOfPlants(string[,] unnecessarySprouts)
        {
            Console.WriteLine("Удаляем ненужные ростки:");
            for (int i = 0; i < unnecessarySprouts.GetLength(0); i++)
            {
                Console.WriteLine($" * {unnecessarySprouts[i, 0]}");
            }
        }
        public override void FertilizingTheSoil(int fertilizer)
        {
            Console.WriteLine($"Удобряем почву, добавляем удобрения в количестве: {fertilizer} кг");
        }

        public override void GardenPlants(string[,] gardenPlants)
        {
            Console.WriteLine("Растения, растущие в данном ботаническом саду:");
            for (int i = 0; i < gardenPlants.GetLength(0); i++)
            {
                Console.WriteLine($" * {gardenPlants[i, 0]}");
            }
        }
        public string GetName()
        {
            return Name;
        }
        public string GetRegion()
        {
            return Region;
        }
        public int GetNumberOfArea()
        {
            return NumberOfArea;
        }
        public int GetAge()
        {
            return Age;
        }
        public void InfoEdenGarden()
        {
            Console.WriteLine($"Название ботанического сада: {Name}");
            Console.WriteLine($"Где он находится: {Region}");
            Console.WriteLine($"Сколько лет он существует: {Age}");
            Console.WriteLine($"Количество квадратных метров, которые занимает сад: {NumberOfArea}");
        }
    }



}