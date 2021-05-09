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
            Console.WriteLine("InMemory = " + appSettings.InMemory);
            Console.WriteLine("IsProduction = " + appSettings.IsProduction);
            Console.WriteLine("Title = " + appSettings.Title);
            Console.WriteLine("Some Number = " + appSettings.SumNumber);
            Console.WriteLine("Sub prop object -> Name = " + appSettings.PropObject.Name);
            Console.WriteLine("Sub prop object -> SumNumber = " + appSettings.PropObject.SumNumber);
        }
    }
}