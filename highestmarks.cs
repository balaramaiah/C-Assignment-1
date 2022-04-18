using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class highestmarks
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int total = 0;
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter " + i + " Student Marks:");
                arr[i] = int.Parse(Console.ReadLine());
                total = total + arr[i];
            }
            float avg = total / arr.Length;


            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }

            Console.WriteLine("Avg Of Students Marks {0}", avg);
            Console.WriteLine("highest mark is {0}", max);

            Console.ReadLine();
        }
    }
}
