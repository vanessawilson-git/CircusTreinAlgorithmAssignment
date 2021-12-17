using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using View.Models;

namespace View.Controllers
{
    public class AnimalModelController : Controller
    {
       
        public static List<AnimalModel> animals = new List<AnimalModel>();

        // GET: AnimalModel


        public ActionResult Index()
        {
            return View();
        }
        
        
       [HttpPost]
       public ActionResult Create()
       {
            
            
            return View();
          
       }


        public ActionResult Edit()
        {
            throw new NotImplementedException();
        }

        public ActionResult Details()
        {
            throw new NotImplementedException();
        }

        public ActionResult Delete()
        {
            throw new NotImplementedException();
        }
    }
}
