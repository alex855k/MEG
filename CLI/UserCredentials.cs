using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI
{
    public class UserCredentials
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Usertype { get; set; }

        public UserCredentials(string un, string em, string ut) {
            this.Username = un;
            this.Email = em;
            this.Username = ut;
        }
     
    }
}
