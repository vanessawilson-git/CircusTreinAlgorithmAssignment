using System;
using System.Collections.Generic;
using System.Linq;
using Logic;
using Logic.Classes;
using Logic.SortingAlgorithm;
using NUnit.Framework;
using Visualizer;

namespace NUnitTestCircusTreinLogic
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
          
        }

       
        Visualizer.VisualizerClass v = new Visualizer.VisualizerClass();

        
        [Test]
        public void TestWagonToString()
        {
            // arrange
            Animal betsy = new Animal("Betsy", Diet.Herbivore, Size.Large);
            Animal paula = new Animal("Paula", Diet.Carnivore, Size.Medium);
            Wagon wagon1 = new Wagon();
            //act

            wagon1.CompatabilityCheck(betsy);
            wagon1.AddAnimalToWagon(betsy);
            wagon1.CompatabilityCheck(paula);
            wagon1.AddAnimalToWagon(paula);

            var result = v.WagonToString(wagon1);

            var wantedResult = "Wagon 21 contains: Betsy the Large Herbivore, Paula the Medium Carnivore";

            //assert

            Assert.AreEqual(wantedResult, result);
        }

        [Test]
        public void TestAddAnimalNewWagon()
        {
            // arrange
            AnimalSorter sorter = new AnimalSorter();
            Animal betsy = new Animal("Betsy", Diet.Herbivore, Size.Large);

            //act

            sorter.AddAnimalNewWagon(betsy);

            //assert

            Assert.That(sorter.GetWagons(), Has.Exactly(1).Matches<Wagon>(wagon => wagon.GetWagonAnimals().Contains(betsy)));
        }

        [Test]
        public void TestOrderList()
        {
            // arrange
            AnimalSorter sorter = new AnimalSorter();
            Animal arthur = new Animal("Arthur", Diet.Carnivore, Size.Small);
            Animal paula = new Animal("Paula", Diet.Carnivore, Size.Medium);
            Animal betsy = new Animal("Betsy", Diet.Herbivore, Size.Large);
            List<Animal> animalsToBeSorted = new List<Animal>();

            //act

            animalsToBeSorted.Add(arthur);
            animalsToBeSorted.Add(paula);
            animalsToBeSorted.Add(betsy);

            var res = v.AnimalsToString((List<Animal>)sorter.GetOrderedList(animalsToBeSorted));
            var wantedres = "Betsy the Large Herbivore, Paula the Medium Carnivore, Arthur the Small Carnivore";
            //assert

            Assert.AreEqual(wantedres, res);
        }


        [Test]
        public void TestOSortAnimalsIntoWagons1()
        {
            // arrange
            AnimalSorter sorter = new AnimalSorter();
            Animal arthur = new Animal("Arthur", Diet.Carnivore, Size.Medium);
            Animal paula = new Animal("Paula", Diet.Carnivore, Size.Medium);
            Animal betsy = new Animal("Betsy", Diet.Herbivore, Size.Large);
            List<Animal> animalsToBeSorted = new List<Animal>();

            //act

            animalsToBeSorted.Add(arthur);
           animalsToBeSorted.Add(paula);
           animalsToBeSorted.Add(betsy);


            var res = v.WagonsToString(sorter.SortAnimalsIntoWagons(animalsToBeSorted));

           var wantedres =
                "Wagon 9 contains: Betsy the Large Herbivore, Arthur the Medium Carnivore, Wagon 10 contains: Paula the Medium Carnivore";
            //assert

            Console.WriteLine(res + wantedres);
            Assert.AreEqual(wantedres, res);
        }


        [Test]
        public void TestOSortAnimalsIntoWagons2()
        {
            // arrange
            AnimalSorter sorter = new AnimalSorter();
            Animal arthur = new Animal("Arthur", Diet.Carnivore, Size.Medium);
            Animal paula = new Animal("Paula", Diet.Carnivore, Size.Medium);
            Animal betsy = new Animal("Betsy", Diet.Herbivore, Size.Large);
            Animal a = new Animal("A", Diet.Carnivore, Size.Small);
            Animal b = new Animal("B", Diet.Herbivore, Size.Large);
            Animal k = new Animal("k", Diet.Herbivore, Size.Small);
            Animal q = new Animal("Q", Diet.Carnivore, Size.Medium);
            Animal t = new Animal("T", Diet.Herbivore, Size.Large);
            Animal p = new Animal("Q", Diet.Carnivore, Size.Medium);
            List<Animal> animalsToBeSorted = new List<Animal>();

            //act

            animalsToBeSorted.Add(arthur);
            animalsToBeSorted.Add(paula);
            animalsToBeSorted.Add(betsy);
            animalsToBeSorted.Add(a);
            animalsToBeSorted.Add(p);
            animalsToBeSorted.Add(b);
            animalsToBeSorted.Add(t);
            animalsToBeSorted.Add(q);
            animalsToBeSorted.Add(k);


            var res = v.WagonsToString(sorter.SortAnimalsIntoWagons(animalsToBeSorted));

            Console.WriteLine(v.WagonsToString(sorter.SortAnimalsIntoWagons(animalsToBeSorted)));

            var wantedres =
                "Wagon 11 contains: Betsy the Large Herbivore, B the Large Herbivore, Wagon 12 contains: T the Large Herbivore, Arthur the Medium Carnivore, Wagon 13 contains: Paula the Medium Carnivore, Wagon 14 contains: Q the Medium Carnivore, Wagon 15 contains: Q the Medium Carnivore, Wagon 16 contains: A the Small Carnivore, Wagon 17 contains: k the Small Herbivore";
            //assert

            Assert.AreEqual(wantedres, res);
        }

        [Test]
        public void TestIsThereEnoughSpace()
        {
            // arrange
           
            Animal arthur = new Animal("Arthur", Diet.Carnivore, Size.Medium);
            Animal paula = new Animal("Paula", Diet.Herbivore, Size.Large);
            Animal betsy = new Animal("Betsy", Diet.Herbivore, Size.Large);

            //act

            Wagon wagon1 = new Wagon();

            wagon1.CompatabilityCheck(betsy);
            wagon1.AddAnimalToWagon(betsy);
            wagon1.CompatabilityCheck(paula);
            wagon1.AddAnimalToWagon(paula);

           
            //assert

            Assert.IsFalse(wagon1.CompatabilityCheck(arthur));
        }

        [Test]
        public void TestSafeWithOtherAnimals1()
        {
            // arrange
            
            Animal paula = new Animal("Paula", Diet.Carnivore, Size.Large);
            Animal betsy = new Animal("Betsy", Diet.Herbivore, Size.Large);

            //act

            Wagon wagon1 = new Wagon();

            wagon1.CompatabilityCheck(betsy);
            wagon1.AddAnimalToWagon(betsy);


            //assert

            Assert.IsFalse(wagon1.CompatabilityCheck(paula));
        }


        [Test]
        public void TestSafeWithOtherAnimals2()
        {
            // arrange
           
            Animal paula = new Animal("Paula", Diet.Carnivore, Size.Small);
            Animal betsy = new Animal("Betsy", Diet.Herbivore, Size.Medium);

            //act

            Wagon wagon1 = new Wagon();

            wagon1.CompatabilityCheck(betsy);
            wagon1.AddAnimalToWagon(betsy);


            //assert

            Assert.True(wagon1.CompatabilityCheck(paula));
        }

        [Test]
        public void TestSafeWithOtherAnimals3()
        {
            // arrange
            
            Animal arthur = new Animal("Arthur", Diet.Carnivore, Size.Medium);
            Animal paula = new Animal("Paula", Diet.Herbivore, Size.Large);
            Animal betsy = new Animal("Betsy", Diet.Herbivore, Size.Small);

            //act

            Wagon wagon1 = new Wagon();

            wagon1.CompatabilityCheck(paula);
            wagon1.AddAnimalToWagon(paula);
            wagon1.CompatabilityCheck(arthur);
            wagon1.AddAnimalToWagon(arthur);

            //assert

            Assert.False(wagon1.CompatabilityCheck(betsy));
        }

        [Test]
        public void TestContainsMeatEater1()
        {
            // arrange

            Animal arthur = new Animal("Arthur", Diet.Carnivore, Size.Medium);
            Animal paula = new Animal("Paula", Diet.Herbivore, Size.Large);
            Animal ben = new Animal("ben", Diet.Carnivore, Size.Medium);

            //act

            Wagon wagon1 = new Wagon();

            wagon1.CompatabilityCheck(paula);
            wagon1.AddAnimalToWagon(paula);
            wagon1.CompatabilityCheck(arthur);
            wagon1.AddAnimalToWagon(arthur);


            //assert

            Assert.False(wagon1.CompatabilityCheck(ben));
        }


        [Test]
        public void TestContainsMeatEater2()
        {
            // arrange
            Animal paula2 = new Animal("Paula", Diet.Carnivore, Size.Medium);
            Animal paula = new Animal("Paula", Diet.Herbivore, Size.Large);
            //act

            Wagon wagon1 = new Wagon();

            wagon1.CompatabilityCheck(paula);
            wagon1.AddAnimalToWagon(paula);

            //assert

            Assert.True(wagon1.CompatabilityCheck(paula2));
        }

        [Test]
        public void TestContainsSmallerOrEvenCreatures1()
        {
            // arrange

            Animal paula = new Animal("Paula", Diet.Herbivore, Size.Large);
            Animal arthur = new Animal("Arthur", Diet.Carnivore, Size.Medium);
            //act

            Wagon wagon1 = new Wagon();

            wagon1.CompatabilityCheck(arthur);
            wagon1.AddAnimalToWagon(arthur);

            //assert

            Assert.True(wagon1.CompatabilityCheck(paula));
        }

        [Test]
        public void TestContainsSmallerOrEvenCreatures2()
        {
            // arrange

            Animal paula = new Animal("Paula", Diet.Herbivore, Size.Medium);
            Animal arthur = new Animal("Arthur", Diet.Carnivore, Size.Medium);
            //act

            Wagon wagon1 = new Wagon();

            wagon1.CompatabilityCheck(arthur);
            wagon1.AddAnimalToWagon(arthur);

            //assert

            Assert.False(wagon1.CompatabilityCheck(paula));
        }

        [Test]
        public void TestContainBiggerMeatEater1()
        {
            // arrange
            Animal paula = new Animal("Paula", Diet.Herbivore, Size.Medium);
            Animal arthur = new Animal("Arthur", Diet.Carnivore, Size.Large);
            //act

            Wagon wagon1 = new Wagon();

            wagon1.CompatabilityCheck(arthur);
            wagon1.AddAnimalToWagon(arthur);

            //assert

            Assert.False(wagon1.CompatabilityCheck(paula));
        }


        [Test]
        public void TestContainBiggerMeatEater2()
        {
            // arrange
            Animal paula = new Animal("Paula", Diet.Herbivore, Size.Large);
            Animal arthur = new Animal("Arthur", Diet.Carnivore, Size.Large);
            //act

            Wagon wagon1 = new Wagon();

            wagon1.CompatabilityCheck(arthur);
            wagon1.AddAnimalToWagon(arthur);

            //assert

            Assert.False(wagon1.CompatabilityCheck(paula));
        }


        
    }
}