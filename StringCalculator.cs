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

            var values = numbers.Split(',');

            return values.Sum(v=> Int32.Parse(v));
        }
    }
}