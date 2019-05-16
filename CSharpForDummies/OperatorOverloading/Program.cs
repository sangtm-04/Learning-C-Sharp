using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            AddOne foo = new AddOne();
            foo.x = 2;

            AddOne bar = new AddOne();
            bar.x = 3;

            Console.WriteLine((foo + bar).x.ToString());
        }
    }

    public class AddOne
    {
        public int x;

        public static AddOne operator + (AddOne a, AddOne b)
        {
            AddOne addOne = new AddOne();
            addOne.x = a.x + b.x + 1;
            return addOne;
        }
    }
}
