using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models
{
    public class EFMusicRepository:IMusicRepository
    {
        private MusicDbContext context;
        public EFMusicRepository(MusicDbContext ctx)
        {
            context = ctx;    
        
        }
        public IQueryable<Artist> Artists => context.Artists;
        public IQueryable<Album> Albums => context.Albums;
        public IQueryable<Track> Tracks => context.Tracks;

       
       
    }    
}
