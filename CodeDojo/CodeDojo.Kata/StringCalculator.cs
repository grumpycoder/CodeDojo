using System;
using System.Linq;

namespace CodeDojo.Kata
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            var items = numbers.Split(',', '\n');

            if (items.Any(x => string.IsNullOrEmpty(x)))
                throw new ArgumentException();

            var integers = items.Select(x => int.Parse(x));
            var negatives = integers.Where(x => x < 0);
            if (negatives.Any())
            {
                var message = "Negatives not allowed: {0}";
                throw new ArgumentOutOfRangeException(string.Format(message,
                    string.Join(",", negatives.Select(x => x.ToString()).ToArray())));
            }

            return items.Select(int.Parse).Sum();

        }
    }
}