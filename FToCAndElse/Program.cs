using System;
using System.Linq;

namespace FToCAndElse
{

    public class Temperature
    {
        public bool isCelsius { get; set; }
        public double Value { get; set; }

        public Temperature(double Value,bool isCelsius=true)
        {
           this.isCelsius = isCelsius;
           this.Value = Value;

        }
        public static double ConvertToF(Temperature temperature)
        {
            if (temperature.isCelsius)
            {
                return temperature.Value * 1.8 + 32;
            }
            return temperature.Value;
        }
        
        public static double ConvertToC(Temperature temperature)
        {
            if (temperature.isCelsius)
            {
                return temperature.Value;
            }
            return (temperature.Value-32)/1.8;
        }

        public static double GetAverage(Temperature[] temperatures)
        {
            //double result=0;

            //for (int i = 0; i < temperatures.Length; i++)
            //{
            //    result+=temperatures[i].Value;

            //}
            //return result / temperatures.Length;

            return temperatures.Sum(t => t.Value) / temperatures.Length; //nuyna inchvor forum

        }
        public static double operator + (Temperature temperature, double num)
        {
            return temperature.Value + num;
        }
        public static double operator -(Temperature temperature, double num)
        {
            return temperature.Value - num;
        }
        public static double operator * (Temperature temperature, double num)
        {
            return temperature.Value * num;
        }
        public static double operator / (Temperature temperature, double num)
        {
            return temperature.Value / num;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            var temp = new Temperature(23.4, isCelsius:true);
            var fTemp = Temperature.ConvertToF(temp);
            Console.WriteLine(fTemp);
            var cTemp = Temperature.ConvertToC(temp);
            Console.WriteLine(cTemp);
            var temp2 = temp + 12.3;
            int x = 1;    
            var daily = new[] { new Temperature(1), new Temperature(-6), new Temperature(11) };
            var average = Temperature.GetAverage(daily);
        }
    }
}
