using System;
using System.Collections.Generic;
using System.Text;

namespace Day21User_RegistrationException
{
    public class MyException : Exception
    {
        public MyException(string Message) : base(Message)
        {

        }
        public MyException()
        {

        }
        
    }
}
