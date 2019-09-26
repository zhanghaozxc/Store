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
                for (int i = 0; i < 20; i++)
                {
                    var product1 = new Product()
                    {
                        Name = $"orange_{i}",
                        Price = i + 1m,
                        Description = $"this is an apple{i}",
                        Category = "food"
                    };

                    var product2 = new Product()
                    {
                        Name = $"shoes_{i}",
                        Price = i + 50m,
                        Description = $"this is a shoes",
                        Category = "shoes",
                    };

                    ctx.Products.Add(product1);
                    ctx.Products.Add(product2);
                }
                
                ctx.SaveChanges();
            }

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
