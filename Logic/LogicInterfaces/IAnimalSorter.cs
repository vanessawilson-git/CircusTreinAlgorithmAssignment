using System.Collections.Generic;
using Logic.Classes;

namespace Logic.LogicInterfaces
{
    public interface IAnimalSorter
    {
        List<Wagon> SortAnimalsIntoWagons(List<Animal> animalsToBeSorted);
    }

}
