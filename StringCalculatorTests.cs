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
        [InlineData("0",0)]
        [InlineData("1",1)]
        [InlineData("2",2)]
        public void Add_PassSingleIntegerReturnsInteger(string passedValue, int expectedValue)
        {
            Assert.Equal(expectedValue, _sut.Add(passedValue));
        }

        [Fact]
        public void Add_OneReturnsOne()
        {
            var value= _sut.Add("1");
            Assert.Equal(1,value);
        }

        [Fact]
        public void Add_ZeroReturnsZero()
        {
            var value = _sut.Add("0");
            Assert.Equal(0,value);
        }

        [Fact]
        public void Add_EmptyStringReturnsZero()
        {
            var value = _sut.Add("");

            Assert.Equal(0,value);
        
        }
    }
}
