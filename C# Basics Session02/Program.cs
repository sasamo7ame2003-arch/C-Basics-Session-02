namespace C__Basics_Session02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q01.Create a Book class with a Title(string) and Pages(int). Create a Book object and store it in avariable of type object. Print it.
            Book object1 = new Book() { Title = "c#", Pages = 250 };
            Console.WriteLine(object1);
        }
    }
}
