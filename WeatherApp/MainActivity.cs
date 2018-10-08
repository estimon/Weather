using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace WeatherApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var SearchButton = FindViewById<Button>(Resource.Id.button1);
            

            SearchButton.Click += Button_Click;

            

            
        }
        private async void Button_Click(object sender, System.EventArgs e)
        {
            var progress = FindViewById<ProgressBar>(Resource.Id.progressBar1);
            progress.Visibility = Android.Views.ViewStates.Visible;
            var City1 = FindViewById<EditText>(Resource.Id.citysearch);
            var weather = await Core.Core.GetWeather(City1.Text);

            
            
            var MainTemp = FindViewById<TextView>(Resource.Id.temptext);
            MainTemp.Text = weather.Temperature;
            var WindSpeed = FindViewById<TextView>(Resource.Id.windtext);
            WindSpeed.Text = weather.WindSpeed;
            var MainPressure = FindViewById<TextView>(Resource.Id.prestext);
            MainPressure.Text = weather.AirPressure;
        }
    }
}