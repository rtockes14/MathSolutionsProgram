using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSolutions
{
    public class DoingActualMath
    {
        public static double PerformExtremeMath(double angle, double radius)
        {
            // convert to radian, then find length of arc
            double radian = ((angle*3.14159)/180);

            double output = radian * radius;
            
            return output;
        }
    }
}
