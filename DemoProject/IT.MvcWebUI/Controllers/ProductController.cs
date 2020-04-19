using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IT.Bussiness.Abstract;
using Microsoft.AspNetCore.Mvc;
using IT.MvcWebUI.Models;
using IT.Entity.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace IT.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {

        IProductServices _productServices;
        ICategoryServices _categoryServices;

        public ProductController(IProductServices productServices, ICategoryServices categoryServices)
        {
            _productServices = productServices;
            _categoryServices = categoryServices;
        }

        private List<SelectListItem> LoadCategories()
        {
            List<SelectListItem> categories = (from category in _categoryServices.GetList()
                                               select new SelectListItem
                                               {
                                                   Value=category.Id.ToString(),
                                                   Text=category.Name
                                               }
                                              ).ToList();
            return categories;
        }

        public IActionResult GetProducts()
        {
            var ProductViewModel = new ProductViewModel
            {
                products = _productServices.GetProductCategoryComplexDatas(),
                Categories=LoadCategories()
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


        public JsonResult Edit(int id)
        {
            if (id>0)
            {
                var result = _productServices.GetById(id);
                return Json(result);
            }
            return Json(0);
        }
        [HttpPost]
        public IActionResult Edit(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                var productIsValid = _productServices.GetById(productViewModel.product.Id);
                if (productIsValid==null)
                {
                    return RedirectToAction("GetProducts");
                }

                var productForUpdate = new Product
                {
                    AddedBy="iso",
                    AddedDate=DateTime.Now,
                    CategoryId=productViewModel.product.CategoryId,
                    Explanation=productViewModel.product.Explanation,
                    Height=productViewModel.product.Height,
                    Name=productViewModel.product.Name,
                    Weight=productViewModel.product.Weight,
                    Width=productViewModel.product.Width,
                    Id=productViewModel.product.Id
                };
                try
                {
                    _productServices.Update(productForUpdate);
                    return RedirectToAction("GetProducts");
                }
                catch (Exception)
                {

                    throw;
                }
               


            }
            return RedirectToAction("GetProducts");
        }


        public JsonResult Delete(int id)
        {
            if (id==0)
            {
                return Json(0);
            }
            var productIsValid = _productServices.GetById(id);
            if (productIsValid!=null)
            {
                _productServices.Delete(productIsValid);
                return Json(1);
            }
            else
            {
                return Json(0);
            }
        }
    }
}