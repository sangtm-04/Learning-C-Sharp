using System;
using System.Text;

namespace StringBuilderTest
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder("012");
            builder.Append("34");
            builder.Append("56");
            string result = builder.ToString();
            Console.WriteLine(result);
            Console.WriteLine(builder);
        }
    }
}
