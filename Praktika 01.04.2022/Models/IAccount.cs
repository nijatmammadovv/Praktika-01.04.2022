using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika_01._04._2022.Models
{
    interface IAcoount
    {
        public bool PasswordChecker(string password);
        public string ShowInfo();
    }
}
