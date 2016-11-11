using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEG;

namespace CLI
{
    public class Program
    {
        private bool running;
        private MEGController MEGC;
        static void Main(string[] args)
        {
            Program pr = new Program();
            pr.Run();    
        }

        public void Run() {
            MEGC = new MEGController();
            running = true;
            while (running) {
                Menu();

            }
        }

        public void Menu() {
            Console.WriteLine("MEG Menu:");
            Console.WriteLine("1. CreateTeacher()");
            Console.WriteLine("2. CreateStudent()");
            Console.WriteLine("3. TeacherLogin()");
            Console.WriteLine("4. StudentLogin()");
            int option = 0;
            int.TryParse(Console.ReadLine(), out);

            switch (option) {
                case 1: CreateTeacher();
                    break;
                case 2: CreateStudent();
                    break;
                case 3: TeacherLogin();
                    break;
                case 4: StudentLogin();
                    break;
            }
        }

        public void CreateTeacher()
        {
            Console.Clear();
            Console.WriteLine("Create a teacher:");
            Console.WriteLine("Type a username: ");
            string un = Console.ReadLine();
            Console.WriteLine("Type a password: ");
            string pw = Console.ReadLine();
            Console.WriteLine("Type your first name");
            string fn = Console.ReadLine();
            Console.WriteLine("Type your last name");
            string ln = Console.ReadLine();
            MEGC.CreateTeacher(un, pw, fn, ln);

        }

        private void AssignTeacher()
        {
            Console.Clear();
            Console.WriteLine("Classes: \n");
            foreach (string s in MEGC.GetClassNames())
            {
                Console.WriteLine("\n");
            }
            Console.WriteLine("How many classes is the teacher, teaching?");

        }

        private void CreateStudent()
        {
            
        }

        private void TeacherLogin() {
            

        }

        private void StudentLogin()
        {


        }
    }
}
