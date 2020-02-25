using System;

namespace firstprog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your first name?");
            string firstname = Console.ReadLine();

            Console.WriteLine("What's your surname?");
            string surname = Console.ReadLine();

            string fullname = firstname + " " + surname; 

            Console.WriteLine(fullname);
        }
    }
}
