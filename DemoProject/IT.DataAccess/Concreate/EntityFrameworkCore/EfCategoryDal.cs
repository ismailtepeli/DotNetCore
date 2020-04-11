using IT.Core.DataAccess.EfEntityFrameworkCore;
using IT.DataAccess.Abstract;
using IT.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IT.DataAccess.Concreate.EntityFrameworkCore
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, DotNetCoreDbContext>, ICategoryDal
    {
    }
}
