using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models
{
    public class Artist
    {
        
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }
        public string Achievement { get; set; }
        public string ImgUrl { get; set; }
        public virtual ICollection<ArtistAlbum> ArtistAlbums { get; set; }
        public virtual ICollection<ArtistTrack> ArtistTracks { get; set; }
    }
}
