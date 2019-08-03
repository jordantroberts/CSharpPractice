using HelloWorld;
using NUnit.Framework;

namespace HelloWorldTests
{
    public class HelloWorldTests
    {
      
        [Test]
        public void SaysHelloWorld()
        {
            Greeting greeting = new Greeting();
            string actual = greeting.HelloWorld();
            string expected = "Hello World";
            Assert.AreEqual(expected, actual);
        }
    }
}