using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Store.Domain;
using Store.Domain.Abstract;

namespace Store.WebApp.Controllers
{
    public class ProductController : Controller
    {
        private IProductsRepos repos;

        public ProductController(IProductsRepos productsRepos)
        {
            this.repos = productsRepos;
        }
    }
}