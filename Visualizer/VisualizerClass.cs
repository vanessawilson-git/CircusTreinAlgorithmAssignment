using System;
using System.Collections.Generic;
using System.Text;
using Logic.Classes;

namespace Visualizer
{
    public class VisualizerClass
    {
       public string WagonsToString(List<Wagon> wagons)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var wagon in wagons)
            {
                
                builder.Append(WagonToString(wagon)).Append(", ");
            }

            var result = builder.ToString().TrimEnd(new char[] { ',', ' '});
            
            return result;
        }


        public string AnimalsToString(List<Animal> animals)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var animal in animals)
            {

                builder.Append(AnimalToString(animal)).Append(", ");
            }

            var result = builder.ToString().TrimEnd(new char[] { ',', ' '});
            
            return result;
        }


        public string WagonToString(Wagon wagon)
        {
            return "Wagon" + " " + wagon._wagonID + " " + "contains:" + " " + AnimalsToString((List<Animal>)wagon.GetWagonAnimals());
        }

        public string AnimalToString(Animal animal)
        {
            return animal.Name + " " + "the" + " " + animal.Size + " " + animal.Diet;
        }

       

    }

}


