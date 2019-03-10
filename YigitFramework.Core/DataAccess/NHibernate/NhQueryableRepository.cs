using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YigitFramework.Core.Entities;

namespace YigitFramework.Core.DataAccess.NHibernate
{
    class NhQueryableRepository<T> : IQueryableRepository<T>
        where T : class, IEntity, new()
    {
        public IQueryable<T> Table => throw new NotImplementedException();
    }
}
