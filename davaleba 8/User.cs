using System;
using System.Collections.Generic;
using System.Text;

namespace davaleba_8
{
    internal class User
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    lastName = value;
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 18 && value <= 100)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Contains(""))
                {
                    email = value;
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length >= 8)
                {
                    password = value;
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }
        private string phoneNumber;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (value != null && value.Length == 9)
                {
                    phoneNumber = value;
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }

        private double salary;

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value > 0)
                {
                    salary = value;
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }

        private string userName;

        public string UserName
        {
            get { return userName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length >= 4)
                {
                    userName = value;
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }
        private string country;

        public string Country
        {
            get { return country; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    country = value;
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }

        private int score;

        public int Score
        {
            get { return score; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    score = value;
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }
    }
}
