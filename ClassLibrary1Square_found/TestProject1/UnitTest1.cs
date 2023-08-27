using ClassLibrary1Square_found;
using Microsoft.VisualStudio;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Radius()
        {
            // arrange
            double x = 5.22;
            double pi = Math.PI;
            double expected = 85.6033732620761;
            // act
            Library l = new Library();
            double actual = (x*pi);
            // assert


            Assert.AreEqual(expected, actual);
        }
    }
}