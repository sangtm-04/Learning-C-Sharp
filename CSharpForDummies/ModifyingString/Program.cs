using System;


namespace ModifyingString
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "Jenny";

            Student s2 = new Student();
            s2.Name = s1.Name;

            s2.Name = s1.Name.ToUpper();
            Console.WriteLine("s1 - " + s1.Name + ", s2 - " + s2.Name);

            Console.WriteLine("Press Enter to terminate...");
            Console.ReadLine();
        }
    }

    class Student
    {
        public String Name;
    }
}
