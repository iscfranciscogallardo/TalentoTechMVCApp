using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCApp.Controllers;
using MVCApp.Data;
using System;
using System.Linq;

namespace MVCApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCAppContext(serviceProvider.GetRequiredService<DbContextOptions<MVCAppContext>>()))
            {
                //Look for any movies
                if (context.Movie.Any())
                {
                    return;
                }
                context.Movie.AddRange(
                        new Movie() { Title = "When Harry Met Sally", RealeaseDate = DateTime.Parse("1989-02-12"), Genre = "Romantic Comedy", Price = 7.99M, Rating = "R" }
                        , new Movie() { Title = "Ghostbusters", RealeaseDate = DateTime.Parse("1984-03-13"), Genre = "Comedy", Price = 8.99M, Rating = "PG-13" }
                        , new Movie() { Title = "Ghostbusters 2", RealeaseDate = DateTime.Parse("1984-03-13"), Genre = "Comedy", Price = 9.99M, Rating = "PG-13" }
                        , new Movie() { Title = "Rio Bravo", RealeaseDate = DateTime.Parse("1959-04-15"), Genre = "Western", Price = 3.99M, Rating = "R" }
                    );
                context.SaveChanges();
            }
        }
    }
}

