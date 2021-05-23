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
