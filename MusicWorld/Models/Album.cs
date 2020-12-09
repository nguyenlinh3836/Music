using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models
{
    public class Album
    {
        [Key]
        public int AlbumId { get; set;}
        public string AlbumName { get; set; }
        public string ImgAlbum { get; set; }

        public virtual ICollection<ArtistAlbum> ArtistAlbums { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }
    }
}
