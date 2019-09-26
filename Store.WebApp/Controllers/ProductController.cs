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

        private IProductsRepos repos;

        public int PageSize = 2;

        public ProductController(IProductsRepos productsRepos)
        {
            this.repos = productsRepos;
        }

        public ViewResult List()
        {
            return View(
                repos
                .Products
                .OrderBy(p => p.ProductId)
                .Skip((PageSize - 1)* PageSize)
                .Take(PageSize));
        }
    }
}