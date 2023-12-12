namespace Calculator.ConsoleApp.Tests
{
    public class MathematicsTest
    {
        [Fact]
        public void Add_Two_Number_Returns_Sum_Of_Them()
        {
            // AAA
            // Arrange -> Qanday ma'lumotlar kirib kelishi
            int a = 10;
            int b = 20;
            int expectedResult = 30;

            // ACT
            int result = Mathematics.Add(a, b);

            // Assert -> Tekshirish qismi 

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Dividege_Two_Numbers_When_Second_Zero_Throws_Argument_Exception()
        {
            // Arrange
            int a = 10;
            int b = 0;

            // ACT
            Action act = () => Mathematics.Dividge(a, b);

            // Assert
            Assert.Throws<ArgumentException>(act);
        }

        [Fact]
        public void Dividge_Two_Numbers_Returns_Division_Of_Numbers()
        {
            // Arrange
            int a = 20;
            int b = 10;
            int expectedResult = 2;

            // ACT
            int result = Mathematics.Dividge(a, b);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Subtract_Two_Numbers_Returns_Subtraction_Of_Numbers()
        {
            // Arrange
            int a = 10;
            int b = 5;
            int expectedResult = 5;

            // Act
            int result = Mathematics.Subtract(a, b);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Multiply_Two_Numbers_Returns_Multiplication_Of_Numbers()
        {
            // Arrange
            int a = 10;
            int b = 10;
            int expectedResult = 100;

            // Act 
            int result = Mathematics.Multiply(a, b);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}