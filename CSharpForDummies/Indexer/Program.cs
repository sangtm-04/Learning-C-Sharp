using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class KeyedArray
    {
        private string[] _keys;

        // the object is the actual data associated with that key
        private object[] _arrayElements;

        public KeyedArray(int size)
        {
            _keys = new string[size];
            _arrayElements = new object[size];
        }

        private int Find(string targetKey)
        {
            for (int i = 0; i < _keys.Length; i++)
            {
                if (String.Compare(_keys[i], targetKey) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        private int FindEmpty()
        {
            for (int i = 0; i < _keys.Length; i++)
            {
                if (_keys[i] == null)
                {
                    return i;
                }
            }

            throw new Exception("Array is full");
        }

        // look up contents by string key -- this is the indexer
        public object this[string key]
        {
            set
            {
                // see if the string is already there
                int index = Find(key);
                if (index < 0)
                {
                    index = FindEmpty();
                    _keys[index] = key;
                }

                _arrayElements[index] = value;
            }
            get
            {
                int index = Find(key);
                if (index < 0)
                {
                    return null;
                }
                return _arrayElements[index];
            }
        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            // create an array with enough room
            KeyedArray ma = new KeyedArray(100);

            // save the ages of the Simpson kids
            ma["Bart"] = 8;
            ma["Lisa"] = 10;
            ma["Maggie"] = 2;

            // look up the age of Lisa
            Console.WriteLine("Let's find Lisa's age");
            int age = (int)ma["Lisa"];
            Console.WriteLine("Lisa is {0}", age);

            // Wait for user to acknowledge the results
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
