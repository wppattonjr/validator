using System;

namespace Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Validate 4-8 digit PIN
            Console.WriteLine("Please enter a PIN number that is between 4 and 8 digits");
            string pin = Console.ReadLine();
            bool allDigits = true;
            while (true)
            {
                foreach (var digit in pin)
                {
                    if (Char.IsDigit(digit))
                    {
                        allDigits = true;
                    }
                    else
                    {
                        allDigits = false;
                        break;
                    }
                    break;
                }
                break;
            }
            bool validatePin = pin.Length >= 4 && pin.Length <= 8 && allDigits == true;

            if (validatePin == true)
            {
                Console.WriteLine("You have entered a valid PIN number.");
            }
            else
            {
                Console.WriteLine("You have entered an invalid PIN number. Please read instructions and try again.");
            }

            //Validate phone number
            Console.WriteLine("Please enter a valid phone number.");
            var userInput = Console.ReadLine();
            bool digitCheck = true;
            var phoneNumber = userInput.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "");
            while (true)
            {
                foreach(var digit in phoneNumber)
                {
                    if (Char.IsDigit(digit))
                    {
                        digitCheck = true;
                    }
                    else
                    {
                        digitCheck = false;
                        break;
                    }
                    break;
                }
                break;
            }
            bool validPhoneNumber = phoneNumber.Length == 10 && digitCheck == true;

            if (validPhoneNumber == true)
            {
                Console.WriteLine("The number that you entered is a valid phone number");
            }
            else
            {
                Console.WriteLine("The number that you entered IS NOT a valid phone number");
            }

            //Validate email address
            Console.WriteLine("Please enter a valid email address");
            var userEmailInput = Console.ReadLine();

            bool emailCheck (string email)
            {
                try
                {
                    var address = new System.Net.Mail.MailAddress(email);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
                if (emailCheck(userEmailInput) == true)
                {
                    Console.WriteLine("You have entered a valid email address");
                }
                else
                {
                    Console.WriteLine("You have entered an invalid email address. Please try again");
                }
            }
        }
    }
