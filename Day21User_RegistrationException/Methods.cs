using System;
using System.Collections.Generic;
using System.Text;

namespace Day21User_RegistrationException
{
    public class Methods
    {
        static Patterns patterns = new Patterns();
        public string FirstNameInput()
        {
            try
            {
                //Entering invalid data so as to get exceptions.
                bool status = patterns.validateName("123ejas");
                if (status == false)
                {
                    throw new MyException("Please enter valid First Name");
                }
            }
            catch(MyException e)
            {
                return e.Message;
            }
            return null;
        }

        public string LastNameInput()
        {
            try
            {
                bool status = patterns.validateName("25Sonar");
                if (status == false)
                {
                    throw new MyException("Please enter valid Last Name");
                }
            }
            catch (MyException e)
            {
                return e.Message;
            }
            return null;
        }

        public string EmailInput()
        {
            try
            {
                bool status = patterns.validateEmail("ssfsdfsd.546$541");
                if (status == false)
                {
                    throw new MyException("Please enter valid Email Address");
                }
            }
            catch (MyException e)
            {
                return e.Message;
            }
            return null;
        }

        public string MobileInput()
        {
            try
            {
                bool status = patterns.validateMobileNum("186748s");
                if (status == false)
                {
                    throw new MyException("Please enter valid Mobile Number");
                }
            }
            catch (MyException e)
            {
                return e.Message;
            }
            return null;
        }

        public string PasswordInput()
        {
            try
            {
                bool status = patterns.validatePassword("123ejaskk!");
                if (status == false)
                {
                    throw new MyException("Please enter valid Password");
                }
            }
            catch (MyException e)
            {
                return e.Message;
            }
            return null;
        }

    }
}
