using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Created a new chef object and told it to make chicken: 
            Chef chef = new Chef();
            chef.MakeChicken();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChicken();

            Console.ReadLine();
        }
    }
}

// Output:

    //The Chef makes chicken
    //The Chef makes chicken 