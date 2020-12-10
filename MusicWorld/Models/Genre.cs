using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models
{
    public class Genre
    {
        [Key]
        public int GenreID { get; set; }
        public string GenreName { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }
    }
}
