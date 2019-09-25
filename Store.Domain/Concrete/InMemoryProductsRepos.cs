using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Domain.Abstract;
using Store.Domain.Entities;

namespace Store.Domain.Concrete
{
    public class InMemoryProductsRepos : IProductsRepos
    {
        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product>
                {
                    new Product { Name = "Football", Price = 25 },
                    new Product { Name = "Cake", Price = 12},
                    new Product { Name = "Orange", Price = 1.99M},
                };
            }
        }
    }
}
