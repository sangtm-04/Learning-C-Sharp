using System;

namespace BubbleSortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The 5 planets closest to the sun, in order: ");
            string[] planets = new string[] { "Mercury", "Venus", "Earth", "Mars", "Jupiter"};

            foreach(string planet in planets)
            {
                Console.WriteLine("\t" + planet);
            }

            Console.WriteLine("\nNow listed alphabetically: ");
            string[] sortedNames = planets;
            Array.Sort(sortedNames);

            foreach(string planet in planets)
            {
                Console.WriteLine("\t" + planet);
            }

            Console.WriteLine("\nList by name length - shortest first: ");

            //Bubble sort
            int outer; //index of the outer loop
            int inner; //index of the inner loop

            //loop DOWN from last index to first: planets[4] to planets[0]
            for (outer = planets.Length - 1; outer >= 0; outer--)
            {
                //on each outer loop, loop through all elements BEYOND the
                //current outer element. This loop goes up, from planets[1]
                //to planets[4]. Using the for loop, you can traverse the
                //array in either direction
                for (inner = 1; inner <= outer; inner++)
                {
                    //compare adjacent elements. if the earlier one is longer
                    //than the later one, swap them. This shows how you can
                    //swap one array element with another when they're out of
                    //order
                    if (planets[inner - 1].Length > planets[inner].Length)
                    {
                        //temporarily store one planet
                        string temp = planets[inner - 1];

                        //now overwrite that planet with the other one
                        planets[inner - 1] = planets[inner];

                        //finally, reclaim the planet store in temp and put
                        //it in place of the other
                        planets[inner] = temp;
                    }
                }                                               
            }
            foreach (string planet in planets)
            {
                Console.WriteLine("\t" + planet);
            }

            Console.WriteLine("\nNow listed longest first: ");

            //that is, just loop down through the sorted planets
            for (int i = planets.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("\t" + planets[i]);
            }
        }
    }
}
