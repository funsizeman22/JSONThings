using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Console;

namespace ConsoleApp5
{
    public class Program
    {
        public static void Main()
        {
            var weatherForecast = new weatherforcast
            {
                Date = DateTime.Parse("2019-08-01"),
                TemperatureCelsius = 25,
                Summary = "Hot"
            };
            var PhoenixForcast = new weatherforcast
            {
                Date = DateTime.Parse("2022-03-22"),
                TemperatureCelsius = 28,
                Summary = "Warm"
            };

            string jsonString = JsonSerializer.Serialize(weatherForecast);
            WriteLine(jsonString);
            string phoenixstring = JsonSerializer.Serialize(PhoenixForcast);
            WriteLine(phoenixstring);

            weatherforcast w = JsonSerializer.Deserialize<weatherforcast>(phoenixstring);
            WriteLine(w.Summary);

            ReadKey();
        }
    }

}
