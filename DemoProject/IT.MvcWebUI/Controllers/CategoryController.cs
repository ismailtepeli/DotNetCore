using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IT.Bussiness.Abstract;
using Microsoft.AspNetCore.Mvc;
using IT.MvcWebUI.Models;

namespace IT.MvcWebUI.Controllers
{
    public class CategoryController : Controller
    {

        ICategoryServices _categoryServices;

        public CategoryController(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }
        public IActionResult GetCategories()
        {
            var CategoryViewModel = new CategoryViewModel
            {
                Categories = _categoryServices.GetList()
            };

            return View(CategoryViewModel);
        }
    }
}