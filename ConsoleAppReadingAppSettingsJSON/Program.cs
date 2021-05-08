using System;
using System.IO;
using ConsoleAppReadingAppSettingsJSON;
using Microsoft.Extensions.Configuration;
namespace ConsoleApplication
{
    class Program
    {
        static AppSettings appSettings = new AppSettings();
        static void Main(string[] args)
        {
            // ------------- How to read from the config file ------------- //
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("MyAppSettings.json", optional: true, reloadOnChange: true);
            var configuration = builder.Build();
            ConfigurationBinder.Bind(configuration.GetSection("AppSettings"), appSettings);

            // ------------- The rest of your program here ------------- //
            // ToDo: how to read from Sub-classes of configuration file
            Console.WriteLine("InMemory = " + appSettings.InMemory);
            Console.WriteLine("IsProduction = " + appSettings.IsProduction);
            Console.WriteLine("Title = " + appSettings.Title);
        }
    }
}