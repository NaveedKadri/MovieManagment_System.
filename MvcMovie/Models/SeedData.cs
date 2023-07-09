using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            //Looking for Movie
            using (var context = new MvcMovieContext(serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
            {
                if (context.MovieModel.Any())
                {
                    return; //Db has been seeded.
                }
                context.MovieModel.AddRange(

                    new MovieModel
                    {
                        Title = "RRR",
                        ReleaseDate = DateTime.Parse("2022-02-12"),
                        Genre = "Action",
                        Price = 300,
                        Rating = "A"
                        
                       
                    },

                     new MovieModel
                     {
                         Title = "Pathaan",
                         ReleaseDate = DateTime.Parse("2022-02-12"),
                         Genre = "Action",
                         Price = 300,
                         Rating= "A"

                     },

                     new MovieModel
                     {
                         Title = "Housefull 4",
                         ReleaseDate = DateTime.Parse("2022-02-12"),
                         Genre = "Comedy",
                         Price = 300,
                         Rating = "C"

                     }

                    );
                context.SaveChanges();
            }

        }
    }
}

