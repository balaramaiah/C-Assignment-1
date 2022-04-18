using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Swapping
    {
        public static void Swap()
        {
            int a = 2, b = 3, temp;

            Console.WriteLine("Before Swapping a= {0}, b= {1}", a, b);

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("After Swapping a= {0}, b= {1}", a, b);

            

        }
        public static void Main()
        {
            Swap();
            Console.ReadKey();
        }
    }
}
