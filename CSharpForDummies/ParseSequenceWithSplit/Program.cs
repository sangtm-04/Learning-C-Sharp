using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseSequenceWithSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a series of numbers separated by commas: ");

            string input = Console.ReadLine();
            Console.WriteLine();

            char[] dividers = { ',', ' ' };
            string[] segments = input.Split(dividers);

            int sum = 0;
            foreach(string s in segments)
            {
                Console.WriteLine("s = " + s);
                if (s.Length > 0)
                {
                    if (IsAllDigits(s))
                    {
                        int num = 0;
                        if (Int32.TryParse(s, out num))
                        {
                            Console.WriteLine("Next number = {0}", num);
                            sum += num;
                        }
                    }
                }
            }

            Console.WriteLine("Sum = {0}", sum);

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
