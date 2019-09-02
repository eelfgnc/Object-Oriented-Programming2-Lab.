using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class TrigonometricCalculator:MathCalculator
    {
        public TrigonometricCalculator()
        {

        }
        public double Cos(double n)
        {
            double rd1 = n * (Math.PI / 180);
            double rd2 = Math.Cos(rd1);
            double derece = rd2 * (180 / Math.PI);
            return derece;

        }
        public double Sin(double n)
        {
            double rd1 = n * (Math.PI / 180);
            double rd2 = Math.Sin(rd1);
            double derece = rd2 * (180 / Math.PI);
            return derece;
        }
        public double Tan(double n)
        {
            double rd1 = n * (Math.PI / 180);
            double rd2 = Math.Tan(rd1);
            double derece = rd2 * (180 / Math.PI);
            return derece;
        }
        public double Cot(double n)
        {
            double rd1 = n * (Math.PI / 180);
            double rd2 = 1 / (Math.Tan(rd1));
            double derece = rd2 * (180 / Math.PI);
            return derece;
        }
        public double ACos(double n)
        {
            double rd1 = n * (Math.PI / 180);
            double rd2 = Math.Acos(rd1);
            double derece = rd2 * (180 / Math.PI);
            return derece;
        }
        public double ASin(double n)
        {
            double rd1 = n * (Math.PI / 180);
            double rd2 = Math.Asin(rd1);
            double derece = rd2 * (180 / Math.PI);
            return derece;
        }
        public double ATan(double n)
        {
            double rd1 = n * (Math.PI / 180);
            double rd2 = Math.Atan(rd1);
            double derece = rd2 * (180 / Math.PI);
            return derece;
        }
    }
}
