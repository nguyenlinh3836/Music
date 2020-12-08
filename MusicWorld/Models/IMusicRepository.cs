using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models
{
    public interface IMusicRepository
    {
        IQueryable<Track> Tracks { get; }
        IQueryable<Genre> Genres{ get; }
        IQueryable<Album> Albums{ get; }
        IQueryable<Artist> Artists { get; }
    }
}
