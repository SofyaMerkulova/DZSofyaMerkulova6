using System;

namespace Task_From_File5.ClassesGarden
{
    internal abstract class BotanicalGarden
    {
        public string Name { get; set; }
        public string Region { get; private set; }
        public int NumberOfArea { get; set; }
        public int Age { get; set; }
        public BotanicalGarden(string name, string region, int numberOfArea, int age)
        {
            Name = name;
            Region = region;
            NumberOfArea = numberOfArea;
            Age = age;
        }
        public abstract void PlantingNewPlants(string[,] newPlants);
        public abstract void WateringPlants(double soilMoisture);
        public abstract void WeedingOfPlants(string[,] unnecessarySprouts);
        public abstract void FertilizingTheSoil(int fertilizer);
        public abstract void GardenPlants(string[,] gardenPlants);
    }
}


