using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using WeatherApp.Core;

namespace WeatherApp
{
    [Activity(Label = "ForecastActivitycs")]
    public class ForecastActivitycs : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            //   SetContentView(Resource.Layout.forecast);
            base.OnCreate(savedInstanceState);
           
            SetContentView(Resource.Layout.layout1);

            var btn = FindViewById<Button>(Resource.Id.button1);

            btn.Click += Button_Click;

        }

        private async void Button_Click(object sender, System.EventArgs e)
        {
            var edit = FindViewById<EditText>(Resource.Id.textInputEditText1);
            var list = FindViewById<ListView>(Resource.Id.listView1);
            forecastweather[] forecasts = await Core.coreForecast.GetForecastweather(edit.Text);
            list.Adapter = new Adapter(this, forecasts);

        }





    }
}