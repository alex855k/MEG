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



        public bool CreateTeacher(string un, string pw, string fn, string ln, string email)
        {
            bool canCreateTeacher = false;
            if (!FindTeacher(email)){ 
                Teacher t = new Teacher(un, pw, fn, ln, email);
                _teachers.Add(t);
                canCreateTeacher = true;
            }
            return canCreateTeacher;
        }

        private bool FindTeacher(string email)
        {
            bool canFindTeacer = false;
            foreach (Teacher t in _teachers) {
                if (t.Email == email) canFindTeacer = true; 
            }
            return canFindTeacer;
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

        private ClassRoom GetClassRoom(string classRoom) {

            ClassRoom cr = (ClassRoom) new object();
            foreach (ClassRoom c in _classRooms) {
                if(classRoom == c.ClassName) cr = c; 
            }
            return cr;
        }

        private bool FindClassRoom(string classRoom)
        {
            bool canFindClassRoom = false;
            foreach (ClassRoom c in _classRooms)
            {
                if (c.ClassName == classRoom) canFindClassRoom = true;
            }
            return canFindClassRoom;
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
            
        }

        public bool StudentLogin(string un, string pw)
        {
            FindStudent(_students);
        }

        public bool ClassRoomExists(string cr)
        {
            bool cond = false;
            foreach (ClassRoom c in _classRooms) {
                if (c.ClassName == cr) {
                    cond = true;
                }
            }
            return cond;
        }

        private bool teacherIsAssignedToClassRoom(string cr, Teacher teacher) {

            bool isAssigned = false;
            _
            return isAssigned;
        }

        public bool AssignTeacher(string email, string classRoomName)
        {
            bool canAssignTeacher = false;

            if (this.FindTeacher(email)) {
                Teacher t = GetTeacher(email)

                if (FindClassRoom(classRoomName)) {

                    if (GetClassRoom(classRoomName).AddTeacher(t);

                }
                else
                {
                    throw new Exception("Couldn't find classroom");
                }
            }
            return false;
        }

        private Teacher GetTeacher(string email)
        {
            Teacher teacher = (Teacher)new Object(); 
            foreach (Teacher t in _teachers) {
                if (t.Email==email) {
                    teacher = t;
                }
            }
            return teacher;
        }
    }
}
