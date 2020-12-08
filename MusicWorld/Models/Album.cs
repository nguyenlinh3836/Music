using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models
{
    public class Album
    {
        public int AlbumId { get; set;}
        public string AlbumName { get; set; }
        public string ImgAlbum { get; set; }

        public virtual ICollection<ArtistAlbum> ArtistAlbums { get; set; }
        public virtual ICollection<TrackAlbum> TrackAlbums { get; set; }
    }
}
