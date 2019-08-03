using System;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperBot steven = new SuperBot(new Dog(), new Robot(), new CleanRobot());
            steven.Bark();
        }
    }

    class Dog
    {
        public void Bark()
        {
            Console.WriteLine("Woof");
        }

        public void Eat()
        {
            // Eat method 
        }

    }

    class Robot
    {
        public void Move()
        {
            Console.WriteLine("I'm moving!");
        }
    }

    class CleanRobot
    {
        public void Clean()
        {
            Console.WriteLine("Just keep dusting, just keep dusting");
        }
    }

    class SuperBot
    {
        // can clean, move and bark but does not eat like a dog does 
        public Dog o1;
        public Robot o2;
        public CleanRobot o3;

        public SuperBot(Dog dog, Robot robot, CleanRobot cleanrobot)
        {
            this.o1 = dog;
            this.o2 = robot;
            this.o3 = cleanrobot;

        }

        // Implement the exposed methods in the composing class as well:

        public void Bark() => o1.Bark();
        public void Move() => o2.Move();
        public void Clean() => o3.Clean();

    }

}

// If I add more methods to Dog, Robot or CleanRobot, they will not impact what the SuperBot offers, i.e. if Dog has a method Eat(), SuperBot will not have this method unless you add it as well.

// Conceptually you use composition like this, if you model a SuperBot as actually consisting of a Dog, a Robot and a CleanRobot.
// The SuperBot then uses its Dog to bark and its CleanRobot to clean.