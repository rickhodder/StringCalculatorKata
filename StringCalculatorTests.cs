using System;
using Xunit;

namespace StringCalculatorKata
{
    public class StringCalculatorTests
    {
        [Fact]
        public void Add_EmptyStringReturnsZero()
        {
            //create String Calculator with add method that takes an integer

            // Arrange
            var sut = new StringCalculator();

            // Act 

            var value = sut.Add("");

            //Assert
            Assert.Equal(0,value);
        
        }
    }
}
