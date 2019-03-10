using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YigitFramework.Core.DataAccess.NHibernate;
using YigitFramework.Northwind.DataAccess.Abstract;
using YigitFramework.Northwind.Entities.ComplexTypes;
using YigitFramework.Northwind.Entities.Concrete;

namespace YigitFramework.Northwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : NhEntityRepositoryBase<Product>, IProductDal
    {
        private NHibernateHelper _nHibernateHelper;
        public NhProductDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public List<ProductDetail> GetProductDetails()
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                var result = from p in session.Query<Product>()
                             join c in session.Query<Category>()
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetail
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName
                             };
                return result.ToList();
            }
        }
    }
}

// Dependeny Injection yapabilmemiz için sen bir IProductDal 'sın diyoruz.
// nHibernateHelper 'ı enjekte edebilecek şekilde kurucuya veriyoruz. 
// Buradan da base'e yani NhEntityRepositoryBase ' e nHibernateHelper'i göndermiş oluyoruz.
// Bu durumda da NhEntityRepositoryBase içinde nHibernateHelper set edilmiş olacak ve 
// nHibernateHelper; SqlServer ise ona göre Oracle ise ona göre ilgili işlemleri yapacaktır.
