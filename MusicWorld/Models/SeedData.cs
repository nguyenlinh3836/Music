using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD

namespace MusicWorld.Models
{
    public class SeedData
    {

=======
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace MusicWorld.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            MusicDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<MusicDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Genres.Any())
            {
                context.Genres.AddRange(
                        new Genre
                        {
                            GenreID= 1,
                            GenreName= "Rock"
                        },
                        new Genre
                        {
                            GenreID = 2,
                            GenreName = "Pop"
                        },
                        new Genre
                        {
                            GenreID = 3,
                            GenreName = "Rap/Hip-Hop"
                        },
                        new Genre
                        {
                            GenreID = 4,
                            GenreName = "EDM"
                        },
                         new Genre
                         {
                             GenreID = 5,
                             GenreName = "Bolero"
                         }
                       
                       );
                context.SaveChanges();
            }
        }
>>>>>>> Phuong
    }
}
