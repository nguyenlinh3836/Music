using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicWorld.Models;

namespace MusicWorld.Models.ViewModels
{
    public class ArtistAlbumController
    {
        public IEnumerable<Track> Tracks { get; set; }
        public PageInfo PageInfo { get; set; }

        public string CurrentGenre { get; set; }
    }
}
