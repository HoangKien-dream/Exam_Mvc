namespace Exam_WAD.Migrations
{
    using Exam_WAD.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Exam_WAD.Data.MyIdentityDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Exam_WAD.Data.MyIdentityDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var products = new List<Product>
            {
                new Product { ProductName = "SmartPhone",    CategoryID=1, QuantityPerUnit=12, UnitPrice=10000, UnitslnStock=10000,UnitsOnOrder=1000, ReoroderLevel=1,Discontinued=1  },
                new Product { ProductName = "Latop", CategoryID=2 , QuantityPerUnit=13, UnitPrice=20000, UnitslnStock=20000,UnitsOnOrder=1000, ReoroderLevel=2,Discontinued=1},
                new Product { ProductName = "Pc", CategoryID=3 , QuantityPerUnit=14, UnitPrice=30000, UnitslnStock=10000,UnitsOnOrder=1000, ReoroderLevel=1,Discontinued=1},
 
            };
            products.ForEach(s => context.Products.AddOrUpdate(s));

            var categories = new List<Category>
            {
                new Category { CategoryName = "Asus", Description="Đây là một thương hiệu nổi tiếng", Picture="https://philong.com.vn/media/brand/asus.png" },
                new Category { CategoryName = "Macbook", Description="Đây là một thương hiệu nổi tiếng", Picture="https://philong.com.vn/media/brand/asus.png"},
                new Category { CategoryName = "MSI", Description="Đây là một thương hiệu nổi tiếng", Picture="https://philong.com.vn/media/brand/asus.png"},
            };
            categories.ForEach(s => context.Categories.AddOrUpdate(s));
            context.SaveChanges();
        }
    }
}
