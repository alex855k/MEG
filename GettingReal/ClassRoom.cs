using System;
using System.Collections.Generic;
using System.Text;

namespace MEG
{
    public class ClassRoom
    {
        public string ClassName { get; }

        private List<Student> _students = new List<Student>();
        private List<Teacher> _teachers = new List<Teacher>();
        private List<Task> _tasks = new List<Task>();


        public ClassRoom(string cn) {
            this.ClassName = cn;
        }

        public string ViewStudents() {
            string rs = "\n--- Student --- ";
            foreach (Student s in _students) {
                rs += "\n Name: " + s.FirstName + " " + s.LastName;
                rs += "\n Username: " + s.Username + "\n Password: " + s.Password;
            }
            return rs;
        }

        public void AddStudent(Student s) {
            _students.Add(s);
        }

        public void AddTeacher(Teacher t)
        {
            _teachers.Add(t);
        }

        public void AddTask(Task task)
        {
            _tasks.Add(task);
        }
    }
}
