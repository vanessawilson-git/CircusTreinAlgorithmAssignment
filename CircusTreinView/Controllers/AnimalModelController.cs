using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using CircusTreinView.Models;
using DTOAndInterfaces;
using Logic;
using Logic.Classes;
using Logic.LogicInterfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using  Visualizer;


namespace CircusTreinView.Controllers
{
    public class AnimalModelController : Controller
    {
        private IAnimalSorter _animalSorter;
        private IAnimalDataHandler animalHandler;
       
        
        public AnimalModelController(IAnimalDataHandler animalHandler, IAnimalSorter animalSorter )
        {
            this.animalHandler = animalHandler;
            _animalSorter = animalSorter;
        }

     
        [HttpGet]
        public IActionResult AnimalOverView()
        {
            List<AnimalDTO> userAnimals = animalHandler.GetAnimalsByUserId(1); //figure out how to add user id here    accountId

            List<AnimalModel> animals = new List<AnimalModel>();

            foreach (var animal in userAnimals)
            {
                AnimalModel x = new AnimalModel()
                {
                    OwnerId = 1,
                    Name = animal.Name,
                    Diet = (Diet)animal.Diet,
                    Size = (Size)animal.Size,
                    Id = animal.Id

                }; //figure out how to add accounfID   accountId
                animals.Add(x);
            }

            return View(animals);
        }


        public ViewResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AnimalModel animal)
        {
            if (!ModelState.IsValid) return Create();
            animalHandler.CreateAnimal(animal.Name, animal.Diet, animal.Size, 1); //Find a way to n not hardcode this ownerId
            
            return Create();
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            AnimalDTO animaldto = animalHandler.GetAnimalById(id);
            AnimalModel animalmodel = new AnimalModel()
            {
                Id = animaldto.Id,
                OwnerId = 1,
                Name = animaldto.Name,
                Diet = (Diet)animaldto.Diet,
                Size = (Size)animaldto.Size
            };


            return View(animalmodel);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AnimalModel animal)
        {
            if (!ModelState.IsValid) return Edit(animal.Id);
            animalHandler.UpdateAnimal(animal.Id, animal.Name, animal.Diet, animal.Size);
            return RedirectToAction("AnimalOverView");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteAnimal(AnimalModel animal)
        {
            animalHandler.DeleteAnimal(animal.Id);
            return RedirectToAction("AnimalOverView");
        }

        public IActionResult SortMyAnimals()
        {
            int accountId = 1;
            List<Animal> animalsToBeSorted = animalHandler.ConvertAnimalDTOsTOAnimals(accountId);
            VisualizerClass v = new VisualizerClass();


            WagonList result = new WagonList();

            result.UserWagonList = v.WagonsToString(_animalSorter.SortAnimalsIntoWagons(animalsToBeSorted));

            return PartialView(result);
        }
    }
}
