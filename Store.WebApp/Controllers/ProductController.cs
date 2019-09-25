using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Store.Domain;
using Store.Domain.Abstract;
//using Store.WebApp.Models;

namespace Store.WebApp.Controllers
{
    public class ProductController : Controller
    {
        //private readonly IProductsRepos repos;

        public IProductsRepos ProductsRepos { get; set; }

        public ViewResult List()
        {
            return View(ProductsRepos.Products);
        }
    }
}