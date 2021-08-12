using System;
using Microsoft.Extensions.Configuration;

namespace ConfigurationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddCommandLine(args)
                .Build();

            var value = configuration.GetSection("key").Value;
            Console.WriteLine(value);
        }
    }
}
