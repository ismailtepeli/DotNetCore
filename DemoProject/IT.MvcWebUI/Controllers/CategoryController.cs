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

        public IActionResult Add(CategoryViewModel categoryViewModel)
        {
            if (ModelState.IsValid)
            {
                var categoryForAdd = new Category
                {
                    AddedBy="iso",
                    AddedDate=DateTime.Now,
                    isActive=true,
                    Name=categoryViewModel.Category.Name
                };
                try
                {
                    _categoryServices.Add(categoryForAdd);
                    return RedirectToAction("GetCategories");
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return RedirectToAction("GetCategories");
        }
        public JsonResult Edit(int id)
        {
            if (id==0)
            {
                return Json(0);
            }
            var category = _categoryServices.GetById(id);
            if (category==null)
            {
                return Json(0);
            }
            else
            {
                return Json(category);
            }
        }

        [HttpPost]
        public IActionResult Edit(CategoryViewModel categoryViewModel)
        {
            if (ModelState.IsValid)
            {
                var CategoryIsValid = _categoryServices.GetById(categoryViewModel.Category.Id);

                if (CategoryIsValid==null)
                {
                    return RedirectToAction("GetCategories");

                }
                try
                {
                    var CategoryForUpdate = new Category
                    {
                        AddedBy = "iso",
                        AddedDate = DateTime.Now,
                        isActive = true,
                        Name = categoryViewModel.Category.Name,
                        Id=CategoryIsValid.Id
                    };
                    _categoryServices.Update(CategoryForUpdate);
                    return RedirectToAction("GetCategories");
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return RedirectToAction("GetCategories");
        }


        public JsonResult Delete(int id)
        {
            if (id==0)
            {
                return Json(0);
            }
            var category = _categoryServices.GetById(id);
            if (category==null)
            {
                return Json(0);
            }
            try
            {
                _categoryServices.Delete(category);
                return Json(1);
            }
            catch (Exception)
            {

                return Json(0);
            }
        }
    }
}