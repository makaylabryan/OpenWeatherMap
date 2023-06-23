using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace OpenWeatherMap_Activity
{
    public partial class Program
    {

        static void Main(string[] args)
        {
            var client = new HttpClient();
            
            Console.WriteLine("Please enter your API key.");
            var key = Console.ReadLine();

            while (true)
            {
                Console.WriteLine();

                Console.WriteLine("Please enter the city you would like to know the weather of.");
                var city = Console.ReadLine();
                Console.WriteLine();

                var weatherURL = $"https://api.openweathermap.org/data/2.5/forecast?q={city}&appid={key}&units=imperial";
                var response = client.GetStringAsync(weatherURL).Result;

                var root = JsonConvert.DeserializeObject<Root>(response);

                foreach (var item in root.list)
                {
                    Console.WriteLine($"The current temperature is: {item.main.temp}");
                    Console.WriteLine();
                    break;
                }


            }
        }
    }
}
