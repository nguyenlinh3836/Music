﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models
{
    public class Track
    {
      
        public int TrackId { get; set; }
        [Required, StringLength(100), Display(Name = "TrackName")]
        public string TrackName { get; set; }
        public string TrackLink { get; set; }
        public string Duration { get; set; }
        public string UrlImg { get; set; }
        public string Genre { get; set; }  
        public string ArtistName { get; set; }
       
        public int? AlbumId { get; set; }
        
        public virtual Album Album { get; set; }   
        public virtual ICollection<ArtistTrack> ArtistTracks { get; set; }

    }
}
