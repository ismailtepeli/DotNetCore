using IT.Entity.ComplexTypes;
using IT.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IT.Bussiness.Abstract
{
    public interface IProductServices
    {
        Product Add(Product product);

        Task<Product> AddAsync(Product product);

        Product Update(Product product);
        // Task<Category> UpdateAsync(Category category);
        Task<Product> UpdateAync(Product product);

        void Delete(Product product);

        Product GetById(int Id);

        Product GetByName(string Name);

        List<Product> GetList();

        List<Product> GetListByCategoryId(int CategoryId);

        List<ProductCategoryComplexData> GetProductCategoryComplexDatas();
    }
}
