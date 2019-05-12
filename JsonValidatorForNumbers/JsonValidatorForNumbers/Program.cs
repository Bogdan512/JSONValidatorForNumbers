using System;

namespace JsonValidatorForNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool result = ValidateJSONNumber(input);
            if (result)
            {
                Console.WriteLine("Valid");
            }
            else Console.WriteLine("Invalid");
            Console.Read();
        }

        public static bool ValidateJSONNumber(string input)
        {
            bool result = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '.' && i == input.Length - 1)
                {
                    return false;
                }
            }
            if (input[0] == '0')
            {
                if (input[1] != '.')
                {
                    return false;
                }
            }
            if (double.TryParse(input, out double number))
            {
                result = true;
            }
            else result = false;
            return result;
        }
    }
}
