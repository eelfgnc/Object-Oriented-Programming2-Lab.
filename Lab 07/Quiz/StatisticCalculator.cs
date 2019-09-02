using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class StatisticCalculator:MathCalculator
    {
        public StatisticCalculator()
        {

        }
        public double Mean(double[] data)
        {
            double ave;
            double sum = 0;
            for(int i = 0; i < data.Length; i++)
            {
                sum += data[i];
            }
            ave = (sum / data.Length);
            return ave;
        }
        public double Var(double[] data, double mean)
        {
            double var;
            double sum = 0;
            for (int i = 0; i < data.Length; i++)
            {
                sum = (data[i] - mean) * (data[i] - mean);
            }
            var = (sum / (data.Length));
            return var;
        }
        public double Std(double[] data, double mean)
        {
            double std;
            double sum = 0;
            for (int i = 0; i < data.Length; i++)
            {
                sum = (data[i] - mean) * (data[i] - mean);
            }
            sum = (sum / (data.Length));
            std = Math.Sqrt(sum);
            return std;
        }
    }
}
