using System;


namespace OutputFormatControls
{
    class Program
    {
        static void Main(string[] args)
        {
            for(; ; )
            {
                Console.WriteLine("Enter a double number");
                string numberInput = Console.ReadLine();

                if(numberInput.Length == 0)
                {
                    break;
                }

                double number = Double.Parse(numberInput);

                Console.WriteLine("Enter the format specifiers separated by a blank (Example: C E F1 N0 0000000.00000)");
                char[] separator = { ' ' };
                string formatString = Console.ReadLine();
                string[] formats = formatString.Split(separator);

                foreach(string s in formats)
                {
                    if (s.Length != 0)
                    {
                        string formatCommand = "{0:" + s + "}";

                        Console.WriteLine("The format specifier {0} results in ", formatCommand);

                        try
                        {
                            Console.WriteLine(formatCommand, number);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("<illegal control>");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
