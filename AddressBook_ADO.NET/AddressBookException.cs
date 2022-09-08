using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_ADO.NET
{
    public class AddressException : Exception
    {
        ExceptionType exceptionType;
        public enum ExceptionType
        {
            CONNECTION_FAILED,
            CONTACT_NOT_FOUND,
            INSERTION_ERROR,
        }
        public AddressException(ExceptionType exceptionType, string message) : base(message)
        {
            this.exceptionType = exceptionType;
        }
    }
}