using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
   public enum BookType
    {
        Magazine,
        Novel,
        ReferenceBook,
        Miscellaneous
    }

    class StructureBook
    {

        public static void Book()
        {
            int BookId;
            String Title;
            double Price;
            

            Console.WriteLine("Enter The BookId:");
            BookId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Title :");
            Title = Console.ReadLine();
            Console.WriteLine("Enter The Book Price :");
            Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Book Type :");
            
            Console.WriteLine("1:Magazine");
            Console.WriteLine("2:Novel");
            Console.WriteLine("3:ReferenceBook");
            Console.WriteLine("4:Miscellaneous");

            int type=int.Parse(Console.ReadLine());

            Console.WriteLine("The BookId:" + BookId);
            Console.WriteLine("The Title Of The Book is :" + Title);
            Console.WriteLine("The Price Of The Book is :" + Price);

            switch (type)
            {

                case 1:
                    Console.WriteLine("The Book Type Is :"+BookType.Magazine);
                    break;
                case 2:
                    Console.WriteLine("The Book Type Is :" + BookType.Novel);
                    break;
                case 3:
                    Console.WriteLine("The Book Type Is :" + BookType.ReferenceBook);
                    break;
                case 4:
                    Console.WriteLine("The Book Type Is :" + BookType.Miscellaneous);
                    break;
                default:
                    Console.WriteLine("selecting from 1 to 4 only:");
                    break;

            }
            



            
            //Console.WriteLine("The BookType is :" + Convert.ToString(BookType.Magazine));

            
        }
        public static void Main()
        {
            Book();
            Console.ReadKey();
        }
    }
}
