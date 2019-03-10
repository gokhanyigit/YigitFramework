using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YigitFramework.Northwind.Entities.Concrete;

namespace YigitFramework.Northwind.DataAccess.Concrete.NHibernate.Mappings
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            // Nesnenin hagi tabloya gideceğini
            Table(@"Products");
            // NH 'de LazyLoad 'ı aktif etmek için yazıyoruz.
            LazyLoad();
            // PrimaryKey alanı bizim için ProductID alanıdır.
            // Kolon olarak da veri tabanında ProductID 'yi ara.
            Id(x => x.ProductId).Column("ProductID");

            // Diğer alanları da Map ediyoruz.
            Map(x => x.CategoryId).Column("CategoryID");
            Map(x => x.ProductName).Column("ProductName");
            Map(x => x.QuantityPerUnit).Column("QuantityPerUnit");
            Map(x => x.UnitPrice).Column("UnitPrice");
        }
    }
}
