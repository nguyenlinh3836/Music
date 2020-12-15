using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MusicWorld.Models;
using MusicWorld.Models.ViewModels;

namespace MusicWorld.Controllers
{
    public class HomeController : Controller
    {

        private IMusicRepository repository;
        public int PageSize = 4;
        public HomeController(IMusicRepository repo)
        {
            repository = repo;
        }


     
           
   

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
