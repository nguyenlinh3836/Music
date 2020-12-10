using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models
{
    public class ArtistAlbum
    {
       
        public int ArtistId { get; set; }        
        public int AlbumId { get; set; }
        public Artist Artist { get; set; }
        public Album Album { get; set; }
    }
}
