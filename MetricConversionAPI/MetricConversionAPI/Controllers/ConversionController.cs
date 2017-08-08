using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MetricConversionAPI.Controllers
{
    public class ConversionController : ApiController
    {
        [HttpGet]
        [Route("api/Conversion/Currency")]
        public double Currency( string from, string to, double amount )
        {

            // defining rates with by converting dollar
            double PKR = 1 / 0.0095;
            double INR = 1 / 0.016;
            double AED = 1 / 0.27;
            double USD = 1 / 1;
            double GBP = 1 / 1.31;

            double value1 = 0;
            double value2 = 0;
            switch (from)
            {
                case "PKR":
                    value1 = PKR;
                    break;
                case "INR":
                    value1 = INR;
                    break;
                case "AED":
                    value1 = AED;
                    break;
                case "USD":
                    value1 = USD;
                    break;
                case "GBP":
                    value1 = GBP;
                    break;
            }
            switch (to)
            {
                case "PKR":
                    value2 = PKR;
                    break;
                case "INR":
                    value2 = INR;
                    break;
                case "AED":
                    value2 = AED;
                    break;
                case "USD":
                    value2 = USD;
                    break;
                case "GBP":
                    value2 = GBP;
                    break;
            }


            if (value1 > value2)
            {
                return (value1/value2) * amount;
            }
            else
            {
                return (value2 / value1) * amount;
            }

            return 0;
        }

      
        [HttpGet]
        [Route("api/Conversion/Temperature")]
        public double Temperature(string from, string to, double amount)
        {
            
            if (from == "Celsius" && to == "Fahrenheit")
            {
                return amount * 1.8 + 32;
            }

            else if (from == "Fahrenheit" && to == "Celsius")
            {
                return (amount - 32) * 0.5556;
            }

            else if (from == "Celsius" && to == "Kelvin")
            {
                return  amount + 273.15;
            }

            else if (from == "Kelvin" && to == "Celsius")
            {
                return amount - 273.15;
            }

            else if (from == "Fahrenheit" && to == "Kelvin")
            {
                return (amount + 459.67) * 0.5556;
            }

            else if (from == "Kelvin" && to == "Fahrenheit")
            {
                return amount *  1.8 - 459.67;
            }
            return 0;

        }

        [HttpGet]
        [Route("api/Conversion/Weight")]
        public double Weight (string from, string to, double amount)
        {

            if (from == "Kilogram" && to == "Pound")
            {
                return amount * 2.2046;
            }

            else if (from == "Kilogram" && to == "Ounce")
            {
                return amount* 35.274;
            }

            else if (from == "Kilogram" && to == "Gram")
            {
                return amount / 0.0010000;
            }

            else if (from == "Pound" && to == "Kilogram") 
            {
                return amount / 2.2046;
            }

            else if (from == "Pound" && to == "Ounce")
            {
                return amount * 16.000;
            }

            else if (from == "Pound" && to == "Gram")
            {
                return amount / 0.0022046;
            }
            else if (from == "Ounce" && to == "Kilogram")
            {
                return amount / 35.274;
            }

            else if (from == "Ounce" && to == "Pound")
            {
                return amount * 0.062500;
            }

            else if (from == "Ounce" && to == "Gram")
            {
                return amount / 0.035274;
            }
            else if (from == "Gram" && to == "Kilogram")
            {
                return amount / 1000.0;
            }
            else if (from == "Gram" && to == "Pound")
            {
                return amount * 0.0022046;
            }
            else if (from == "Gram" && to == "Ounce")
            {
                return amount * 0.035274;
            }
            return 0;
        }

        [HttpGet]
        [Route("api/Conversion/Length")]
        public double Length(string from, string to, double amount)
        {
            if (from == "Kilometers" && to == "Miles")
            {
                return amount * 0.62137;
            }

            else if (from == "Meters" && to == "Yards")
            {
                return amount * 1.0936;
            }

            else if (from == "Meters" && to == "Feet")
            {
                return amount * 3.2808;
            }

            else if (from == "Yards" && to == "Feet")
            {
                return amount * 3.0000;
            }

            else if (from == "Centimeters" && to == "Inches")
            {
                return amount * 0.39370;
            }

            else if (from == "Millimeters" && to == "Inches")
            {
                return amount * 0.039370;
            }
            else if (from == "Feet" && to == "Inches")
            {
                return amount * 12.000;
            }

            else if (from == "Miles" && to == "Kilometers")
            {
                return amount / 0.62137;
            }

            else if (from == "Yards" && to == "Meters")
            {
                return amount / 1.0936;
            }
            else if (from == "Feet" && to == "Meters")
            {
                return amount / 3.2808;
            }
            else if (from == "Feet" && to == "Yards")
            {
                return amount * 0.33333;
            }
            else if (from == "Inches" && to == "Centimeters")
            {
                return amount / 0.39370;
            }
            else if (from == "Inches" && to == "Millimeters")
            {
                return amount / 0.039370;
            }
            else if (from == "Inches" && to == "Feet")
            {
                return amount * 0.083333;
            }
            return 0;
        }

        [HttpGet]
        [Route("api/Conversion/Area")]
        public double Area(string from, string to, double amount)
        {
            if (from == "Hectares" && to == "Acres")
            {
                return amount * 2.4711;
            }

            else if (from == "Hectares" && to == "SquareFeet")
            {
                return amount * 107640;
            }

            else if (from == "SquareMeters" && to == "SquareFeet")
            {
                return amount * 10.764;
            }

            else if (from == "SquareMeters" && to == "SquareYards")
            {
                return amount * 1.1960;
            }

            else if (from == "SquareKilometers" && to == "SquareMiles")
            {
                return amount * 0.38610;
            }

            else if (from == "Acres" && to == "Hectares")
            {
                return amount / 2.4711;
            }
            else if (from == "SquareFeet" && to == "Hectares")
            {
                return amount / 107640;
            }

            else if (from == "SquareFeet" && to == "SquareMeters")
            {
                return amount / 10.764;
            }

            else if (from == "SquareYards" && to == "SquareMeters")
            {
                return amount / 1.1960;
            }
            else if (from == "SquareMiles" && to == "SquareKilometers")
            {
                return amount / 0.38610;
            }
            return 0;
        }
    }
}
