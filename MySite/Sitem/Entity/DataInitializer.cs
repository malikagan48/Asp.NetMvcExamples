using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitem.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){Name="Kamera",Description="Kamera ürünleri"},
                new Category(){Name="Telefon",Description="Telefon ürünleri"},
                new Category(){Name="Bilgisayar",Description="Bilgisayar ürünleri"}
            };
            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();
            var urunler = new List<Product>()
            {
                new Product(){Name="Canon",Description="kamera ürünleri",Price=2500,Stock=125,IsHome=true,IsApproved=true,IsFeatured=false,Slider=true,CategoryId=1,image="1.jpg" },
                new Product(){Name="Asus",Description="bilgisayar ürünleri",Price=2000,Stock=100,IsHome=true,IsApproved=true,IsFeatured=true,Slider=true,CategoryId=3,image="2.jpg" },
                new Product(){Name="Lenova",Description="bilgisayar ürünleri",Price=3500,Stock=50,IsHome=false,IsApproved=true,IsFeatured=true,Slider=false,CategoryId=3,image="3.jpg" },
                new Product(){Name="Samsung",Description="telefon ürünleri",Price=5000,Stock=200,IsHome=true,IsApproved=true,IsFeatured=true,Slider=true,CategoryId=2,image="4.jpg" },
            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}