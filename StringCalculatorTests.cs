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
        [InlineData("1,1001",1)]
        [InlineData("2,1000",1002)]

        public void Add_ValuesOver1000NotIncludedInSum(string numbers,int expectedValue)
        {
            Assert.Equal(expectedValue, _sut.Add(numbers));
        }

        [Fact]
        public void Add_NegativeCausesException()
        {
            var numbers = "-1,2";
             var ex = Assert.Throws<InvalidOperationException>(() => _sut.Add(numbers));
            Assert.Equal("Negatives not allowed: -1", ex.Message);

            numbers = "-4,-5";
            ex = Assert.Throws<InvalidOperationException>(() => _sut.Add(numbers));
            Assert.Equal("Negatives not allowed: -4,-5", ex.Message);

        }
        
        [Fact]
        public void Add_SpecifyDelimiterActsAsDelimiter()
        {
            Assert.Equal(3,_sut.Add("//;\n1;2"));
        }

        [Theory]
        [InlineData("1\n2,3",6)]
        [InlineData("2,3\n4",9)]
        [InlineData("1,\n",1)]
        public void Add_NewLineDelimiterSummedSuccessfully(string numbers, int expectedValue)
        {
            Assert.Equal(expectedValue,_sut.Add(numbers));
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
