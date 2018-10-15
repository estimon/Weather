using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Core
{
    public class coreForecast
    {
        public static async Task<forecastweather> GetForecastweather(string City)
        {
            string key = "1dad50e251b03e9137b8b650a95bc9ff";
            string forecast = "https://api.openweathermap.org/data/2.5/forecast?q=" + City + "&units=metric&appid=1dad50e251b03e9137b8b650a95bc9ff";

            dynamic results = await DataService.GetDataFromService(forecast).ConfigureAwait(false);
            var forecastweather = new forecastweather();
            //weather.Title = (string)results["name"];
            forecastweather.Temperature = (string)results["list"][0]["main"]["temp"] + " C";
            //forecastweather.type = (string)results["weather"][0]["icon"];
            return forecastweather;
        }
    }
}
