using System;
using System.Collections.Generic;
using System.Text;

namespace MEG
{
    public interface ITeacher {
        void CreateStudent(string cn, string fn, string ln);
        bool CreateTask(string className, Subject subject, string description, int studentPointValue, TaskType taskType);
        string ToString();
    }

    public class Teacher : User, ITeacher, IUser
    {     

        private SortedList<ClassRoom, List<Subject>> _classRooms = new SortedList<ClassRoom, List<Subject>>();
        public string Email { get; private set; }


        public Teacher(string un, string pw, string fn, string ln, string email) : base(fn, ln)
        {
            this.Username = un;
            this.Password = pw;
            this.Email = email;
            this.UserType = "Teacher";
        }

        public Teacher(string fn, string ln) : base(fn,ln)
        {

        }

        public List<string> getClassRooms() {
            List<string> rl = new List<string>();
            foreach(var c in _classRooms){
                rl.Add(c.Key.ClassName);
            }
            return rl;
        }

        public void CreateStudent(string cn, string fn, string ln)
        {
            foreach (var c in _classRooms) {
                if (c.Key.ClassName == cn) {
                    c.Key.AddStudent(new Student(fn, ln));
                }
            }    
        }
        // NEED TO REFACTOR
        private string GenerateUsername(string fn)
        {
            Random rnd = new Random();
            return fn + rnd.Next(1,10) + rnd.Next(1, 10) + rnd.Next(1, 10);
        }
        // NEED TO REFACTOR
        private string GeneratePassword()
        {
            const string valid = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder rs = new StringBuilder();
            Random rnd = new Random();
            int length = 3;
            rs.Append(LastName);
            while (0 < length--)
            {
               
                rs.Append(valid[rnd.Next(valid.Length)]);
            }
            return rs.ToString();
        }

        public override string ToString()
        {
            string s = "Teacher[Username=" + this.Username + ",Password=" + this.Password + 
                        ",Firstname="+ this.FirstName+
                        ",LastName=" +this.LastName+ ",Email="+ this.Email +"]";

            return s;
        }

        public List<string> getSubjectNames(string className)
        {
            List<string> sj = new List<string>();
            foreach (var c in _classRooms.Keys) {
                if(c.ClassName == className)
                {
                    foreach (Subject s in _classRooms[c]) {
                        sj.Add(Enum.GetName(typeof(Subject), s));
                    }
                }
            }
            return sj;
        }


        public List<string> getClassRoomNames()
        {
            List<string> sj = new List<string>();
            foreach(var c in _classRooms.Keys) {
                sj.Add(c.ClassName);
                    }
            return sj;
        }

        public bool CreateTask(string className, Subject subject, string description, int studentPointValue, TaskType type)
        {
            foreach(var c in _classRooms) {
                if (c.Key.ClassName == className) {
                    //c.Key.AddTask(new Task(description, , studentPointValue));
                }
            }
            return true;   
        }

    }
}
