using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using PersonOfTheYear.Models;
using System.Linq;
using System.Threading.Tasks;

namespace PersonOfTheYear.Controllers
{
    public class HomeController : Controller
    {

        // Loads initial index page with form
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }


        // Processes the form inputs and passes to Result() 
        [HttpPost]
        public IActionResult Index(int startYear, int endYear)
        {
            //Redirect to results view action
            return RedirectToAction("Result", new { startYear, endYear });
        }

        // Retrieves the persons of the year between startYear and endYear and 
        public ViewResult Result(int startYear, int endYear)
        {
            //Get List of persons
            List<Person> persons = Person.GetPersons(startYear, endYear);
            return View(persons);
        }



    }
}