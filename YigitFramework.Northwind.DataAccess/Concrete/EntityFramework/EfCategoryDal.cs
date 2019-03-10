using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YigitFramework.Core.DataAccess.EntityFramework;
using YigitFramework.Northwind.DataAccess.Abstract;
using YigitFramework.Northwind.Entities.Concrete;

namespace YigitFramework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category,NorthwindContext>,ICategoryDal
    {

    }
}
