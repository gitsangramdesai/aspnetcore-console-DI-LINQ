using System;
using Microsoft.Extensions.Configuration;

namespace DiConsoleApp.Services
{
    public class SomeService : ISomeService
    {
        IConfiguration configuration;

        public SomeService(IConfiguration configuration)
        {
            this.configuration = configuration;    
        }
        
        
        /*configuration will hold SomeKey & SomeNewKey*/
        public void DoProcess()
        {
            var value = configuration["SomeKey"];
            Console.WriteLine("Value from the Config is: " + value);
        }
    }
}