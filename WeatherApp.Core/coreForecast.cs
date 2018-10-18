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

            forecastweather.Temperature = (string)results["list"][1]["main"]["temp"]+ " C "+ "| " + "Description: " + 
                (string)results["list"][1]["weather"][0]["description"] + " | " +
                (string)results["list"][1]["dt_txt"];
            forecastweather.Temperature1 = (string)results["list"][9]["main"]["temp"] + " C " + "| " + "Description: " + 
                (string)results["list"][9]["weather"][0]["description"] + " | " +
                (string)results["list"][9]["dt_txt"];
            forecastweather.Temperature2 = (string)results["list"][17]["main"]["temp"] + " C " + "| " + "Description: " + 
                (string)results["list"][17]["weather"][0]["description"] + " | " +
                (string)results["list"][17]["dt_txt"]; 
            forecastweather.Temperature3 = (string)results["list"][25]["main"]["temp"] + " C " + "| " + "Description: " + 
                (string)results["list"][25]["weather"][0]["description"] + " | " +
                (string)results["list"][25]["dt_txt"];
            forecastweather.Temperature4 = (string)results["list"][33]["main"]["temp"] + " C " + "| " + "Description: " +
                (string)results["list"][33]["weather"][0]["description"] + " | " +
                (string)results["list"][33]["dt_txt"];


            var asi = new forecastweather[1];
            asi[0] = forecastweather;

            return asi;
        }
    }
}
