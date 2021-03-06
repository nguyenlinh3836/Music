﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicWorld.Models;

namespace MusicWorld.Models.ViewModels
{
    public class TrackListViewModel
    {
        public IEnumerable<Track> Tracks { get; set; }
        public IEnumerable<Album> Albums { get; set; }
        public IEnumerable<Artist> Artists { get; set; }
        public List<Album> albums { get; set; }

        public PageInfo PageInfo { get; set; }

        public string CurrentGenre { get; set; }
    }
}
