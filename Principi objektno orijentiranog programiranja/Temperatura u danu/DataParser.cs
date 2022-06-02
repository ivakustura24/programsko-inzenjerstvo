using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura_u_danu
{
    internal class DataParser
    {
        public DataParser() { }
        static Sensor sensor = new Sensor();
        public List <double> Parse(string sensorData)
        {
            List<double> data = new List<double>();
            string[] polje=sensor.GetData().Split(';');
            foreach (string s in polje)
            {
                double d = double.Parse(s);
                data.Add(d);
            }
            return data;
        }
    }
}
