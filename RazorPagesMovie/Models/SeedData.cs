using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<RazorPagesMovieContext>>()))
            {
                //look for any movies.
                if (context.Movie.Any())
                {
                    return; //DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Spider Man ",
                        ReleaseDate = DateTime.Parse("2015-3-11"),
                        Genre = "Superhero",
                        Price = 88M,
                        Rating = "G"

                    },

                    new Movie
                    {
                        Title = "Inception ",
                        ReleaseDate = DateTime.Parse("2018-1-11"),
                        Genre = "Sci-Fic",
                        Price = 99M,
                        Rating = "PG-13"
                    },

                    new Movie
                    {
                        Title = "The Wadering Earth ",
                        ReleaseDate = DateTime.Parse("01/13/2019"),
                        Genre = "Sci-Fic",
                        Price = 110M,
                        Rating = "G"
                    },

                    new Movie
                    {
                        Title = "Iron Man",
                        ReleaseDate = DateTime.Parse("12/12/2015"),
                        Genre = "Superhero",
                        Price = 30M,
                        Rating = "G"
                    },

                    new Movie
                    {
                        Title = "DealPool",
                        ReleaseDate = DateTime.Parse("1/4/2017"),
                        Genre = "Superhero",
                        Price = 55M,
                        Rating = "R"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
