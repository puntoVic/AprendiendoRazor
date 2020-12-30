﻿using Entities;
using System.Collections.Generic;
using DataAccess;
using System.Linq;


namespace Bussines
{
    public class B_Product
    {
        public static List<ProductEntity> ProductList()
        {
            using (var db = new InventaryContext())
            {
                return db.Products.ToList();
            }
        }

        public static ProductEntity ProductById(string Id)
        {
            using (var db = new InventaryContext())
            {
                return db.Products.ToList().LastOrDefault(p => p.ProductId == Id);
            }
        }

        public static void CreateProduct(ProductEntity oProduct)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Add(oProduct);
                db.SaveChanges();
            }
        }

        public static void UpdateProduct(ProductEntity oProduct)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Update(oProduct);
                db.SaveChanges();
            }
        }
    }
}
