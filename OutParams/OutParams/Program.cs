using System;

namespace OutParameters
{
	class Program
	{
        static void Main(string[] args)
        {
            string ageAsString = "102";
            string nameAsString = "Granny";
            int ageAsInt;
            bool outcome;

            // For example the Int32.TryParse() method tries to parse its input as an integer.
            // If it can, it returns true and sets a specific variable to the new value.
            outcome = Int32.TryParse(ageAsString, out ageAsInt);

            Console.WriteLine(outcome);
            Console.WriteLine(ageAsInt);

            int nameAsInt;
            bool outcome2;

            outcome2 = Int32.TryParse(nameAsString, out nameAsInt);

            Console.WriteLine(outcome2);
            Console.WriteLine(nameAsInt);


        }
    }
}

// Output:

//True
//102
//False
//0
