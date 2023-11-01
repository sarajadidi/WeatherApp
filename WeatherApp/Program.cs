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

            //Console.WriteLine();

            //Console.WriteLine($"It is currently {WeatherMap.GetTemp(apiCall)} degrees F in your location.");

            double temperature = WeatherMap.GetTemp(apiCall);

            Console.WriteLine();
            Console.WriteLine($"It is currently {temperature} degrees F in your location.");

            if (temperature < 32)
            {
                Console.WriteLine("It's very cold. Stay bundled up!");
            }
            else if (temperature < 50)
            {
                Console.WriteLine("It's a bit chilly. Consider wearing a jacket.");
            }
            else if (temperature < 70)
            {
                Console.WriteLine("The weather is mild. A light jacket might be enough.");
            }
            else
            {
                Console.WriteLine("It's warm. Enjoy the pleasant weather!");
            }
        }
    }
}
   

