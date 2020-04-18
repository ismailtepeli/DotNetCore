using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IT.Bussiness.Abstract;
using Microsoft.AspNetCore.Mvc;
using IT.MvcWebUI.Models;
using IT.Entity.Concrete;

namespace IT.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {

        IProductServices _productServices;

        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }
        public IActionResult GetProducts()
        {
            var ProductViewModel = new ProductViewModel
            {
                products = _productServices.GetList()
            };
            return View(ProductViewModel);
        }


        public IActionResult Add(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                var productIsValid = _productServices.GetByName(productViewModel.product.Name);
                if (productIsValid!=null)
                {
                    return RedirectToAction("GetProducts");
                }

                var NewProduct = new Product
                {
                    Name = productViewModel.product.Name,
                    AddedBy="iso",
                    AddedDate=DateTime.Now,
                    Explanation=productViewModel.product.Explanation,
                    CategoryId=productViewModel.product.CategoryId,
                    Height=productViewModel.product.Height,
                    Weight=productViewModel.product.Weight,
                    Width=productViewModel.product.Width
                };
                try
                {
                    _productServices.Add(NewProduct);
                    return RedirectToAction("GetProducts");

                }
                catch (Exception)
                {
                    return RedirectToAction("GetProducts");
                }
              
            }
            return RedirectToAction("GetProducts");
        }

    }
}