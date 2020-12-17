using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MusicWorld.Controllers
{
    public class ArtistController : Controller
    {
        public IActionResult Artist()
        {
            return View();
        }
    }
}
