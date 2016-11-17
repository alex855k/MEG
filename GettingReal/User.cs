using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEG
{
    public abstract class User
    {
        public string UserType { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public User(string fn, string ln) {
            this.FirstName = fn;
            this.LastName = ln;
        }

        public bool Login(string un, string pw) {
            bool canLogin = false; 
            if (Username == un && pw == Password) {
                canLogin = true;
            }
            return canLogin;
        }


      
    }
}
