using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicWorld.Models;
using MusicWorld.Models.ViewModels;

namespace MusicWorld.Controllers
{
    public class AlbumController : Controller
    {
        private IMusicRepository repository;
        public AlbumController(IMusicRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index() => View(repository.Albums);

        public ViewResult DetailAlbum(int AlbumId)
            => View(new TrackListViewModel{
                Albums = repository.Albums                
                .Where(p => p.AlbumId == AlbumId),
                Tracks = repository.Tracks     
               });

        public ViewResult DetailTrack(int TrackId)
          => View(new TrackListViewModel
          {
              Tracks = repository.Tracks
              .Where(p => p.TrackId == TrackId)

          });
    }
}
