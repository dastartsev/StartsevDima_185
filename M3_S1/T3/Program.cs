using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public delegate double delegateConvertTemperature(double num);

    class TemperatureConverterImp
    {
        public double CtoF(double c) => (c * 9.0 / 5.0) + 32.0;

        public double FtoC(double f) => (f - 32.0) * 5.0 / 9.0;
       
    }

    class StaticTempConverters {
        public double CtoRe(double c) => c * 0.8;

        public double CtoRa(double c) => 491.67 + c * 9.0/5;

        public double CtoK(double c) => c + 273.15;

        public double RetoC(double c) => c * 0.8;

        public double RatoC(double c) => 491.67 + c * 9.0 / 5;

        public double KtoC(double c) => c + 273.15;
    }

    
    static void Main(string[] args)
    {
        TemperatureConverterImp temp = new TemperatureConverterImp();
        delegateConvertTemperature[] t = new delegateConvertTemperature[2];
        t[0] = new delegateConvertTemperature(temp.CtoF);
        t[1] = new delegateConvertTemperature(temp.FtoC);

        double celsius = 0.0;
        double fahrenheit = t[0](celsius);
        string msg1 = string.Format("Celsius = {0}, Fahrenheit = {1}",
                                                     celsius, fahrenheit);
        Console.WriteLine(msg1);

        
        fahrenheit = 212.0;
        celsius = t[1](fahrenheit);
        string msg2 = string.Format("Celsius = {0}, Fahrenheit = {1}",
                                                     celsius, fahrenheit);
        Console.WriteLine(msg2);

    }
}

