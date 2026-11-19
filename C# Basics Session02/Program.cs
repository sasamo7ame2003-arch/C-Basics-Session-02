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
            Book object1 = new Book() { Title = "c#", Pages = 250 };
            Book object2 = new Book() { Title = "c#", Pages = 250 };


            Console.WriteLine(object1);
            Console.WriteLine(object1.Equals(object2));
            Console.WriteLine(object1.GetHashCode());
            Console.WriteLine(object1.GetType());

            #endregion













        }



    }
}