using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class MathCalculator: SimpleCalculator
    {
        public MathCalculator()
        {

        }
        public double Sqrt(double n)
        {
            return Math.Sqrt(n);
        }
        public double Power(double n1,double n2)
        {
            return Math.Pow(n1, n2);
        }
    }
}
