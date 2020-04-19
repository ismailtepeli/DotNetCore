using IT.Core.DataAccess.EfEntityFrameworkCore;
using IT.DataAccess.Abstract;
using IT.Entity.ComplexTypes;
using IT.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace IT.DataAccess.Concreate.EntityFrameworkCore
{
    public class EfProductDall : EfEntityRepositoryBase<Product, DotNetCoreDbContext>, IProductDal
    {
        public List<ProductCategoryComplexData> GetProductCategoryComplexDatas()
        {
            using (var _context=new DotNetCoreDbContext())
            {
                var result = (from p in _context.Products
                             join c in _context.Categories on p.CategoryId equals c.Id
                             select new ProductCategoryComplexData
                             {
                                 CategoryName=c.Name,
                                 Explation=p.Explanation,
                                 Height=p.Height,
                                 ProductId=p.Id,
                                 ProductName=p.Name,
                                 Weight=p.Weight,
                                 Width=p.Width,
                                 AddedBy=p.AddedBy,
                                 AddedDate=p.AddedDate
                             }).ToList();
                return result;
            }
        }
    }
}
