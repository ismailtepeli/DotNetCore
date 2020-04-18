using IT.Bussiness.Abstract;
using IT.DataAccess.Abstract;
using IT.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IT.Bussiness.Concreate.Managers
{
    public class ProductManager : IProductServices
    {
        IProductDal _IProductDal;

        public ProductManager(IProductDal productDal)
        {
            _IProductDal = productDal;
        }
        public Product Add(Product product)
        {
            return _IProductDal.Add(product);
        }

        public async Task<Product> AddAsync(Product product)
        {
            return await _IProductDal.AddAsync(product);
        }

        public void Delete(Product product)
        {
            _IProductDal.Delete(product);
        }

        public Product GetById(int Id)
        {
            return _IProductDal.Get(x => x.Id == Id);
        }

        public Product GetByName(string Name)
        {
            return _IProductDal.Get(x => x.Name == Name);
        }

        public List<Product> GetList()
        {
            return _IProductDal.GetAll();
        }

        public List<Product> GetListByCategoryId(int CategoryId)
        {
            return _IProductDal.GetAll(x => x.CategoryId == CategoryId);
        }

        public Product Update(Product product)
        {
            return _IProductDal.Update(product);
        }

        public async Task<Product> UpdateAync(Product product)
        {
            return await _IProductDal.UpdateAsync(product);
        }
    }
}
