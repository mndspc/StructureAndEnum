using System;


namespace StructureAndEnumDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Book myBook = new Book(100, "C#4.0", "Donis");
            Console.WriteLine(myBook.Display());
            Console.ReadLine();
        }
    }
}
