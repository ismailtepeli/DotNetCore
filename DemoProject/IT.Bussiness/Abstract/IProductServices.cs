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

        Product UpdateAync(Product product);

        void Delete(Product product);

        Product GetById(int Id);

        List<Product> GetList();

        List<Product> GetListByCategoryId(int CategoryId);
    }
}
