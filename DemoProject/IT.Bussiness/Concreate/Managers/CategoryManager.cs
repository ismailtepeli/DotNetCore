using IT.Bussiness.Abstract;
using IT.DataAccess.Abstract;
using IT.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IT.Bussiness.Concreate.Managers
{
    public class CategoryManager : ICategoryServices
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public Category Add(Category category)
        {
            return _categoryDal.Add(category);
        }

        public async Task<Category> AddAsync(Category category)
        {
            return await  _categoryDal.AddAsync(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public Category GetById(int Id)
        {
            return _categoryDal.Get(x => x.Id == Id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetAll();
        }

        public Category Update(Category category)
        {
            return _categoryDal.Update(category);
        }

        public async Task<Category> UpdateAsync(Category category)
        {
            return await _categoryDal.UpdateAsync(category);
            
        }
    }
}
