using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TravelApp.Properties;
using System.Reflection;
using System.Resources;
using System.Net.Http;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;

namespace TravelApp
{
    public partial class WeatherControl : UserControl
    {
     
        public WeatherControl()
        {
            InitializeComponent();
        }

        public class WeatherResponse
        {
            public double latitude { get; set; }
            public double longitude { get; set; }
            public string address { get; set; }
            public string timezone { get; set; }
            public string description { get; set; }
            public float temp { get; set; }
            public List<DayWeather> days { get; set; }
        }

        public class DayWeather
        {
            public string datetime { get; set; }
            public double tempmax { get; set; }
            public double tempmin { get; set; }
            public double temp { get; set; }

            public string icon { get; set; }
            
        }

     
        private async void WeatherControl_Load(object sender, EventArgs e)
        {
            string apiUrl = $"https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/{"Rzeszow"}?unitGroup=metric&key=6GAQAJFZVWYN7NQYCJZKMRR34&contentType=json";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();

                        WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(responseData);
                        DayWeather firstDayWeather = weatherResponse.days[0];

                        string resourceName = $"{firstDayWeather.icon}.png";

                        System.Drawing.Image image = TravelApp.Properties.Resources.ResourceManager.GetObject(firstDayWeather.icon) as System.Drawing.Image;

                        labelDescription.Text = weatherResponse.description;
                        labelCity.Text = weatherResponse.address;
                        labelData.Text = $"Data: {firstDayWeather.datetime.ToString()}";
                        lebelTempMax.Text = $"Temp max: {firstDayWeather.tempmax.ToString()}";
                        labelTempMin.Text = $"Temp min: {firstDayWeather.tempmax.ToString()}";
                        labelTemp.Text = $"Temp: {firstDayWeather.tempmax.ToString()}";

                        panelLogo.BackgroundImage = image;

                  
                    }
                    else
                    {
                        Console.WriteLine($"Błąd: {response.StatusCode}");
                        labelCity.Text = response.StatusCode.ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Wystąpił wyjątek: {ex.Message}");
                    labelCity.Text = ex.Message.ToString();
                }
            }
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {

            string city = textBoxCity.Text;
            string apiUrl = $"https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/{city}?unitGroup=metric&key=6GAQAJFZVWYN7NQYCJZKMRR34&contentType=json";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();

                        WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(responseData);
                        DayWeather firstDayWeather = weatherResponse.days[0];

                        string resourceName = $"{firstDayWeather.icon}.png";

                        System.Drawing.Image image = TravelApp.Properties.Resources.ResourceManager.GetObject(firstDayWeather.icon) as System.Drawing.Image;

                        labelDescription.Text = weatherResponse.description;
                        labelCity.Text = weatherResponse.address;
                        labelData.Text = $"Data: {firstDayWeather.datetime.ToString()}";
                        lebelTempMax.Text = $"Temp max: {firstDayWeather.tempmax.ToString()}";
                        labelTempMin.Text = $"Temp min: {firstDayWeather.tempmax.ToString()}";
                        labelTemp.Text = $"Temp: {firstDayWeather.tempmax.ToString()}";

                        panelLogo.BackgroundImage = image;


                    }
                    else
                    {
                        // Obsłuż błędy HTTP, jeśli wystąpiły
                        Console.WriteLine($"Błąd: {response.StatusCode}");
                        labelCity.Text = response.StatusCode.ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Wystąpił wyjątek: {ex.Message}");
                    labelCity.Text = ex.Message.ToString();
                }
            }
        }
    }
}
