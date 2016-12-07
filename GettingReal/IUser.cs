using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MEG
{
    public interface IUser
    {
        bool Login(string un, string password);
        string UserType { get; set;}
        bool CheckUsername(string username);
        string Username { get; set; }
    }
}
