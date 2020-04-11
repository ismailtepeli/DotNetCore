using IT.Core.DataAccess;
using IT.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IT.DataAccess.Abstract
{
    public interface ICategoryDal: IEntityRepository<Category>
    {
        // joinli işlemlerde buraya kod yazıcan 
    }
}
