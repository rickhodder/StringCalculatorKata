using System;
using Xunit;

namespace StringCalculatorKata
{
    public class StringCalculatorTests
    {
        private StringCalculator _sut;

        public StringCalculatorTests()
        {
            _sut=new StringCalculator();
            
        }

        [Theory]
        [InlineData("1,2,3",6)]
        [InlineData("2,3,4",9)]
        public void Add_UnlimitedNumberOfDelimitedNumbers(string numbers, int expectedValue)
        {
            Assert.Equal(expectedValue, _sut.Add(numbers));
        }

        [Theory]
        [InlineData("1,2",3)]
        [InlineData("3,4",7)]
        public void Add_CommaDelimitedNumbersSummedSuccessfully(string numbers, int expectedValue)
        {
            Assert.Equal(expectedValue, _sut.Add(numbers));

        }

        [Theory]
        [InlineData("0",0)]
        [InlineData("1",1)]
        [InlineData("2",2)]
        public void Add_PassSingleIntegerReturnsInteger(string numbers, int expectedValue)
        {
            Assert.Equal(expectedValue, _sut.Add(numbers));
        }

        [Fact]
        public void Add_OneReturnsOne()
        {
            Assert.Equal(1,_sut.Add("1"));
        }

        [Fact]
        public void Add_ZeroReturnsZero()
        {
            Assert.Equal(0,_sut.Add("0"));
        }

        [Fact]
        public void Add_EmptyStringReturnsZero()
        {
            Assert.Equal(0,_sut.Add(""));
        }
    }
}
