using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MusicWorld.Models
{
    public class MusicDbContext: DbContext
    {
        public MusicDbContext(DbContextOptions<MusicDbContext> options)
           : base(options) { }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Track> Tracks { get; set; }       
        public DbSet<ArtistTrack> ArtistTracks { get; set; }
        public DbSet<ArtistAlbum> ArtistAlbums { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArtistAlbum>().HasKey(vf => new { vf.ArtistId, vf.AlbumId });
            modelBuilder.Entity<ArtistTrack>().HasKey(vk => new { vk.ArtistId, vk.TrackId });            
        }      
    

    }    
}
