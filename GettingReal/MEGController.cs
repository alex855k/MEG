using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEG
{
    public class MEGController
    {
        
        List<Teacher> _teachers = new List<Teacher>();
        List<Student> _students = new List<Student>();
        List<ClassRoom> _classRooms = new List<ClassRoom>();

        public MEGController() {
            InitClassrooms();
            //LoadTeacher();
        }

        public void CreateTeacher(string un, string pw, string fn, string ln)
        {
            Teacher t = new Teacher(un, pw, fn, ln);
            _teachers.Add(t);
        }

        private void InitClassrooms()
        {
            _classRooms.Add(new ClassRoom("1.B"));
            _classRooms.Add(new ClassRoom("2.B"));
            _classRooms.Add(new ClassRoom("3.B"));
            _classRooms.Add(new ClassRoom("1.A"));
            _classRooms.Add(new ClassRoom("2.A"));
            _classRooms.Add(new ClassRoom("3.A"));

        }

        private ClassRoom FindClassRoom() {
            ClassRoom cr = (ClassRoom) new object();
            foreach (ClassRoom c in _classRooms) {
                cr = c; 
            }
            return cr;
        }

        public bool TeacherLogin(string un, string pw) {
            bool st = false;
            foreach (Teacher t in _teachers) {
                if (t.CheckLogin(un, pw)) st = true;
            }
            return st;
        }

        public List<string> GetClassRoomNames()
        {
            List<string> rl = new List<string>();
            foreach (ClassRoom c in _classRooms) {
                rl.Add(c.ClassName);
            }
            return rl;
        }

        public void CreateStudent(string fn, string ln)
        {
            throw new NotImplementedException();
        }

        public bool TeacherLogin()
        {
            throw new NotImplementedException();
        }

        public bool StudentLogin(string un, object ln)
        {
            throw new NotImplementedException();
        }
    }
}
