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

    }
}