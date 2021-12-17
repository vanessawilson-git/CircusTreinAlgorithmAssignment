using System;
using System.Collections.Generic;
using System.Linq;
using Logic.Classes;
using Logic.LogicInterfaces;

namespace Logic.SortingAlgorithm
{
    public class AnimalSorter : IAnimalSorter
    {
        
        private List<Wagon> Wagons;

        public AnimalSorter()
        {
            Wagons = new List<Wagon>();
           
        }

        public List<Wagon> SortAnimalsIntoWagons(List<Animal> animalsToBeSorted)
        {
           
            foreach (var animal in OrderList(animalsToBeSorted))
            {
                if (FindSuitableWagon(animal) != null)
                {
                    FindSuitableWagon(animal).AddAnimalToWagon(animal);
                    animalsToBeSorted.Remove(animal);
                    continue;
                }

                AddAnimalNewWagon(animal);
                animalsToBeSorted.Remove(animal);
            }

            return Wagons;
        }

        private Wagon FindSuitableWagon(Animal animal)
        {
            foreach (var wagon in Wagons.ToList())
            {
                if (wagon.CompatabilityCheck(animal))
                {
                    return wagon;
                }
            }

            return null;
        }
        private List<Animal> OrderList(List<Animal> animalsToBeSorted)
        {
            var orderedAnimals= animalsToBeSorted.OrderByDescending(animal => (int) animal.Size).ToList();
            return orderedAnimals;
        }

        public IReadOnlyCollection<Animal> GetOrderedList(List<Animal> animalsToBeSorted)
        {
            return OrderList(animalsToBeSorted);
        }

        public void AddAnimalNewWagon(Animal animal)
        {
            var wagon = new Wagon();
            wagon.CompatabilityCheck(animal);
            wagon.AddAnimalToWagon(animal);
            Wagons.Add(wagon);
        }

        public IReadOnlyCollection<Wagon> GetWagons()
        {
            return Wagons;
        }

        
    }
}
