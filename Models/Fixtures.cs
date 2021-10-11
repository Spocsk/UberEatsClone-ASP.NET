using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UberEatsClone.Data;
using System;
using System.Linq;

namespace UberEatsClone.Models
{
    public static class Fixtures
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DBContext())
            {
                if (context.Meals.Any())
                {
                    return; 
                }

                context.Meals.AddRange(
                    new Meal()
                    {
                        Id = 1,
                        Name = "American Burger",
                        Price = 10,
                        Country = "America"
                    },
                    new Meal()
                    {
                        Id = 2,
                        Name = "Sushi",
                        Price = 12,
                        Country = "Japan"
                    },
                    new Meal()
                    {
                        Id = 3,
                        Name = "Ramen",
                        Price = 9,
                        Country = "Japan"
                    },
                    new Meal()
                    {
                        Id = 4,
                        Name = "Tortilla",
                        Price = 6,
                        Country = "Mexican"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}