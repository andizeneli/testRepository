using System;
using WebAPITests;
using Xunit;

namespace WebApi.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldReturnTHeSum()
        {
            //Arrange
            MathClass math = new MathClass();

            //Act

            int input = math.sum(1, 2);
            int expected = 3;
            //Assert
            Assert.Equal(input, expected);

        }
    }
}
