using System;
namespace GettersSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "Dog");
            Movie shrek = new Movie("Shrek", "Adam adamson", "PG");

            Console.WriteLine(avengers.Rating);
            Console.ReadLine();
      

        }
    }
}
