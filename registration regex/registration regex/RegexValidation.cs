using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace registration_regex
{
    public class RegexValidation
    {
        public const string Regex_FirstName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string Regex_LastName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string Regex_Email = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        public const string Regex_MobileNumber = "^[1-9]{1}[0-9]{0,3}\\s[1-9]{1}[0-9]{9}$";        
        public const string Regex_Password = "^(?=.*[A-Z])(?=.*\\d)(?=[\\w]*[\\W][\\w]*$)[\\S]{8,}$";
        public bool ValidateFirstName(string FirstName)
        {
            try
            {
                if (Regex.IsMatch(FirstName, Regex_FirstName))
                    return true;
                else
                    throw new UserDetailsExeption(UserDetailsExeption.ExceptionType.INVALID_FIRSTNAME, "Sorry Invalid First Name");
            }
            catch(UserDetailsExeption ex)
            {
                Console.WriteLine(ex.Message);
                return false;
                
            }
            
        }
        public bool ValidateLastName(string LastName)
        {
            try
            {
                if (Regex.IsMatch(LastName, Regex_LastName))
                    return true;
                else
                    throw new UserDetailsExeption(UserDetailsExeption.ExceptionType.INVALID_LASTNAME, "Sorry Invalid Last Name");
            }
            catch (UserDetailsExeption ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool ValidateEmail(string Email)
        {
            try
            {
                if (Regex.IsMatch(Email, Regex_Email))
                    return true;
                else
                    throw new UserDetailsExeption(UserDetailsExeption.ExceptionType.INVALID_EMAIL, "Sorry Invalid Email");
            }
            catch (UserDetailsExeption ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool ValidateMobile(string MobileNumber)
        {
            try
            {
                if (Regex.IsMatch(MobileNumber, Regex_MobileNumber))
                    return true;
                else
                    throw new UserDetailsExeption(UserDetailsExeption.ExceptionType.INVALID_MOBILE, "Sorry Invalid Mobile Number");
            }
            catch (UserDetailsExeption ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
        }
        public bool ValidatePassword(string Password)
        {
            try
            {
                if (Regex.IsMatch(Password, Regex_Password))
                    return true;
                else
                    throw new UserDetailsExeption(UserDetailsExeption.ExceptionType.INVALID_PASSWORD, "Soory Invalid Password");
            }
            catch (UserDetailsExeption ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
