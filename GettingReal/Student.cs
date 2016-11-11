using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEG
{
    public interface IStudent
    {
        bool CheckLogin(string un, string pw);
    }

    public class Student : User, IStudent
    {

        public Student(string un, string pw, string fn, string ln) : base(un, pw, fn, ln)
        {
            Username = un;
            Password = pw;
            FirstName = fn;
            LastName = ln;
        }

        public override string ToString()
        {
            
            return "Student[FirstName=" + this.FirstName + ",LastName=" + this.LastName + "]";
        }
    }
}
