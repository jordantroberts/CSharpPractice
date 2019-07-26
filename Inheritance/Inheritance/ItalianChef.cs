using System;
namespace Inheritance
{
     class ItalianChef : Chef
        {
          // add override as it's overriding method of superclass
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes chicken parm");
        }
      

        public void MakePasta()
        {
            Console.Write("The Chef makes pasta");
        }
    }
}
