using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MEG
{
    public interface IClassRoom{
        string ViewStudents();

    }

    public class ClassRoom : IClassRoom
    {
        public string ClassName { get; }

        private List<Student> _students = new List<Student>();
        private List<Teacher> _teachers = new List<Teacher>();
        private List<Assignment> _assignments = new List<Assignment>();


        public ClassRoom(string cn) {
            this.ClassName = cn;
        }


        public string ViewStudents() {
            string rs = "\n--- Students of "+this.ClassName+ " --- ";
            foreach (Student s in _students) {
                rs += "\n Name: " + s.FirstName + " " + s.LastName;
                rs += "\n Username: " + s.Username + "\n Password: " + s.Password;
                rs += "\n______________________________";
            }
            return rs;
        }

        public void AddStudent(Student s) {
            _students.Add(s);
        }


        public bool AddTeacher(Teacher t)
        {
            _teachers.Add(t);
            return true;
        }


        public bool AddTask(Assignment task)
        {
            Console.WriteLine("AddTask didn't exit");
            Console.ReadLine();

            bool canAddTask = false;
            if (!_assignments.Contains(task)) {
                try
                {
                    _assignments.Add(task);
                }
                catch (Exception e) {
                    Console.WriteLine(e);
                }
            }
            
            
            return canAddTask;
        }

        public bool FindTeacher(Teacher t)
        {
            return _teachers.Contains(t);
        }

        public List<Assignment> GeAllTasks()
        {
            return _assignments;
        }

        public List<Assignment> GetCompletedTasks()
        {
            List<Assignment> _rl = new List<Assignment>();
            foreach(Assignment a in _rl) {
                
            }
            return _rl;
        }
    }
}
