using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Core
{
    public class coreForecast
    {
        public static async Task<forecastweather[]> GetForecastweather(string City)
        {
            //string key = "1dad50e251b03e9137b8b650a95bc9ff";
            string forecast = "https://api.openweathermap.org/data/2.5/forecast?q=" + City + "&units=metric&appid=1dad50e251b03e9137b8b650a95bc9ff";

            dynamic results = await DataService.GetDataFromService(forecast).ConfigureAwait(false);

            var forecastweather = new forecastweather();

            forecastweather.Temperature = (string)results["list"][0]["main"]["temp"]+ " C " + "Description: " + (string)results["list"][0]["weather"][0]["description"];
            forecastweather.Temperature1 = (string)results["list"][1]["main"]["temp"] + " C " + "Description: " + (string)results["list"][1]["weather"][0]["description"];
            forecastweather.Temperature2 = (string)results["list"][2]["main"]["temp"] + " C " + "Description: " + (string)results["list"][2]["weather"][0]["description"];
            forecastweather.Temperature3 = (string)results["list"][3]["main"]["temp"] + " C " + "Description: " + (string)results["list"][3]["weather"][0]["description"];
            forecastweather.Temperature4 = (string)results["list"][4]["main"]["temp"] + " C " + "Description: " + (string)results["list"][4]["weather"][0]["description"];


            var asi = new forecastweather[1];
            asi[0] = forecastweather;

            return asi;
        }
    }
}
