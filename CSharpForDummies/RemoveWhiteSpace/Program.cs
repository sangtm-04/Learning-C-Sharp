using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveWhiteSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] WhiteSpace = {' ', '\n', '\t' };

            string s = " this is a\nstring";
            Console.WriteLine("before: " + s);

            Console.WriteLine("after: ");

            for(; ; )
            {
                int offset = s.IndexOfAny(WhiteSpace);

                if (offset == -1)
                {
                    break;
                }

                string before = s.Substring(0, offset);
                string after = s.Substring(offset + 1);

                s = String.Concat(before, after);

            }
            Console.WriteLine(s);
            char[] targets = { 's' };
            Console.WriteLine(RemoveSpecialChars(s, targets));
        }

        public static string RemoveSpecialChars(string input, char[] targets)
        {
            string[] subStrings = input.Split(targets);

            string output = "";

            foreach(string subString in subStrings)
            {
                output = String.Concat(output, subString);
            }

            return output;
        }
    }
}
