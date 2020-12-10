using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicWorld.Models
{
    public class ArtistTrack
    {
        [Key, Column(Order = 0)]
        public int ArtistId { get; set; }
        [Key, Column(Order = 1)]
        public int TrackId { get; set; }
        public Artist Artist { get; set; }
        public Track Track { get; set; }
    }
}
