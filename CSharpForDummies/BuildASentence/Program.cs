using System;


namespace BuildASentence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Each line you enter will be "
                + "added to a sentence until you "
                + "enter EXIT or QUIT");

            string sentence = "";
            for (; ; )
            {
                Console.WriteLine("Enter a string ");
                string line = Console.ReadLine();
                                                
                bool quitting = false;
                
                if ((String.Compare("exit", line, true) == 0) ||
                    (String.Compare("quit", line, true) == 0))
                {
                    quitting = true;
                }
                
                if (quitting == true)
                {
                    break;
                }

                sentence = String.Concat(sentence, line);

                Console.WriteLine("\nyou've entered: " + sentence);
            }

            Console.WriteLine("\ntotal sentence:\n" + sentence);

            // Wait for user to acknowledge the results
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
