using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using fizz_buzz;

namespace fizz_buzz_test
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void FiveReturnsBuzz()
        {
            // Arrange
            var instance = new FizzBuzz();
            const int input = 5;
            const string expected = "buzz";

            // Act
            // ...

            // Assert
            // ...

            throw new NotImplementedException("There should be something here...");
        }

        [TestMethod]
        public void ThreeReturnsFizz()
        {
            // Arrange
            var instance = new FizzBuzz();
            const int input = 3;
            const string expected = "fizz";

            // Act
            // ...

            // Assert
            // ...

            throw new NotImplementedException("There should be something here...");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ZeroThrowsException()
        {
            throw new NotImplementedException("There should be something here...");
        }
    }
}
