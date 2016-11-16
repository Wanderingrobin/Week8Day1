using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace WeatherApp.Models
{
    public class WeatherClass
    {
        public object GetCurrentWeather()
        {
            string url = "http://api.openweathermap.org/data/2.5/weather?q=Detroit&APPID=49057b49dcba359682f89d7f53ef8395&units=imperial";
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<object>(content);

            return jsonContent;
            
        }
    }
}