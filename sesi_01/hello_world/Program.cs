using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string fname, lname;
            int age;
            Console.WriteLine("First name: ");
            fname = Console.ReadLine();
            Console.WriteLine("Last name: ");
            lname = Console.ReadLine();
            Console.WriteLine("Age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Hello {fname} {lname}. You are {age} years old.");
        }
    }
}
