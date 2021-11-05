using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Iacob_Calin
{
    class User
    {
    
        string txtpattern = @"^[a-zA-Z0-9]+@[a-zA-Z0-9]{1,10}.(com|org)$";
    
        public string Email { get; set; }
        public string Name { get; set; }
        public bool logInCheck(Dictionary<string,string> users, string email)
        {
            if (users.ContainsValue(email.Trim()))
                return true;
            else
                return false;
        }

        public bool isEmailAvailable(Dictionary<string, string> users, string email)
        {
            Regex rgx = new Regex(txtpattern);
            
         //Am stat aproape doua ore la chestia asta :(
            if (!users.ContainsValue(email) && (rgx.IsMatch(email)))
                   return true;
            else
                return false;
        }

    }
}
