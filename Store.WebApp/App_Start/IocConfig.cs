using Moq;
using Store.Domain;
using Store.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.WebApp.App_Start
{
    public class IocConfig
    {
        private void AddBindings()
        {
            Mock<IProductsRepos> mock = new Mock<IProductsRepos>();
            mock.Setup(m => m.Products).Returns(new List<Product>
            {
                new Product { Name = "Football", Price = 25 },
                new Product { Name = "Surf board", Price = 179 },
                new Product { Name = "Running shoes", Price = 95 }
            });
            kernel.Bind<IProductsRepos>().ToConstant(mock.Object);
           }
    }
}