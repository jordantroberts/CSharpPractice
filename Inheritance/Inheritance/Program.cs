using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Created a new chef object and told it to make chicken: 
            Chef chef = new Chef();
            chef.MakeSpecialDish();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeSpecialDish();

            Console.ReadLine();
        }
    }
}

// Output:

//The Chef makes bbq ribs
//The Chef makes chicken parm



