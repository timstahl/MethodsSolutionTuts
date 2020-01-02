using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            SayAuthor();

            string firstName = GetUsersName("What is your first name: ");
            string lastName = GetUsersName("What is your last name: ");
           
            WelcomeUser(firstName, lastName);

            Console.ReadLine();
        }

        private static void SayAuthor()
        {
            Console.WriteLine("**************");
            Console.WriteLine("Written by: Tim Stahl");
            Console.WriteLine("**************");
        }

        private static void WelcomeUser(string firstName, string lastName)
        {
            Console.WriteLine($"Hello { firstName } { lastName }");
        }

        private static string GetUsersName(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();

            return output;
        }

    }
}
