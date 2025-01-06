using System;
using System.Threading;

namespace MathSolutions
{
    public class DifferentCalculations
    {
        public static void DistanceGivenAngle()
        {
            Console.Clear();
            Console.WriteLine("This program is used to determine the distance traveled around a portion of a circle \n >> given the angle of travel and the radius of the circle");
            Thread.Sleep(5000);

            (double x, double y) = MessageHandler.GatherDoubles("Please enter the angle of the arc in degrees: ", "Now enter the radius of this circle: ");

            double answer = DoingActualMath.PerformExtremeMath(x, y);

            MessageHandler.PrintAnswer($"The distance traveled around the arc of the circle is { answer } (units)\n\n");

        }

        public static void ConvertToRadian()
        {
            throw new NotImplementedException();
        }

        public static void SomethingElse()
        {
            throw new NotImplementedException();
        }
    }
}
