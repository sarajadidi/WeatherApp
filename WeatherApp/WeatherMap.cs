using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace WeatherApp
{
	public class WeatherMap
	{
		public static double GetTemp(string apiCall)
		{
			var client = new HttpClient();
			var response = client.GetStringAsync(apiCall).Result;
			var temp = double.Parse(JObject.Parse(response)["main"]["temp"].ToString());

			return temp;
		}
        public static double GetFeels(string apiCall)
        {
            var client = new HttpClient();
            var response = client.GetStringAsync(apiCall).Result;
            var feels = double.Parse(JObject.Parse(response)["main"]["feels_like"].ToString());

            return feels;
        }
    }
}

