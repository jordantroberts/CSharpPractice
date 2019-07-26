using System;

namespace Numbers
{
    class Program
    {
        static void Main()
        {
            // area of a circle is radius squared multipled by PI. 

            double radius = 2.50;

            double area = (radius * radius) * Math.PI;

            Console.WriteLine(area);

        }
    }
}
