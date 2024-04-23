using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData1
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Customer.Any())
            {
                return;   // DB has been seeded
            }
            context.Customer.AddRange(
                new Customer
                {
                    Id = 1,
                    Name = "Shahriar",
                    Email = "shahriarkabir078@gmail.com",
                    NoOfTicket = "1",
                    MovieName = "Surongo"
                }
            );
            context.SaveChanges();
        }
    }
}