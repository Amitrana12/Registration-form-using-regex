using System;

namespace registration_regex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my registration form regex apllication by Amit Rana");
            RegexValidation regexValidation = new RegexValidation();
            Console.Write("Enter Your First Name::-");
            string FirstName = Console.ReadLine();
            Console.WriteLine(regexValidation.ValidateFirstName(FirstName));
        }
    }
}
