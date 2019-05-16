using System;

namespace OtherStuffWithString
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteFood = "cheeseburgers";
            foreach(char c in favoriteFood)
            {
                Console.WriteLine(c);
            }

            bool isUppercase = true;
            foreach(char c in favoriteFood)
            {
                if (!char.IsUpper(c))
                {
                    isUppercase = false;
                    break;
                }
            }

            if (isUppercase) Console.WriteLine("This string is upper case\n");
            else Console.WriteLine("This string is not upper case");

            int indexOfLetterS = favoriteFood.IndexOf('s');

            Console.WriteLine(indexOfLetterS + "\n");

            char[] charsToLookFor = {'a', 'b', 'c' };
            int indexOfFirstFound = favoriteFood.IndexOfAny(charsToLookFor);

            Console.WriteLine(indexOfFirstFound + "\n");

            int index = favoriteFood.IndexOfAny(new char[] { 'a', 'b', 'c' });

            Console.WriteLine(index + "\n");

            if (favoriteFood.Contains("ee"))
                Console.WriteLine("Have ee");

            string sub = favoriteFood.Substring(6, favoriteFood.Length - 6);
            Console.WriteLine(sub + "\n");
                      
            Console.WriteLine("Enter an integer number");
            string str = Console.ReadLine();

            if (!IsAllDigits(str))
            {
                Console.WriteLine("Hey! That isn't a number");
            }
            else
            {
                int num = Int32.Parse(str);

                Console.WriteLine("2 * " + num + " = " + (2 * num));
            }

            // Wait for user to acknowledge the results
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }

        public static bool IsAllDigits(string raw)
        {
            string s = raw.Trim();
            if (s.Length == 0) return false;

            for (int index = 0; index < s.Length; index++)
            {
                if (Char.IsDigit(s[index]) == false) return false;
            }
                        
            return true;
        }
    }
}
