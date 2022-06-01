using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationWithExceptionAndReflection
{
    public class Validation
    {
        public string input;
        public Validation()
        {
            Console.WriteLine("Default Constructor");
        }
        public Validation(string input) // creating a constructor with one string parameter
        {
            this.input = input; // Assigning value to local variable
        }
        public string FirstNameValidation() // Creating a method for First name validation
        {
            try
            {
                string pattern = "^[A-Z][a-z]{2,}$"; // Regex for first name validation
                if (input == null)
                {
                    throw new InvalidException(InvalidException.ExceptionType.NULL_INPUT, "Input should not be null"); //throwing exception when first name is null
                }
                if (input.Equals(string.Empty))
                {
                    throw new InvalidException(InvalidException.ExceptionType.EMPTY_INPUT, "Input should not be empty"); //throwing exception when first name is empty
                }                 
                if (Regex.IsMatch(input, pattern)) //If name entered by user is match with regex then it is valid otherwise not
                {
                    Console.WriteLine($"\nYour first name \"{input}\" is valid");
                    return "Input is valid";
                }
                else
                {
                    throw new InvalidException(InvalidException.ExceptionType.INVALID_INPUT,"Input is not valid");//throwing exception when first name is not valid
                }                
            }
            catch(InvalidException ex) // If any exception throws then print exception message
            {
                Console.WriteLine("\n"+ex.Message);
                return ex.Message;
            }
        }
        public string LastNameValidation(string lName) // Creating a method for last name validation
        {
            try
            {
                string pattern = "^[A-Z][a-z]{2,}$"; // Regex for last name validation
                if (lName == null)
                {
                    throw new InvalidException(InvalidException.ExceptionType.NULL_INPUT, "Input should not be null"); //throwing exception when last name is null
                }
                if (lName.Equals(string.Empty))
                {
                    throw new InvalidException(InvalidException.ExceptionType.EMPTY_INPUT, "Input should not be empty"); //throwing exception when last name is empty
                }
                if (Regex.IsMatch(lName, pattern)) //If last name entered by user is match with regex then it is valid otherwise not
                {
                    Console.WriteLine($"\nYour last name \"{lName}\" is valid");
                    return "Input is valid";
                }
                else
                {
                    throw new InvalidException(InvalidException.ExceptionType.INVALID_INPUT, "Input is not valid");//throwing exception when lastt name is not valid
                }

            }
            catch (InvalidException ex) // If any exception throws then print exception message
            {
                Console.WriteLine("\n"+ex.Message);
                return ex.Message;
            }
        }
        public string EmailValidation(string email) // Creating a method for email name validation
        {
            try
            {
                string pattern = "^[0-9a-zA-Z]+[./+_-]{0,1}[0-9a-zA-Z]+[@][a-zA-Z0-9-]+[.][a-zA-Z]{2,}([.][a-zA-Z]{2,}){0,1}$"; // Regex for email validation
                if (email == null)
                {
                    throw new InvalidException(InvalidException.ExceptionType.NULL_INPUT, "Input should not be null"); //throwing exception when email is null
                }
                if (email.Equals(string.Empty))
                {
                    throw new InvalidException(InvalidException.ExceptionType.EMPTY_INPUT, "Input should not be empty"); //throwing exception when email is empty
                }
                if (Regex.IsMatch(email, pattern)) //If email entered by user is match with regex then it is valid otherwise not
                {
                    Console.WriteLine($"\nYour email address \"{email}\" is valid");
                    return "Input is valid";
                }
                else
                {
                    throw new InvalidException(InvalidException.ExceptionType.INVALID_INPUT, "Input is not valid");//throwing exception when email is not valid
                }

            }
            catch (InvalidException ex) // If any exception throws then print exception message
            {
                Console.WriteLine("\n"+ex.Message);
                return ex.Message;
            }
        }
        public string MobileNumberValidation(string mobileNumber) // Creating a method for mobile number validation
        {
            try
            {
                string pattern = "^[9][1][ ][6-9][0-9]{9}$"; // Regex for mobile number validation
                if (mobileNumber == null)
                {
                    throw new InvalidException(InvalidException.ExceptionType.NULL_INPUT, "Input should not be null"); //throwing exception when mobile number is null
                }
                if (mobileNumber.Equals(string.Empty))
                {
                    throw new InvalidException(InvalidException.ExceptionType.EMPTY_INPUT, "Input should not be empty"); //throwing exception when mobile number is empty
                }
                if (Regex.IsMatch(mobileNumber, pattern)) //If mobile number entered by user is match with regex then it is valid otherwise not
                {
                    Console.WriteLine($"\nYour mobile number \"{mobileNumber}\" is valid");
                    return "Input is valid";
                }
                else
                {
                    throw new InvalidException(InvalidException.ExceptionType.INVALID_INPUT, "Input is not valid");//throwing exception when mobile number is not valid
                }

            }
            catch (InvalidException ex) // If any exception throws then print exception message
            {
                Console.WriteLine("\n"+ex.Message);
                return ex.Message;
            }
        }
        public string PasswordRule1Validation(string password) // Creating a method for password rule 1 validation
        {
            try
            {
                string patternForRule1 = "^[0-9a-zA-Z@#$%^&*!+=]{8,}$"; // Regex for password rule 1 validation
                if (password == null)
                {
                    throw new InvalidException(InvalidException.ExceptionType.NULL_INPUT, "Input should not be null"); //throwing exception when password is null
                }
                if (password.Equals(string.Empty))
                {
                    throw new InvalidException(InvalidException.ExceptionType.EMPTY_INPUT, "Input should not be empty"); //throwing exception when password is empty
                }
                if (Regex.IsMatch(password, patternForRule1)) //If paasword entered by user is match with regex then it is valid otherwise not
                {
                    Console.WriteLine($"\nYour password \"{password}\" is valid");
                    return "Input is valid";
                }
                else
                {
                    throw new InvalidException(InvalidException.ExceptionType.INVALID_INPUT, "Input is not valid");//throwing exception when password is not valid
                }

            }
            catch (InvalidException ex) // If any exception throws then print exception message
            {
                Console.WriteLine("\n"+ex.Message);
                return ex.Message;
            }
        }
        public string PasswordRule2Validation(string password) // Creating a method for password rule 2 validation
        {
            try
            {
                string patternForRule2 = "^(?=.*[A-Z])[0-9a-zA-Z@#$%^&*!+=]{8,}$"; // Regex for password rule 2 validation
                if (password == null)
                {
                    throw new InvalidException(InvalidException.ExceptionType.NULL_INPUT, "Input should not be null"); //throwing exception when password is null
                }
                if (password.Equals(string.Empty))
                {
                    throw new InvalidException(InvalidException.ExceptionType.EMPTY_INPUT, "Input should not be empty"); //throwing exception when password is empty
                }
                if (Regex.IsMatch(password, patternForRule2)) //If paasword entered by user is match with regex then it is valid otherwise not
                {
                    Console.WriteLine($"\nYour password \"{password}\" is valid");
                    return "Input is valid";
                }
                else
                {
                    throw new InvalidException(InvalidException.ExceptionType.INVALID_INPUT, "Input is not valid");//throwing exception when password is not valid
                }

            }
            catch (InvalidException ex) // If any exception throws then print exception message
            {
                Console.WriteLine("\n"+ex.Message);
                return ex.Message;
            }
        }
        public string PasswordRule3Validation(string password) // Creating a method for password rule 3 validation
        {
            try
            {
                string patternForRule3 = "^(?=.*[A-Z])(?=.*[0-9])[0-9a-zA-Z@#$%^&*!+=]{8,}$"; // Regex for password rule 3 validation
                if (password == null)
                {
                    throw new InvalidException(InvalidException.ExceptionType.NULL_INPUT, "Input should not be null"); //throwing exception when password is null
                }
                if (password.Equals(string.Empty))
                {
                    throw new InvalidException(InvalidException.ExceptionType.EMPTY_INPUT, "Input should not be empty"); //throwing exception when password is empty
                }
                if (Regex.IsMatch(password, patternForRule3)) //If paasword entered by user is match with regex then it is valid otherwise not
                {
                    Console.WriteLine($"\nYour password \"{password}\" is valid");
                    return "Input is valid";
                }
                else
                {
                    throw new InvalidException(InvalidException.ExceptionType.INVALID_INPUT, "Input is not valid");//throwing exception when password is not valid
                }

            }
            catch (InvalidException ex) // If any exception throws then print exception message
            {
                Console.WriteLine("\n"+ex.Message);
                return ex.Message;
            }
        }
        public string PasswordRule4Validation(string password) // Creating a method for password rule 4 validation
        {
            try
            {
                string patternForRule4 = @"^(?=.{8,}$)(?=.*[0-9])(?=.*[A-Z])[A-Za-z0-9]{0,}?[@~!#$%^&*+=\/-]{1}[a-zA-Z0-9]{0,}$"; // Regex for password rule 4 validation
                if (password == null)
                {
                    throw new InvalidException(InvalidException.ExceptionType.NULL_INPUT, "Input should not be null"); //throwing exception when password is null
                }
                if (password.Equals(string.Empty))
                {
                    throw new InvalidException(InvalidException.ExceptionType.EMPTY_INPUT, "Input should not be empty"); //throwing exception when password is empty
                }
                if (Regex.IsMatch(password, patternForRule4)) //If paasword entered by user is match with regex then it is valid otherwise not
                {
                    Console.WriteLine($"\nYour password \"{password}\" is valid");
                    return "Input is valid";
                }
                else
                {
                    throw new InvalidException(InvalidException.ExceptionType.INVALID_INPUT, "Input is not valid");//throwing exception when password is not valid
                }

            }
            catch (InvalidException ex) // If any exception throws then print exception message
            {
                Console.WriteLine("\n"+ex.Message);
                return ex.Message;
            }
        }
    }
}
