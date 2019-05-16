using System;
using System.IO;

namespace LoopThroughFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryName;
            if (args.Length == 0)
            {
                // get the name of the current directory
                directoryName = Directory.GetCurrentDirectory();
            }
            else
            {
                directoryName = args[0];
            }
            Console.WriteLine(directoryName);

            // get a list of all files in that directory
            FileInfo[] files = GetFileList(directoryName);

            foreach(FileInfo file in files)
            {
                // write the name of the file
                Console.WriteLine("\n\nhex dump of file {0}: ", file.FullName);

                // now "dump" the file to the console
                DumpHex(file);

                Console.WriteLine("\nEnter return to continue to next file");
                Console.ReadLine();
            }

            Console.WriteLine("\no files left");
        }

        public static FileInfo[] GetFileList(string directoryName)
        {
            FileInfo[] files = new FileInfo[0];
            try
            {
                DirectoryInfo di = new DirectoryInfo(directoryName);

                // that information object has a list of the contents
                files = di.GetFiles();
            }
            catch (Exception e)
            {
                Console.WriteLine("Directory \"{0}\" invalid", directoryName);
                Console.WriteLine(e.Message);
            }
            return files;
        }

        public static void DumpHex(FileInfo file)
        {
            // open the file
            FileStream fs;
            BinaryReader reader;
            try
            {
                fs = file.OpenRead();
                // wrap the file stream in a BinaryReader
                reader = new BinaryReader(fs);
            }
            catch (Exception e)
            {
                Console.WriteLine("\ncan't read from \"{0}\"", file.FullName);
                Console.WriteLine(e.Message);
                return;
            }

            //iterate through the contents of the file one line at a time
            for (int line = 1; true; line++)
            {
                // read another 10 bytes across (all that will fit on a single
                // line) -- return when no data remains
                byte[] buffer = new byte[10];
                //use the BinaryReader to read bytes
                // Note: Using FileStream is just as easy in this case
                int numBytes = reader.Read(buffer, 0, buffer.Length);
                if (numBytes == 0)
                {
                    return;
                }

                // write the data in a single line preceded by line number
                Console.WriteLine("{0:D3} - ", line);
                DumpBuffer(buffer, numBytes);

                // stop every 20 lines so that the data doesn't scroll
                // of the top of the Console screen
                if ((line % 20) == 0)
                {
                    Console.WriteLine("Enter return to continue another 20 lines");
                    Console.ReadLine();
                }
            }
        }

        public static void DumpBuffer(byte[] buffer, int numBytes)
        {
            for (int index = 0; index < numBytes; index++)
            {
                byte b = buffer[index];
                Console.WriteLine("{0:X2}, ", b);
            }
            Console.WriteLine();
        }
    }
}
