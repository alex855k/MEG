using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEG
{
    public class MEGController
    {

        private List<Teacher> _teachers = new List<Teacher>();
        private List<Student> _students = new List<Student>();
        private List<ClassRoom> _classRooms = new List<ClassRoom>();
        public  List<IUser> _users = new List<IUser>();

        public MEGController() {
            InitClassrooms();
            InitTeachers();
        }

        private void InitTeachers()
        {
            CreateTeacher("alex01", "pass", "Alexander", "Hvidt", "alexander2341@gmail.com");
            CreateTeacher("matt02", "pass", "Matthew", "Peterson", "blabla@blab.com");
            CreateTeacher("hedviga03", "pass", "Hedviga", "something", "dsaasdsdsad");
        }

        public bool CreateTeacher(string un, string pw, string fn, string ln, string email)
        {
            bool canCreateTeacher = false;
            if (!FindTeacher(email)){ 
                Teacher t = new Teacher(un, pw, fn, ln, email);
                _teachers.Add(t);
                _users.Add(t);
                canCreateTeacher = true;
            }
            return canCreateTeacher;
        }

        public void CreateTask(string description, string type, string sp)
        {
            string typeCapitalized = type.First().ToString().ToUpper() + type.Substring(1);
            TaskType tasktype = (TaskType)Enum.Parse(typeof(TaskType), typeCapitalized);
            int studyPoints;
            int.TryParse(sp, out studyPoints);
            Task newTask = new Task(description, tasktype, studyPoints);
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

            ClassRoom cr = new ClassRoom("");
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

        public List<string> GetClassRoomNames()
        {
            List<string> rl = new List<string>();
            foreach (ClassRoom c in _classRooms) {
                rl.Add(c.ClassName);
            }
            return rl;
        }

        public string Login(string un, string pw)
        {
            foreach (IUser u in _users) {
                if(u.Login(un, pw)) return u.UserType;
            }
                return "";
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

        //redundant - to be removed
        /*
        private bool teacherIsAssignedToClassRoom(string cr, Teacher teacher) {

            bool isAssigned = false;
       
            return isAssigned;
        }
        */
        public bool AssignTeacher(string email, string classRoomName)
        {
            bool canAssignTeacher = false;

            if (this.FindTeacher(email)) {
                Teacher t = GetTeacher(email);

                if (FindClassRoom(classRoomName)) {
                    canAssignTeacher = GetClassRoom(classRoomName).AddTeacher(t);
                }
            }
            return canAssignTeacher;
        }

        private Teacher GetTeacher(string email)
        {
            Teacher teacher = new Teacher("", ""); 
            foreach (Teacher t in _teachers) {
                if (t.Email==email) {
                    teacher = t;
                }
            }
            return teacher;
        }

        public List<string> GetTeacherInfo() {
            List<string> teachers = new List<string>();
            foreach(Teacher t in _teachers)
            {
                teachers.Add(t.ToString());
            }
            return teachers; 
        }

        public string GetUserType(string un)
        {
            string rs = "";
            foreach (IUser u in _users) { 
                if (u.UserExists(un)) rs = u.UserType;
            }
            return rs;
        }



        public bool CreateStudent(string fn, string ln, string classRoom)
        {
            Student s = new Student(fn, ln);
            _users.Add(s);
            _students.Add(s);
            FindClassRoom(classRoom);

            this.GetClassRoom(classRoom).AddStudent(s);
            return true;
        }

        public void GetTeacherClassRooms(string username)
        {
            /*
            foreach (GetTeacher())
            {

            }
            */
        }
    }
}
