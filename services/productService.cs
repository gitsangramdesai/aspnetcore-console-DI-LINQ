using System;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using DiConsoleApp.Models;

namespace DiConsoleApp.Services
{
    public class ProductService 
    {
        public static bool InsertProduct(string productName)
        {
             using (var db = new EFContext())
            {
                if(productName.Length > 0)
                {
                    Product product = new Product();
                    product.name = productName;
                    db.Add(product);
    
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    
        public static bool updateProduct(int productId,string productName)
        {
            using (var db = new EFContext())
            {
                Product product = db.Products.Find(productId);

                if(product != null)
                {
                    product.name = productName;
                    db.SaveChanges();
                    return true;
                }else{
                    return false;
                }
            }
        }

        public static bool deleteProduct(int productId)
        {
            using (var db = new EFContext())
            {
        
                Product product = db.Products.Find(productId);

                if(product != null)
                {
                    db.Products.Remove(product);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static void readProduct()
        {
        
            using (var db = new EFContext())
            {
                List<Product> products = db.Products.ToList();
                foreach (Product p in products)
                {
                    Console.WriteLine("{0} {1}", p.id, p.name);
                }
            }
            return;
        }
    }
    
}