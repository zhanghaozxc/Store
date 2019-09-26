using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Store.Domain.Concrete;
using Store.Domain.Entities;

namespace Store.DebugConsole
{
    class Program
    {
        static void Main(string[] args)
        {
           using (var ctx = new EFDbContext())
            {
                var product = new Product()
                {
                    Name = "apple",
                    Price = 1.99m,
                    Description = "this is an apple",
                    Category = "food",
                };

                ctx.Products.Add(product);
                ctx.SaveChanges();
            }

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
