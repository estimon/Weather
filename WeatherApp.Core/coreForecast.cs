﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Core
{
    public class coreForecast
    {
        public static async Task<Weather> GetWeather(string City)
        {
            string key = "1dad50e251b03e9137b8b650a95bc9ff";
            string forecast = "https://api.openweathermap.org/data/2.5/forecast?q=" + City + "&units=metric&appid" + key;

            dynamic results = await DataService.GetDataFromService(forecast).ConfigureAwait(false);
            var weather = new Weather();
            //weather.Title = (string)results["name"];
            weather.Temperature = (string)results["main"]["temp"] + " C";
            weather.AirPressure = (string)results["main"]["pressure"] + "hpa";
            weather.WindSpeed = (string)results["wind"]["speed"] + " m/s";
            weather.type = (string)results["weather"][0]["icon"];
            return weather;
        }
    }
}