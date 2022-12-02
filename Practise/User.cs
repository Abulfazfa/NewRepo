using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Practise
{
    internal class User : IAccount
    {
        protected static int Id { get; set; }
        private int IdCount { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        private string Password { get; set; }
        public User()
        {
            Id++;
            IdCount = Id;
            
            FullName = "Ali Ali";
            Console.WriteLine("Enter password");
            PasswordCheaker(Password);
            Console.WriteLine("Enter email address");
            EmailCheaker(Email);
        }

        public bool PasswordCheaker(string password)
        {
            password = Console.ReadLine();
            string passwordPattern = @"(^[.a-zA-Z0-9].{8,}$)";

            while (!Regex.IsMatch(password, passwordPattern))
            {
               Console.WriteLine("password must have at least 8 characters\r\n                         - the password must contain at least 1 capital letter\r\n                         - the password must contain at least 1 lowercase letter\r\n                         - the password must have at least 1 digit");
               password = Console.ReadLine();
            }
                
             return true;

        }
        public bool EmailCheaker(string email)
        {
            email = Console.ReadLine();
            Email = email;
            while (string.IsNullOrEmpty(email))
            {
                Console.WriteLine("Something is wrong");
                email = Console.ReadLine();
            }
            return true;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id number >> {Id}");
            Console.WriteLine($"Fullname >> {FullName}");
            Console.WriteLine($"Email address >> {Email}");
        }

        
    }
}
