using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEG
{
    public abstract class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        protected int Privileges { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public User(string un, string pw, string fn, string ln) {
            Privileges = 0;
        }

        public bool CheckLogin(string un, string pw) {
            bool canLogin = false; 
            if (Username == un && pw == Password) {
                canLogin = true;
            }
            return canLogin;
        }
      
    }
}
