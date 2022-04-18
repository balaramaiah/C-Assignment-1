using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class CircleandCercumference
    {
        public static void CircumCircle()
        {
            Console.WriteLine("Enter The Radius Of The Circle :");
            double r = Convert.ToDouble(Console.ReadLine());
            double AreaOfCircle = Math.PI * r * r;
            double CircumferenceOfCircle = Math.PI * 2 * r;

            Console.WriteLine("Area Of The Circle is :" + AreaOfCircle);
            Console.WriteLine("Circumference Of The Circle is :" + CircumferenceOfCircle);
            Console.ReadLine();

        }
        public static void Main(string[] arg)
        {
            CircumCircle();

        }
    }
}
