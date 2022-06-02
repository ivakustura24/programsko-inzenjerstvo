using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura_u_danu
{
    
    internal class Reporter
    {
        static DataParser data = new DataParser();
        static Sensor sensor = new Sensor();
        private double GetMinimalTemperature()
        {
            double min=0;
            List <double> listamin =data.Parse(sensor.GetData());
            min = listamin.Min();
            return min;
        }
        private double GetMaximalTemperature()
        {
            double max = 0;
            List<double> listamax = data.Parse(sensor.GetData());
            max = listamax.Max();
            return max;
        }
        private double GetAverageTemperature()
        {
            double average = 0;
            List<double> listaavg=data.Parse(sensor.GetData());
            average = listaavg.Average();
            return average;
        }
        public void GenerateReport()
        {
            Console.WriteLine($"Average temperature is {GetAverageTemperature()} °C, minimale temperature is {GetMinimalTemperature()} °C, maximal temperature is {GetMaximalTemperature()} °C ");
        }
    }
}
