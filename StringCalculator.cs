using System;
namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if(string.IsNullOrEmpty(numbers)) return 0;

            var values = numbers.Split(',');
            if (values.Length>1)
            {
                return Int32.Parse(values[0]) +  Int32.Parse(values[1]);
            }

            return Int32.Parse(numbers);
        }
    }
}