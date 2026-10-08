using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    internal class StaticMethods
    {
        public static  double SimpleMath(double sum1, double sum2)
          => sum1 + sum2;

        public static int DoubleValue( int number) => number * 2;
        

        //Func<double, double, double> simpleMath = (sum1, sum2) => sum1 + sum2;

    }
}
