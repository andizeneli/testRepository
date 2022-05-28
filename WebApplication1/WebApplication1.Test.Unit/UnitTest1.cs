namespace WebApplication1.Test.Unit_
{
    public class UnitTest1
    {
   
        [Fact]
        public void ShouldReturnTheSum()
        {
            //Arrange
            Math _math = new Math();

            //Act
            int input = _math.sum(1, 2);
            int expected = 3;

            //Assert

            Assert.Equal(expected, input);

        }
    }
}