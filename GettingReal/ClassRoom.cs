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


        public bool AddTeacher(Teacher t)
        {
            _teachers.Add(t);
            return true;
        }

        // Note: to be updated because currently doesn't compare values of tasks, just compares location of task object in memory
        public bool AddTask(Task task)
        {
            bool canAddTask = false;
            if (!_tasks.Contains(task)) { 

                _tasks.Add(task);
            }
            return canAddTask;
        }

        public bool FindTeacher(Teacher t)
        {
            return _teachers.Contains(t);
        }
    }
}
