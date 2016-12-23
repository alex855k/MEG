using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEG;
namespace MEGAltSolution
{

    public interface IUserRep {
        IUser GetUser(string username);
        bool AddUser(Teacher u);
        bool AddUser(Student u);
    }

    public class UserRep : IUserRep
    {
        Dictionary<string, IUser> _users = new Dictionary<string, IUser>();

        public bool AddUser(Teacher t)
        {
            return AddUser((IUser) t); 
        }

        public bool AddUser(Student s)
        {
            return AddUser((IUser)s);
        }
        /*
        public bool SaveTeacher(Teacher t) {
            DB.SaveUser(t);
        }

        public bool SaveStudent(Student s)
        {
            DB.SaveUser(s);
        }

        public bool LoadTeacher(string username) {
            DB.Load()
        }

        public bool LoadStudent(string username)
        {
            DB.Load()
        }
        */
        private bool AddUser(IUser u) 
        {
            bool canAddUser = false;
            if (_users.ContainsValue(u))
            {
                _users.Add(u.Username, u);
                canAddUser = true;
            }
            return canAddUser;
        }

        public IUser GetUser(string username)
        {
            IUser u;
            _users.TryGetValue("", out u);
            return u;
        }
    }
}
