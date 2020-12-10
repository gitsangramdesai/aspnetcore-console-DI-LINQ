using System;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using DiConsoleApp.Models;
using System.Collections.Generic;
using DiConsoleApp.Services;

namespace DiConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*dependency injection*/
            var startup = new Startup();

            ///some service
            var service = startup.Provider.GetRequiredService<ISomeService>();
            service.DoProcess();

            //connection service
            var connectionService = startup.Provider.GetRequiredService<IConnectionService>();
            string conStr = connectionService.GetConnectionString();

            Console.WriteLine("connection string" + conStr);
            /*dependency injection*/

            /*linq*/
            ProductService.readProduct();
            
            //INSERT
            // if (ProductService.InsertProduct("INK Pen")==true)
            // {
            //     Console.WriteLine("INK PEN INSERTED");
            // }

            //UPDATE
            // if (ProductService.updateProduct(3,"THE INK Pen")==true)
            // {
            //     Console.WriteLine("INK PEN Updated");
            // }

            //DELETE
            // if(ProductService.deleteProduct(3)==true)
            // {
            //     Console.WriteLine("INK Pen Deleted");
            // }
        }
    }

        
}
