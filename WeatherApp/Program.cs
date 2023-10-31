using System;
using System.IO;
using Newtonsoft.Json.Linq;
using WeatherApp;

namespace WeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = File.ReadAllText("appsettings.json");
            string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();

            Console.WriteLine("Please enter your zip code");
            var zipCode = Console.ReadLine();

            var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&appid={APIKey}&units=imperial";

            Console.WriteLine();

            Console.WriteLine($"It is currently {WeatherMap.GetTemp(apiCall)} degrees F in your location.");
        }
    }

}


