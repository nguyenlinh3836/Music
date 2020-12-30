using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicWorld.Models;
using MusicWorld.Models.ViewModels;

namespace MusicWorld.Controllers
{
    public class ArtistController : Controller
    {
        private IMusicRepository repository;
        public ArtistController(IMusicRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index() => View(repository.Artists);

        public ViewResult DetailArtist(int ArtistId)
        => View(new TrackListViewModel
        {
            Artists = repository.Artists
            .Where(p => p.ArtistId == ArtistId)            
        });
    }        
}
