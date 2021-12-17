using System;
using System.Collections.Generic;
using DTOAndInterfaces;
using DTOAndInterfaces.Interfaces;
using Logic.Classes;
using Logic.LogicInterfaces;

namespace Logic.LogicServices
{
    public class AnimalDataHandler : IAnimalDataHandler
    {
        private readonly IAnimalRepo  animalRepo;

        //Ianimalrepo in the constructor in the constructor is what tells your code that they need to use the dependency injection add scoped thing in the startup file
        public AnimalDataHandler(IAnimalRepo AnimalRepo)
        {
            animalRepo = AnimalRepo;
        }

       
        public void CreateAnimal(string animalName, Diet diet, Size size, int ownerId)
        {
            AnimalDTO animal = new AnimalDTO();
            animal.Name = animalName;
            animal.Diet = Convert.ToInt32(diet);
            animal.Size = Convert.ToInt32(size);
            animal.OwnerId = ownerId; //TODO Add a wa to add acoount id here
            animalRepo.CreateAnimal(animal);
        }


        public void UpdateAnimal(int animalId, string animalName, Diet diet, Size size)
        {
            AnimalDTO animal = new AnimalDTO();
            animal.Name = animalName;
            animal.Diet = Convert.ToInt32(diet);
            animal.Size = Convert.ToInt32(size);
            animal.Id = animalId;
            animalRepo.UpdateAnimal(animal);
        }

        public void DeleteAnimal(int animalId)
        {
            animalRepo.DeleteAnimal(animalId);
        }

        public List<AnimalDTO> GetAnimalsByUserId(int accountId)
        {
            return animalRepo.GetAnimalsByUserId(accountId);
        }

        public List<Animal> ConvertAnimalDTOsTOAnimals(int accountId)
        {
            List<AnimalDTO> userAnimals = GetAnimalsByUserId(accountId); //figure out how to add user id here

            List<Animal> animalsToBeSorted = new List<Animal>();

            foreach (var animal in userAnimals)
            {
                Animal x = new Animal(animal.Name, (Diet)animal.Diet, (Size)animal.Size); //figure out how to add accounfID

                animalsToBeSorted.Add(x);
            }

            return animalsToBeSorted;
        }

        public AnimalDTO GetAnimalById(int Id)
        {
            return animalRepo.GetAnimalId(Id);
        }
    }
}
