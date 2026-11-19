using System.Drawing;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Basics_Session02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q01.Create a Book class with a Title(string) and Pages(int). Create a Book object and store it in avariable of type object. Print it.
            // Book object1 = new Book() { Title = "c#", Pages = 250 };
            // Console.WriteLine(object1);



            /*Q02. Using the Book class above, print the result of calling ToString(), Equals() (compare book with
             Book object1 = new Book() { Title = "c#", Pages = 250 };
             Book object2 = new Book() { Title = "c#", Pages = 250 };


             Console.WriteLine(object1);
             Console.WriteLine(object1 .Equals(object2));
             Console.WriteLine(object1.GetHashCode());
             Console.WriteLine(object1.GetType());
            */

            /* Q03. Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.

            compile - time error


            int pages = Convert.ToInt32("464");

            Console.WriteLine(pages);
            */

            /* Q04. Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide byzero", and then prints "Done" in a finally block.



            int Book = 10;
            int Book1 = 0;

            try
            {
                int Average = Book / Book1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("you cannot Divide By zero");
            }
            finally
            {
                Console.WriteLine("Done");


            }*/

            /*Q05. Declare an int pages = 300; then store it in a double variable without using a cast.


            int Pages = 300;
            double Pages1 = Pages;
            Console.WriteLine(Pages1);
            */

            /* Q06. Declare a double price = 49.99; then convert it into an int using a cast.


            double Price = 49.99;
            int Price1 = (int)Price;
            Console.WriteLine(Price1);
            */

            /* Q07. Given string pagesText = "464";, convert it into an int using the Convert class.

            string PagesText = "464";

            int PageCount = Convert.ToInt32(PagesText);

            Console.WriteLine(PageCount);
            */
            //Q08. Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";,
            //use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.


            //string YearText = "2023";
            //int Yaer  = int .Parse(YearText);

            //Console.WriteLine(YearText);


            // string BadText = "abc";

            /*   if (int.TryParse( BadText, out int Bad))
               { 
                    Console.WriteLine(Bad);
               }
               else
               {
                     Console.WriteLine("Invalid number");

               }
            */
            //Q09. Given int pages = 464;, convert it into a string using ToString() and print its type using GetType()
            // to prove it's now a string.

            /* int Pages = 464;
             string Pages2 = Pages.ToString();
             Console.WriteLine(Pages2);
             Console.WriteLine(Pages2.GetType());
            */

            // Q10. Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int
            // variable, and print both
            /*int Copies = 100;
            object Co2 = Copies;
            int Co3 = (int)Co2;
            Console.WriteLine(Co3);
            */







        }



    }
}
