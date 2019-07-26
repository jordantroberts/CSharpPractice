using System;
namespace Inheritance
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad");
        }

        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes bbq ribs");
        }
    }
}

// At the moment both chefs make the same special dish. If we want ItalianChef to make a different special dish, we need to override the inherited "MakeSpecialDish" method.
// First to do this you need to add virtual so now is "public virtual void". Virtual means this method can be overriden in any subclass.
