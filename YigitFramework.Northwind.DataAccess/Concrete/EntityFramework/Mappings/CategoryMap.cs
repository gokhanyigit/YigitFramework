﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YigitFramework.Northwind.Entities.Concrete;

namespace YigitFramework.Northwind.DataAccess.Concrete.EntityFramework.Mappings
{
    public class CategoryMap: EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable(@"Categories", @"dbo");
            HasKey(x => x.CategoryId);

            Property(x => x.CategoryId).HasColumnName("CategoryId");
            Property(x => x.CategoryName).HasColumnName("CategoryName");
        }
    }
}