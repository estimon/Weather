using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using WeatherApp.Core;

namespace WeatherApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class Adapter : BaseAdapter<forecastweather>
    {

        forecastweather[] Items;

        Activity Context;

        public Adapter(Activity context, forecastweather[] items) : base()
        {
            this.Context = context;
            this.Items = items;
        }

        public override forecastweather this[int position]
        {
            get { return Items[position]; }
        }





        public override int Count { get { return Items.Length; } }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;
            if (view == null)
                view = Context.LayoutInflater.Inflate(Resource.Layout.forecast, null);
            view.FindViewById<TextView>(Resource.Id.textView2).Text = Items[position].Temperature;
            view.FindViewById<TextView>(Resource.Id.textView3).Text = Items[position].Temperature1;
            view.FindViewById<TextView>(Resource.Id.textView4).Text = Items[position].Temperature2;
            view.FindViewById<TextView>(Resource.Id.textView5).Text = Items[position].Temperature3;
            view.FindViewById<TextView>(Resource.Id.textView6).Text = Items[position].Temperature4;


            return view;



        }

    }
}