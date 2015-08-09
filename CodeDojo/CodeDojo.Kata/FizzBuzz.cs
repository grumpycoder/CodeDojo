using System.Text;

namespace CodeDojo.Kata
{
    public class FizzBuzz
    {
    
        public static bool IsDivisibleByThree(int input)
        {
            return input%3 == 0;
        }

        public static bool IsDivisibleByFive(int input)
        {
            return input%5 == 0;
        }

        public string GetTextForNumber(int input)
        {
            if (IsDivisibleByThree(input) && IsDivisibleByFive(input))
                return "FizzBuzz";

            if (IsDivisibleByThree(input))
                return "Fizz";

            if (IsDivisibleByFive(input))
                return "Buzz";

            return input.ToString();
        }

        public string Print(int input)
        {
            var sb = new StringBuilder();
            for (int i = 1; i <= input; i++)
            {
                sb.AppendFormat("{0} ", GetTextForNumber(i));
            }
            return sb.ToString();
        }
    }
}