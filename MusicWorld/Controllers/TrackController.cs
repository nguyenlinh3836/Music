using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicWorld.Models.ViewModels;
using MusicWorld.Models;
using Microsoft.EntityFrameworkCore;

namespace MusicWorld.Controllers
{
    public class TrackController : Controller
    {
        private readonly MusicDbContext _context;
        public TrackController(MusicDbContext context)
        {
            _context = context;
        }
        public async Task<ActionResult<IEnumerable<ArtistTrack>>> GetArtistTrack()
        {
            return await _context.ArtistTracks.ToListAsync();
        }

        public async Task<IActionResult> TrackList(int id)
        {
            var tracks = await _context.ArtistTracks
                .Include(ta => ta.Artist)
                .Include(ta => ta.Track)
                .FirstOrDefaultAsync();            
            return View(tracks);
        }




    }
}
