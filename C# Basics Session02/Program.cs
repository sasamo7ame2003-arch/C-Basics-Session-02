namespace C__Basics_Session02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q01.Create a Book class with a Title(string) and Pages(int). Create a Book object and store it in avariable of type object. Print it.
            // Book object1 = new Book() { Title = "c#", Pages = 250 };
            // Console.WriteLine(object1);



            //Q02. Using the Book class above, print the result of calling ToString(), Equals() (compare book with
             Book object1 = new Book() { Title = "c#", Pages = 250 };
             Book object2 = new Book() { Title = "c#", Pages = 250 };


             Console.WriteLine(object1);
             Console.WriteLine(object1 .Equals(object2));
             Console.WriteLine(object1.GetHashCode());
             Console.WriteLine(object1.GetType());

        }



    }
}
