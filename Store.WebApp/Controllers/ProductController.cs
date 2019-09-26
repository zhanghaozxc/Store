using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Store.Domain;
using Store.Domain.Abstract;
using Store.WebApp.Models;
//using Store.WebApp.Models;

namespace Store.WebApp.Controllers
{
    public class ProductController : Controller
    {
        public int PageSize = 2;

        public IProductsRepos ProductsRepos { get; set; }

        //public ProductController(IProductsRepos productsRepos)
        //{
        //    this.repos = productsRepos;
        //}

        public ViewResult List(int page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel()
            {
                Products = ProductsRepos
                .Products
                .OrderBy(p =>p.ProductId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = ProductsRepos.Products.Count()
                }
            };
            return View(model);
        }
    }
}