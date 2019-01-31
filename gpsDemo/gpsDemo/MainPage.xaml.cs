using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.Geolocator;

namespace gpsDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }



        private async void Button_Clicked(object sender, EventArgs e)
        {
            var locatorObj = CrossGeolocator.Current;
            var position = await locatorObj.GetPositionAsync(TimeSpan.FromSeconds(10));
            var lat = position.Latitude;
            var lon = position.Longitude;

            latLabel.Text = "Your latitude is: " + lat;
            lonLabel.Text = "Your longitude is: " + lon;

        }
    }
}
