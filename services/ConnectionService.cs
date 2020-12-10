using System;
using Microsoft.Extensions.Configuration;

namespace DiConsoleApp.Services
{
    public class ConnectionService : IConnectionService
    {
        IConfiguration configuration;

        string ConString;

        public ConnectionService(IConfiguration configuration)
        {
            this.configuration = configuration;    
            this.ConString = configuration.GetConnectionString("Connectionstring");
        }
        
        
        /* configuration will hold SomeKey  from appsettings.json & SomeNewKey and appsettings.developement.json when environment is developement*/
        public string GetConnectionString()
        {
            return this.ConString;
        }
    }
}