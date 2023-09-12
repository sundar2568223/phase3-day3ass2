using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign2
{
    public class UserAuthenticator
    {
        private Dictionary<string, string> userAccounts;

        public UserAuthenticator()
        {
            userAccounts = new Dictionary<string, string>();
        }

        public bool RegisterUser(string username, string password)
        {
            if (!userAccounts.ContainsKey(username))
            {
                userAccounts[username] = password;
                return true;
            }
            return false;
        }

        public bool LoginUser(string username, string password)
        {
            if (userAccounts.ContainsKey(username) && userAccounts[username] == password)
            {
                return true;
            }
            return false;
        }

        public bool ResetPassword(string username, string newPassword)
        {
            if (userAccounts.ContainsKey(username))
            {
                userAccounts[username] = newPassword;
                return true;
            }
            return false;
        }
    }
}
