using IT.Core.DataAccess.EfEntityFrameworkCore;
using IT.DataAccess.Abstract;
using IT.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IT.DataAccess.Concreate.EntityFrameworkCore
{
    public class EfProductDall : EfEntityRepositoryBase<Product, DotNetCoreDbContext>, IProductDal
    {
    }
}
