using System;
using System.Collections.Generic;
using System.Text;

namespace DTOAndInterfaces.Interfaces
{
    public interface IAnimalRepo
    {
        void CreateAnimal(AnimalDTO animal);
        void UpdateAnimal(AnimalDTO animal);
        void DeleteAnimal(int animalId);
        List<AnimalDTO> GetAnimalsByUserId(int accountId);
        AnimalDTO GetAnimalId(int animalId);
    }
}
