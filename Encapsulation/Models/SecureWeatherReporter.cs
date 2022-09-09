using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Models
{
    public class SecureWeatherReporter
    {
        private string _location;
        private double _temperature;

        public SecureWeatherReporter(string location, double temperature)
        {
            _location = location;
            _temperature = temperature;
        }

        public string DisplayTheWeatherDetails()
        {
            if (_location != "London")
            {
                var farenheitTemperature = ConvertTheTemperatureFromCelciusToFarenheit();
                return $"I am in {_location} and the temperature is {farenheitTemperature}° {FindTemperatueMeasureFromCity()}. {GetTheWeatherDetails()}";
            }
            else
                return $"I am in {_location} and the temperature is {_temperature}° {FindTemperatueMeasureFromCity()}. {GetTheWeatherDetails()}";
        }

        public double ConvertTheTemperatureFromCelciusToFarenheit()
        {
            return (9.0 / 5.0) * _temperature + 32;
        }

        public string FindTemperatueMeasureFromCity()
        {
            if (_location != "London")
                return "F";
            else
                return "C";
        }

        public string GetTheWeatherDetails()
        {
            if (_temperature > 30)
                return "It's too hot.";
            else if (_temperature < 10)
                return "It's too cold.";
            return "Ahhh...it's just right!";
        }

    }
}
