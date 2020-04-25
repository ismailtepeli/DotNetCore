using IT.Bussiness.Abstract;
using IT.DataAccess.Abstract;
using IT.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IT.Bussiness.Concreate.Managers
{
    public class ProductImageManager : IProductImageServices
    {
        IProductImageDal _productImageDal;

        public ProductImageManager(IProductImageDal productImageDal)
        {
            _productImageDal = productImageDal;
        }

        public ProductImages Add(ProductImages productImages)
        {
            return _productImageDal.Add(productImages);
        }

        public void Delete(ProductImages productImages)
        {
            _productImageDal.Delete(productImages);
        }

        public ProductImages GetById(int Id)
        {
            return _productImageDal.Get(x => x.Id == Id);
        }

        public List<ProductImages> GetList()
        {
            return _productImageDal.GetAll();
        }

        public List<ProductImages> GetListByProductId(int ProductId)
        {
            return _productImageDal.GetAll(x => x.ProductId == ProductId);
        }

        public ProductImages Update(ProductImages productImages)
        {
            return _productImageDal.Update(productImages);
        }
    }
}
