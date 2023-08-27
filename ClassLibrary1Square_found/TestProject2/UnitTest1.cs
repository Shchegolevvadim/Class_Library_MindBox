using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1Square_found;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Rad()
        {
            // arrange
            double x = 5.22;
            double pi = Math.PI;
            double expected = 85.6033732620761;
            //act
            
            double actual = Library.Rad(x);
            //assert
            Assert.AreEqual(expected, actual);
        }
        public void Test_Square()
        {
            double c = 8.43;
            double d = 9.56;
            double expected = 80.5908;
            
            double actual = Library.Square(c, d);
            Assert.AreEqual(expected, actual);
        }
        public void Test_Triangle()
        {
            double t1 = 8.56;
            double t2 = 9.46;
            double t3 = 15.79;
            double expected = 34.2208303137779;
            double actual = Library.Triangle(t1, t2, t3);
            Assert.AreEqual(expected, actual);
        }

    }
}