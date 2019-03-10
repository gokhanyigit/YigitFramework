# YigitFramework v.1.0.0.0

YigitFramework Firmasının Northwind isimli bir projesi oluşturulmaktadır. 

    YigitFramework.Core
    YigitFramework.Northwind.Business
    YigitFramework.Northwind.Business.Tests
    YigitFramework.Northwind.DataAccess
    YigitFramework.Northwind.DataAccess.Tests
    YigitFramework.Northwind.Entities
    YigitFramework.Northwind.MVCWebUI
    YigitFramework.Northwind.MVCWebUI.Tests
    YigitFramework.Northwind.WcfService
    YigitFramework.Northwind.WebApi

YigitFramework v1.0.0.0
Bu versionda Solution üzerinde projeler oluşturulmuştur. Sonrasında da aşağıda belirtilen işlemler gerçekleştirilmiştir. 
Genel olarak veriye erişim işlemleri için Entity Framework ve NHibernate teknolojilerinin altyapıları oluşturulmuştur.

YigitFramework.Core içerisinde;

İlk olarak aşağıdaki arayüzler oluşturuldu.                                                	
  IEntity                                                  
	IEntityRepository                       
	IQueryableRepository                   

Daha sonra ise EntityFramework ve Nhibernate teknolojileri için RepositoryBase implementasyonları oluşturuldu.        
	EfEntityRepositoryBase              
	EfQueryableRepository                
	NhEntityRepositoryBase                
	NhQueryableRepository           
                 
YigitFramework.Northwind.DataAccess içerisinde ise veriye erişebilmek için Entity Framework ve NHibernate teknolojileri için implementasyonlar yapılmaktadır.                           
EntityFramework;          
   Mapping             
		  ProductMap              
		  CategoryMap                
	  EfCategoryDal               
	  EfProductDal             
	  NorthwindContext              
	NHibernate;               
	  Helpers                
		  SqlServerHelper              
    Mapping             
		  ProductMap                
		  CategoryMap                 
	  NhCategoryDal                                           
	  NhProductDal           

YigitFramework.Northwind.DataAccess.Tests projesinde de basit bir şekilde test metodu yapılmaktadır.
