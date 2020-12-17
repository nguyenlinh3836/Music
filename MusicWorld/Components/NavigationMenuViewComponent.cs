using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MusicWorld.Models;

namespace MusicWorld.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {     

        private IMusicRepository repository;
        public NavigationMenuViewComponent(IMusicRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["Genre"];
            return View(repository.Tracks
                .Select(x => x.Genre)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
