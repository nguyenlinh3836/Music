using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MusicWorld.Models;

namespace MusicWorld.Controllers
{
    public class HomeController : Controller
    {
        private readonly MusicDbContext _context;
        private IMusicRepository repository;
        public int PageSize = 4;
        public HomeController(IMusicRepository repo)
        {
            repository = repo;
        }
        public HomeController(MusicDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int? id)
        {
            var Album = await _context.Albums.Include(x => x.ArtistAlbums).ThenInclude(y => y.Artist).SingleOrDefaultAsync(m => m.AlbumId == id);
            return View(Album);
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
