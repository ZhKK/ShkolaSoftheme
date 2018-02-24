using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class User : IUser
    {
        
        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public string Password { get; private set; }

        public string GetFullInfo()
        {
            var info = string.Format("Name: {0}, \nEmail: {1}, \nPassword: {2}", Name, Email, Password);
            return info;
        }
    }
}