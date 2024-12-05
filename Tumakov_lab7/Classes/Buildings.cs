using System;

namespace Tumakov_lab7.Classes
{
    internal class Buildings
    {
        private int apartments;
        private int entraces;
        private int storey;
        private int height;
        private static int numberOfTheBuilding = 0;
        private int numberUnique;
        
        public Buildings( int apartments, int entraces, int storey, int height)
        {
            this.apartments = apartments;
            this.entraces = entraces;
            this.storey = storey;
            this.height = height;
            this.numberUnique= RandomNumberOfTheBuilding();
        }
        public static int RandomNumberOfTheBuilding()
        {
            return numberOfTheBuilding++;
        }
        public void Apartments(int apartments)
        {
            this.apartments = apartments;
        }
        public void Entrances(int entraces)
        {
            this.entraces = entraces;
        }
        public void Storey(int storey)
        {
            this.storey = storey;
        }
        public void Height(int height)
        {
            this.height = height;
        }
        public int GetApartmentsNumber()
        { 
            return this.apartments;
        }
        public int GetEntracesNumber()
        { 
            return this.entraces;
        }
        public int GetStoreyNumber()
        { 
            return this.storey;
        }
        public double GetHeightNumber()
        {
            return this.height;
        }
        public int GetRandomNumberOfTheBUilding()
        { 
            return this.numberUnique;
        }
        public int CalculateFloorHeight()
        {
            if (storey == 0) 
            {
                return 0;
            }
            else
            {
                return height / storey;
            }
        }
        public int CalculateApartmentsForOneEntrace()
        {
            if (entraces == 0)
            {
                return 0;
            }
            else
            {
                return apartments / entraces;
            }
        }
        public int CalculateApartmentsForOneStorey()
        {
            if (storey == 0)
            {
                return 0;
            }
            else
            {
                return apartments / storey;
            }
        } 
        public void InfoBuildings()
        {

            Console.WriteLine($"Количество квартир: {apartments}");
            Console.WriteLine($"Количество подъездов: {entraces}");
            Console.WriteLine($"Количество этажей: {storey}");
            Console.WriteLine($"Высота: {height}");
            Console.WriteLine($"Номер здания: {numberUnique}");
            Console.WriteLine($"Количество квартир на один подъезд: {CalculateApartmentsForOneEntrace()}");
            Console.WriteLine($"Количество квартир на один этаж: {CalculateApartmentsForOneStorey()}");
            Console.WriteLine($"Высота этажа: {CalculateFloorHeight()}");
        }





    }
}
