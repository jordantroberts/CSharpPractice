using System;

namespace Composition
{
	public interface ICanBark
	{
		void Bark();
	}

	public interface ICanMove
	{
		string Move();
	}

	public interface ICanClean
	{
		string Clean();
	}

	class Program
	{


		static void Main(string[] args)
		{
			SuperBot steven = new SuperBot();
			steven.Bark();
            Dog bailey = new Dog();
            bailey.Bark();

		}
	}

	class Dog : ICanBark
	{
		public void Bark()
		{
			Console.WriteLine("Woof");
		}
	}

	class Robot : ICanMove
	{
		public string Move()
		{
			return "I'm moving";
		}
	}

	class CleanRobot : ICanClean
	{
		public string Clean()
		{
			return "Just keep dusting, just keep dusting";
		}
	}

	class SuperBot : ICanBark, ICanMove, ICanClean
	{
		public void Bark()
		{
			Console.WriteLine("E-woof");
		}

        public string Move()
        {
            return "I'm moving so speedily as I'm a super bot";
        }

        public string Clean()
        {
            return "I'm cleaning twice as fast"; 
        }
	}

}