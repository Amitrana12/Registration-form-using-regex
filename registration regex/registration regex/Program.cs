using System;

namespace registration_regex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====Welcome to my registration form regex apllication by Amit Rana====");
            RegexValidation regexValidation = new RegexValidation();
            Console.WriteLine("Enter Your First Name::-");
            string FirstName = Console.ReadLine();
            Console.WriteLine(regexValidation.ValidateFirstName(FirstName));
            Console.WriteLine("Enter Your Last Name::-");
            string LastName = Console.ReadLine();
            Console.WriteLine(regexValidation.ValidateLastName(LastName));
            Console.WriteLine("Enter Your Email Address::-");
            string Email = Console.ReadLine();
            Console.WriteLine(regexValidation.ValidateEmail(Email));
            Console.WriteLine("Enter Your Mobile Number::-");
            string MobileNumber = Console.ReadLine();
            Console.WriteLine(regexValidation.ValidateMobile(MobileNumber));
        }
    }
}
