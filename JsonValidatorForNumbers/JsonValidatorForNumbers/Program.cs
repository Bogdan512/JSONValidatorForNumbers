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
