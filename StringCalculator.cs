using System;
using System.Linq;
using System.Collections.Generic;
namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if(string.IsNullOrEmpty(numbers)) return 0;

            var delimiters = new List<char> {',','\n'};

            var values = numbers.Split(delimiters.ToArray(),StringSplitOptions.RemoveEmptyEntries);

            return values.Sum(v=> Int32.Parse(v));
        }
    }
}