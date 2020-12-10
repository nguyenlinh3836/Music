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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ArtistId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int TrackId { get; set; }
        public Artist Artist { get; set; }
        public Track Track { get; set; }
    }
}
