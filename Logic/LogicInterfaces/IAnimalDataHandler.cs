using System.Collections.Generic;
using DTOAndInterfaces;
using Logic.Classes;

namespace Logic.LogicInterfaces
{
    public interface IAnimalDataHandler
    {

        void CreateAnimal(string animalName, Diet diet, Size size, int ownerId);
        void UpdateAnimal(int animalId, string animalName, Diet diet, Size size);
        void DeleteAnimal(int animalId);
        List<AnimalDTO> GetAnimalsByUserId(int accountId);
        List<Animal> ConvertAnimalDTOsTOAnimals(int accountId);

        AnimalDTO GetAnimalById(int Id);

    }
}
