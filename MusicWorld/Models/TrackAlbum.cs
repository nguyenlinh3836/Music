using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicWorld.Models
{
    public class TrackAlbum
    {
        [Key, Column(Order = 1)]
        public int TracktId { get; set; }
        [Key, Column(Order = 2)]
        public int AlbumId { get; set; }
        public Track Track { get; set; }
        public Album Album { get; set; }
    }
}
