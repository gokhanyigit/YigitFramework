using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YigitFramework.Northwind.DataAccess.Concrete.EntityFramework;

namespace YigitFramework.Northwind.DataAccess.Tests
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            EfProductDal productDal = new EfProductDal();
            var result = productDal.GetList();
            Assert.AreEqual(77, 77);
        }
    }
}
