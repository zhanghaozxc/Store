using Moq;
using Store.Domain;
using Store.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Store.Domain.Entities;
using Store.Domain.Concrete;

namespace Store.WebApp.App_Start
{
    public class IocConfig
    {
        public static void ConfigIoc()
        {
            var builder = new ContainerBuilder();
            builder
                .RegisterControllers(typeof(MvcApplication).Assembly)
                .PropertiesAutowired();

            //Mock<IProductsRepos> mock = new Mock<IProductsRepos>();


            //mock.Setup(m => m.Products).Returns(new List<Product>
            //{
            //    new Product { Name ="Football", Price = 25 },
            //    new Product { Name = "Cake", Price = 12},
            //    new Product { Name = "Orange", Price = 1.99M}
            //});
            builder.RegisterInstance<EFDbContext>(new EFDbContext())
                   .PropertiesAutowired();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}