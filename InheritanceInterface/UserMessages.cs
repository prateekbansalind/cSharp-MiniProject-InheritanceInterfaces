using System;

namespace InheritanceInterface
{
    public class UserMessages
    {

        public static string GetAString(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();

            return output;
        }

        public static int GetAInteger(string message)
        {
            Console.Write(message);
            string outputText = Console.ReadLine();

            int output;

            bool isValidFormat = int.TryParse(outputText, out output);

            while (!isValidFormat)
            {
                Console.WriteLine("The input is not integer. Please enter a correct data");
                Console.Write(message);
                outputText = Console.ReadLine();

                isValidFormat = int.TryParse(outputText, out output);
            }

            return output;
        }
    }
}
