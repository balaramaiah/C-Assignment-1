using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class ParamArrayOfInt
    {
        public static int sum(int[] arrr)
        {
            int total = 0;
            for (int i = 0; i < arrr.Length; i++)
            {
                total += arrr[i];
            }

            return total;

        }

        public static void Main()
        {
            int[] arr = new int[5] { 5, 9, 7, 2, 3 };

            Console.WriteLine(sum(arr));
            Console.ReadLine();

        }
    }
}
