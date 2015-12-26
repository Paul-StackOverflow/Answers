using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDPrototypes.NotPostedEfforts
{
    class PrintEvenNumbers
    {
        public PrintEvenNumbers()
        {
               
        }

        public bool Execute(String[] args)
        {
            bool retValue = false;
            List<double> TestValues = new List<double>() { 22.3, 22.6, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5, 44.5 };
            Console.WriteLine(DateTime.Now);
            List<Double> dresult1 = DFT1(TestValues);
            Console.WriteLine(DateTime.Now);
            List<Double> dresult2 = DFT2(TestValues);
            Console.WriteLine(DateTime.Now);
            return retValue;
        }
        private static List<Double> DFT2(List<double> data)
        {
            int n = data.Count;
            int m = n;// I use m = n / 2d;
            float[] real = new float[n];
            float[] imag = new float[n];
            double[] result = new double[m];
            float pi_div = (float)(2.0 * Math.PI / n);
            for (int w = 0; w < m; w++)
            {
                float a = w * pi_div;
                for (int t = 0; t < n; t++)
                {
                    real[w] += (float)(data[t] * Math.Cos(a * t)); //thinking of threading this
                    imag[w] += (float)(data[t] * Math.Sin(a * t)); //and this
                }
                result[w] = (float)(Math.Sqrt(real[w] * real[w] + imag[w] * imag[w]) / n);
            }
            return result.ToList();
        }
        private static List<Double> DFT1(List<double> data)
        {
            int n = data.Count;
            int m = n;// I use m = n / 2d;
            float[] real = new float[n];
            float[] imag = new float[n];
            double[] result = new double[m];
            float pi_div = (float)(2.0 * Math.PI / n);
            for (int w = 0; w < m; w++)
            {
                float a = w * pi_div;
                for (int t = 0; t < n; t++)
                {
                    real[w] += (float)(data[t] * Math.Cos(a * t)); //thinking of threading this
                    imag[w] += (float)(data[t] * Math.Sin(a * t)); //and this
                }
                result[w] = (float)(Math.Sqrt(real[w] * real[w] + imag[w] * imag[w]) / n);
            }
            return result.ToList();
        }
    }
}
