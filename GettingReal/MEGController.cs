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
            //LoadStudents();
            //LoadTeacher();
        }

        public void CreateTeacher(string un, string pw, string fn, string ln)
        {
            //_teachers.Add(new Teacher());
        }

        private void InitClassrooms()
        {
            _classRooms.Add(new ClassRoom());
        }

        public bool TeacherLogin(string un, string pw) {

            foreach (Teacher t in _teachers) {
                //t.CheckLogin()
            }
            return true;
        }

        public List<string> GetClassNames()
        {
            GetClassNames();
        }
    }
}
