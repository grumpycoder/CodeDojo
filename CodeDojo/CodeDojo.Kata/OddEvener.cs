using System.Text;

namespace CodeDojo.Kata
{
    public class OddEvener
    {

        public string Print(int input)
        {
            var sb = new StringBuilder();
            for (int i = 1; i <= input; i++)
            {
                sb.AppendFormat("{0} ", GetTextForNumber(i));
            }
            return sb.ToString();
        }

        public  bool IsDivisibleByTwo(int input)
        {
            return input %2 == 0;
        }

        public bool IsPrimeNumber(int input)
        {
            if (input > 0 && input <= 3)
            {
                return true;
            }
            if (input%2 == 0)
                return false;

            for (int i = 3; i < input; i++)
            {
                if (input%i == 0)
                    return false;
            }

            return true;


        }

        public string GetTextForNumber(int input)
        {
            if (IsPrimeNumber(input))
                return input.ToString();

            if (IsDivisibleByTwo(input))
                return "Even";

            return "Odd";
        }
    }
}