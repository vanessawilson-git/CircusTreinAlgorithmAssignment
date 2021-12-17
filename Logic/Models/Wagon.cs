using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic.Classes
{
    public class Wagon
    {

        private List<Animal> WagonAnimals;

        private const int NrOfTotalSpaces = 10;

        private int _nrOfOccupiedSpaces = 0;

        private static int _idCount = 0;
        public int _wagonID { get; private set; }

       

        public Wagon()
        {
            WagonAnimals = new List<Animal>();
            _idCount++;
            _wagonID = _idCount;
        }


        public void AddAnimalToWagon(Animal animal)
        {
            if (CompatabilityCheck(animal) == false)
            {
                throw new Exception("Compatibility test was failed");
            }

            WagonAnimals.Add(animal);
            _nrOfOccupiedSpaces += (int) animal.Size;

        }

        public bool CompatabilityCheck(Animal animal)
        {
            return IsThereEnoughSpace(animal) && SafeWithOtherAnimalsInWagon(animal);
        }

        private bool IsThereEnoughSpace(Animal animal)
        {
            return _nrOfOccupiedSpaces + (int) animal.Size <= NrOfTotalSpaces;
        }

        private bool SafeWithOtherAnimalsInWagon(Animal animal)
        {
            if (animal.Diet != Diet.Herbivore)
            {
                if (ContainsMeatEater())
                {
                    return false;
                }

                return !ContainsSmallerOrEvenCreatures(animal);
            }

            return !ContainBiggerOrEvenMeatEaters(animal);
        }

        private bool ContainsMeatEater()
        {
            return WagonAnimals.Any(animal => animal.Diet != Diet.Herbivore);
        }

        private bool ContainsSmallerOrEvenCreatures(Animal animal)
        {
            return WagonAnimals.Any(animal1 => (int) animal1.Size <= (int) animal.Size);
        }

        private bool ContainBiggerOrEvenMeatEaters(Animal animal)
        {
            return WagonAnimals.Any(
                animal1 => animal1.Diet != Diet.Herbivore && (int) animal1.Size >= (int) animal.Size);
        }

        public IEnumerable<Animal> GetWagonAnimals()
        {
            return WagonAnimals;
        }

    }
}
