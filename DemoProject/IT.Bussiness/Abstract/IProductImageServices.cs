using IT.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IT.Bussiness.Abstract
{
    public interface IProductImageServices
    {
        ProductImages Add(ProductImages productImages);

        ProductImages Update(ProductImages productImages);

        void Delete(ProductImages productImages);

        ProductImages GetById(int Id);

        List<ProductImages> GetList();

        List<ProductImages> GetListByProductId(int ProductId);
    }
}
