using System;
using System.Collections.Generic;

namespace AlignOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Christa ", " Sarah", "Jonathan", "Sam", " Schmekowitz" };

            Console.WriteLine("The following names are of different lengths");

            foreach(string s in names)
            {
                Console.WriteLine("This is the name '" + s + "' before");
            }
            Console.WriteLine();

            List<string> stringsToAlign = new List<string>();

            for (int i = 0; i < names.Count; i++)
            {
                string trimmedName = names[i].Trim();
                stringsToAlign.Add(trimmedName);
            }

            int maxLength = 0;
            foreach(string s in stringsToAlign)
            {
                if (s.Length > maxLength)
                {
                    maxLength = s.Length;
                }
            }

            for (int i = 0; i < stringsToAlign.Count; i++)
            {
                stringsToAlign[i] = stringsToAlign[i].PadRight(maxLength + 1);
            }

            Console.WriteLine("The following are the same names normalized to the same length");

            foreach(string s in stringsToAlign)
            {
                Console.WriteLine("This is the name '" + s + "' afterwards");
            }


        }
    }
}
