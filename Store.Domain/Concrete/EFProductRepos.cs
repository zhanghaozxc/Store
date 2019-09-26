using Store.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Domain.Entities;



namespace Store.Domain.Concrete
{
    public class EFProductRepos : IProductsRepos
    {
        //private EFDbContext context = new EFDbContext();
        public EFDbContext Context { get; set; }

        public IEnumerable<Product> Products
        {
            get { return Context.Products; }
        }
    }
}
