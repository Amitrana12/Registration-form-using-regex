using System;
using System.Collections.Generic;
using System.Text;

namespace registration_regex
{
    class UserDetailsExeption : Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRSTNAME,
            INVALID_LASTNAME,
            INVALID_EMAIL,
            INVALID_PASSWORD,
            INVALID_MOBILE
        }
        private ExceptionType type;
        public UserDetailsExeption(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
