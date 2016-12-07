using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEG
{

    public interface IStudent
    {
        int GetStudentPoint();
    }

    public class Student : User, IStudent, IUser
    {

        private int studentPoints;
        private int studentCreationNumber;

        public Student(string fn, string ln) : base(fn, ln)
        {
            Random rnd = new Random();
            studentCreationNumber = rnd.Next(100, 999);
            Username = CreateUserName();
            Password = CreatePassword();
            studentPoints = 0;
            UserType = "Student";
        }

        private string CreateUserName()
        {
            // to be updated
            return FirstName + studentCreationNumber;
        }

        private string CreatePassword(){
            return LastName + studentCreationNumber;
        }

        public int GetStudentPoint()
        {
            return studentPoints;
        }

        public override string ToString()
        {
            return "Student[FirstName=" + this.FirstName + ",LastName=" + this.LastName + "]";
        }

        public string GetUsername()
        {
            throw new NotImplementedException();
        }
    }
}
