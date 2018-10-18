using System;
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Net;
using System.IO;
using System.Text;
using WeatherApp.Core;
using Android.Content;
using Android.Views;
using System.Collections.Generic;
using System.Linq;

namespace WeatherApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {



        protected override void OnCreate(Bundle savedInstanceState)
        {



            SetContentView(Resource.Layout.activity_main);
            base.OnCreate(savedInstanceState);
            var SearchButton = FindViewById<Button>(Resource.Id.button1);
            var forecastbtn = FindViewById<Button>(Resource.Id.button3);

            SearchButton.Click += Button_Click;
            forecastbtn.Click += Button_Click1;


        }

        private async void Button_Click(object sender, System.EventArgs e)
        {
            try
            {
                var City1 = FindViewById<EditText>(Resource.Id.citysearch);
                var weather = await Core.Core.GetWeather(City1.Text);
                var Picture = FindViewById<ImageView>(Resource.Id.imageView1);
                var MainTemp = FindViewById<TextView>(Resource.Id.temptext);
                var WindSpeed = FindViewById<TextView>(Resource.Id.windtext);
                var MainPressure = FindViewById<TextView>(Resource.Id.prestext);

                MainTemp.Text = weather.Temperature;
                WindSpeed.Text = weather.WindSpeed;
                MainPressure.Text = weather.AirPressure;


                switch (weather.type)
                {
                    case ("01d"):

                        Picture.SetImageResource(Resource.Drawable.sun);
                        break;

                    case ("02d"):
                        Picture.SetImageResource(Resource.Drawable.fewclouds);
                        break;

                    case ("03d"):
                        Picture.SetImageResource(Resource.Drawable.scatteredclouds);
                        break;

                    case ("04d"):
                        Picture.SetImageResource(Resource.Drawable.brokenclouds);
                        break;

                    case ("09d"):
                        Picture.SetImageResource(Resource.Drawable.showerrain);
                        break;

                    case ("10d"):
                        Picture.SetImageResource(Resource.Drawable.rain);
                        break;

                    case ("11d"):
                        Picture.SetImageResource(Resource.Drawable.thunderstorm);
                        break;

                    case ("13d"):
                        Picture.SetImageResource(Resource.Drawable.snow);
                        break;

                    case ("50d"):
                        Picture.SetImageResource(Resource.Drawable.mist);
                        break;

                    case ("01n"):
                        Picture.SetImageResource(Resource.Drawable.sun1n);
                        break;

                    case ("02n"):
                        Picture.SetImageResource(Resource.Drawable.fewcloudsn);
                        break;

                    case ("03n"):
                        Picture.SetImageResource(Resource.Drawable.scatteredcloudsn);
                        break;

                    case ("04n"):
                        Picture.SetImageResource(Resource.Drawable.brokencloudsn);
                        break;

                    case ("09n"):
                        Picture.SetImageResource(Resource.Drawable.showerrainn);
                        break;

                    case ("10n"):
                        Picture.SetImageResource(Resource.Drawable.rainn);
                        break;

                    case ("11n"):
                        Picture.SetImageResource(Resource.Drawable.thunderstromn);
                        break;

                    case ("13n"):
                        Picture.SetImageResource(Resource.Drawable.snown);
                        break;

                    case ("50n"):
                        Picture.SetImageResource(Resource.Drawable.mistn);
                        break;
                }
            }

            catch (Exception)
            {
                Toast.MakeText(Application,("City not found"), ToastLength.Long).Show();
            }
            

        }
        private void Button_Click1(object sender, System.EventArgs e)
        {
            var forecastactivity = new Intent(this, typeof(ForecastActivitycs));
            StartActivity(forecastactivity);

            //var City1 = FindViewById<EditText>(Resource.Id.citysearch);
            //forecastweather[] forecasts = await Core.coreForecast.GetForecastweather(City1.Text);


            //var list = FindViewById<ListView>(Resource.Id.listView1);
            //list.Adapter = new Adapter(this, forecasts);

           // SetContentView(Resource.Layout.forecast);

            
            
        }





    }
}