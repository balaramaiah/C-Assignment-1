using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Calculation
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter a First Number: ");
            int x = int.Parse(Console.ReadLine());        //Reading input from user

            Console.WriteLine("Enter a Second Number: ");
            int y = int.Parse(Console.ReadLine());

            //Here user decission for which operation perform 
            
            Console.WriteLine("1:Addition");
            Console.WriteLine("2:Subtraction");
            Console.WriteLine("3:Multiplication");
            Console.WriteLine("4:Division");
            Console.WriteLine("Enter Your Choice :");
            int z = Convert.ToInt32(Console.ReadLine());

            switch (z)
            {
                case 1:
                    Console.WriteLine("Addition of Two Numbers :" + (x + y));           //addition operation
                    break;
                case 2:
                    Console.WriteLine("Substraction of Two Numbers :" + (x - y));       //Substraction operation
                    break;
                case 3:
                    Console.WriteLine("Multiplication of Two Numbers :" + (x * y));     //Multiplication operation
                    break;
                case 4:
                    Console.WriteLine("Division of Two Numbers :" + (x / y));           //Division operation
                    break;
                default:
                    Console.WriteLine("Choose frpm 1 to 6 :");
                    break;
            }

            Console.ReadKey();
        }
    }
}
