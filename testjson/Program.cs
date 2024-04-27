using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace testjson
{
    [JsonDerivedType(typeof(WeatherForecastBase), typeDiscriminator: "base")]
    [JsonDerivedType(typeof(WeatherForecastWithCity), typeDiscriminator: "with1City")]
    public class WeatherForecastBase
    {
        public DateTimeOffset Date { get; set; }
    }

    public class WeatherForecastWithCity : WeatherForecastBase
    {
        public string City { get; set; }

        public int TemperatureCelsius { get; set; }
        public string Summary { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherForecastBase weather = new WeatherForecastWithCity
            {
                City = "Milwaukee",
                Date = new DateTimeOffset(2022, 9, 26, 0, 0, 0, TimeSpan.FromHours(-5)),
                TemperatureCelsius = 15,
                Summary = "Cool"
            };
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            List<WeatherForecastBase> list = new List<WeatherForecastBase>();
            list.Add(weather);
            WeatherForecastBase weatherbase = new WeatherForecastBase()
            {
                Date = new DateTimeOffset(2023, 9, 26, 0, 0, 0, TimeSpan.FromHours(-5)),

            };
            list.Add(weatherbase);
            
            var json = JsonSerializer.Serialize(list, options);
            Console.WriteLine(json);
            Console.ReadLine();
        }
    }
}
