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


            #region question1
            // Q01.Create a Book class with a Title(string) and Pages(int). Create a Book object and store it in avariable of type object. Print it.
            // Book object1 = new Book() { Title = "c#", Pages = 250 };
            // Console.WriteLine(object1);

            #endregion

            #region question2
            //Q02. Using the Book class above, print the result of calling ToString(), Equals() (compare book with
            // Book object1 = new Book() { Title = "c#", Pages = 250 };
            // Book object2 = new Book() { Title = "c#", Pages = 250 };


            // Console.WriteLine(object1);
            // Console.WriteLine(object1.Equals(object2));
            // Console.WriteLine(object1.GetHashCode());
            // Console.WriteLine(object1.GetType());

            #endregion


            #region question3
            //Q03. Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.

            //compile - time error


            // int pages = Convert.ToInt32("464");

            // Console.WriteLine(pages);

            #endregion



            #region question4
            // Q04. Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide byzero", and then prints "Done" in a finally block.




            //int Book = 10;
            //int Book1 = 0;

            //try
            //{
            //    int Average = Book / Book1;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("you cannot Divide By zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}

            #endregion


            #region question5

            //Q05. Declare an int pages = 300; then store it in a double variable without using a cast.


            int Pages = 300;
            double Pages1 = Pages;
            Console.WriteLine(Pages1);


            #endregion









        }



    }
}