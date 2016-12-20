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
        public ClassRoom currentClassRoom { get; set; } 
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

        public bool SpentStudentPoint(int amount)
        {
            if (this.studentPoints >= amount) {
                this.studentPoints = studentPoints - amount;
                return true;
            }
            return false;
        }

        public void AddStudentPoints(int amount)
        {
            this.studentPoints =+ amount;
        }


         
    }
}
