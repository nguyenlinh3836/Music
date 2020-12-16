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
        public int PageSize = 10;
        public HomeController(IMusicRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index(string genre, int productPage = 1)
          => View(new TrackListViewModel
          {
              Tracks = repository.Tracks
              .Where(p => genre == null || p.Genre == genre)
              .OrderBy(p => p.TrackId)
              .Skip((productPage - 1) * PageSize)
              .Take(PageSize),
              PageInfo = new PageInfo
              {
                  CurrentPage = productPage,
                  ItemsPerPage = PageSize,                   
                   TotalItems = genre == null ?
                   repository.Tracks.Count() :
                   repository.Tracks.Where(
                       e => e.Genre == genre).Count()
              },
              CurrentGenre = genre
          });
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
