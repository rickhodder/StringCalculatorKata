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

            if(numbers.StartsWith("//"))
            {
                delimiters.Add(numbers[2]);
                numbers=numbers.Substring(3); // strip definer from begining of string
            }

            var values = numbers.Split(delimiters.ToArray(),StringSplitOptions.RemoveEmptyEntries);

            if(values.Any(v=>Int32.Parse(v)<0))
            {
                var message = "Negatives not allowed: ";
                bool first = true;
                foreach (var value in values.Where(v=>Int32.Parse(v)<0))
                {
                    if(!first) message+=",";

                    message+=value;

                    first=false;
                }
                
                throw new InvalidOperationException(message);
            }

            return values.Sum(v=> Int32.Parse(v));
        }
    }
}