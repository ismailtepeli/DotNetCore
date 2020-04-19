using IT.Core.DataAccess;
using IT.Entity.ComplexTypes;
using IT.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IT.DataAccess.Abstract
{
    public interface IProductDal: IEntityRepository<Product>
    {
        List<ProductCategoryComplexData> GetProductCategoryComplexDatas();

    }
}
