using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models
{
    public class Track
    {
        public int TrackID { get; set; }
        public string TrackName { get; set; }
        public DateTime Release { get; set; }
        public Genre Genre { get; set; }

        public Album Album { get; set; }   
        public virtual ICollection<ArtistTrack> ArtistTracks { get; set; }

    }
}
