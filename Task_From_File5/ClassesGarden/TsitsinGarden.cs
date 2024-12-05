
using System;

namespace Task_From_File5.ClassesGarden
{
    internal class TsitsinGarden : BotanicalGarden
    {
        public TsitsinGarden(string name, string region, int numberOfArea, int age)
           : base(name, region, numberOfArea, age)
        { }
        public override void PlantingNewPlants(string[,] newPlantsTsi)
        {
            Console.WriteLine($"В ботаническом саде {Name} сажают новые растения:");
            for (int i = 0; i < newPlantsTsi.GetLength(0); i++)
            {
                Console.WriteLine($" * {newPlantsTsi[i, 0]}");
            }
        }
        public override void WateringPlants(double soilMoistureTsi)
        {
            if (soilMoistureTsi < 75)
            {
                Console.WriteLine("Поливаем растения до необходимой влажности: 75% (соответствует оптимальной влажности почвы, где находится сад).");
            }
            else
            {
                Console.WriteLine("Поливка не требуется, влажность почвы достаточная.");
            }
        }
        public override void WeedingOfPlants(string[,] unnecessarySproutsTsi)
        {
            Console.WriteLine("Удаляем ненужные ростки:");
            for (int i = 0; i < unnecessarySproutsTsi.GetLength(0); i++)
            {
                Console.WriteLine($" * {unnecessarySproutsTsi[i, 0]}");
            }
        }
        public override void FertilizingTheSoil(int fertilizerTsi)
        {
            Console.WriteLine($"Удобряем почву, добавляем удобрения в количестве: {fertilizerTsi} кг");
        }

        public override void GardenPlants(string[,] gardenPlantsTsi)
        {
            Console.WriteLine("Растения, растущие в данном ботаническом саду:");
            for (int i = 0; i < gardenPlantsTsi.GetLength(0); i++)
            {
                Console.WriteLine($" * {gardenPlantsTsi[i, 0]}");
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
        public void InfoTsitsinGarden()
        {
            Console.WriteLine($"Название ботанического сада: {Name}");
            Console.WriteLine($"Где он находится: {Region}");
            Console.WriteLine($"Сколько лет он существует: {Age}");
            Console.WriteLine($"Количество квадратных метров, которые занимает сад: {NumberOfArea}");
        }
    }
}
