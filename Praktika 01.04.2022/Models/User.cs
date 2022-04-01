using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika_01._04._2022.Models
{
    public class User : IAcoount
    {
        private static int _id;
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Id { get; }

        private User()
        {
            _id++;
            Id = _id;
        }
        public User(string email, string password,string fullname) : this()
        {
            Email = email;
            Password = password;
            Fullname = fullname;
        }

        //- şifrədə minimum 8 character olmalıdır
        //- şifrədə ən az 1 böyük hərf olmalıdır
        //- şifrədə ən az 1 kiçik hərf olmalıdır
        //- şifrədə ən az 1 rəqəm olmalıdır
        public bool PasswordChecker(string password)
        {
            if (password.Length >= 8 && !string.IsNullOrEmpty(password) && !string.IsNullOrWhiteSpace(password))
            {
                bool HasUpper = false;
                bool HasLower = false;
                bool HasDigit = false;
                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsUpper(password[i])) HasUpper = true;
                    else if (char.IsLower(password[i])) HasLower = true;
                    else if (char.IsDigit(password[i])) HasDigit = true;
                    if (HasDigit && HasLower && HasUpper)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // ShowInfo() - bu method console-a user-in Id, Fullname və email dəyərlərini yazdırır
        public string ShowInfo()
        {
            return($"Id:{Id},Fullname:{Fullname},Email:{Email}");
        }
    }
}
