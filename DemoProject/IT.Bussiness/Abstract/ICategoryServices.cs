using IT.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IT.Bussiness.Abstract
{
    public interface ICategoryServices
    {
        Category Add(Category category);

        Task<Category> AddAsync(Category category);

        Category Update(Category category);

        Task<Category> UpdateAsync(Category category);

        void Delete(Category category);

        Category GetById(int Id);

        List<Category> GetList();

    }
}
