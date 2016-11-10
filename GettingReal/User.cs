using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal
{
    public abstract class User
    {
        protected string Login { get;}
        protected byte Password { get { ; } }   

        public User(int login, string password) {
         
        }

        private string HashPassword(string PW) {
            var md5 = new MD5CryptoServiceProvider();
            return md5data = md5.ComputeHash(data);
            
        }

        private string UnhashPassword()
        {
            var data = Encoding.ASCII.GetBytes(password);

            var hashedPassword = ASCIIEncoding.GetString(md5data);
        }
    }
}
