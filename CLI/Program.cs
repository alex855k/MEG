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
            Console.WriteLine("5. CreateTask()");
            Console.WriteLine("0. Close");
            int option;
            int.TryParse(Console.ReadLine(), out option);
            switch (option) {
                case 0:
                    running = false;
                    break;
                case 1: CreateTeacher();
                    break;
                case 2: CreateStudent();
                    break;
                case 3: TeacherLogin();
                    break;
                case 4: StudentLogin();
                    break;
                case 5: CreateTask();
                    break;
            }
        }

        private void CreateTask()
        {
            Console.Clear();
            Console.WriteLine("Create Task:");
            Console.WriteLine("Type a description of the task:");
            string description = Console.ReadLine();
            Console.WriteLine("Type the type of task this is:");
            string type = Console.ReadLine();
            Console.WriteLine("Type the amount of study points this task is worth:");
            string sp = Console.ReadLine();
            MEGC.CreateTask(description, type, sp);
            Console.Clear();
        }

        public void CreateTeacher()
        {
            Console.Clear();
            Console.WriteLine("Create a teacher:");
            Console.WriteLine("Type a username: ");
            string un = Console.ReadLine();
            Console.WriteLine("Type a password: ");
            string pw = Console.ReadLine();
            Console.WriteLine("Type your first name: ");
            string fn = Console.ReadLine();
            Console.WriteLine("Type your last name: ");
            string ln = Console.ReadLine();
            MEGC.CreateTeacher(un, pw, fn, ln);
            Console.WriteLine("How many classes are you teaching?");
            int nb;
            int.TryParse(Console.ReadLine(), out nb);

            for(int k = 0; k < nb; k++) {
                AssignTeacher();
            }
            Console.Clear();
        }

        private void AssignTeacher()
        {
            Console.Clear();
            Console.WriteLine("Classes: \n");
            foreach (string s in MEGC.GetClassRoomNames())
            {
                Console.WriteLine("\n" + s);
            }
            Console.WriteLine("Type the name of the class:");
            
        }

        private void CreateStudent()
        {
            Console.Clear();
            Console.WriteLine("Create a student");
            string pw = Console.ReadLine();
            Console.WriteLine("Type the first name");
            string fn = Console.ReadLine();
            Console.WriteLine("Type the last name");
            string ln = Console.ReadLine();
            //MEGC.CreateStudent("1.B", fn, ln);

        }

        private void TeacherLogin() {
            Console.Clear();
            Console.WriteLine();
            string un = Console.ReadLine();
            string pw = Console.ReadLine();

            if (MEGC.TeacherLogin(un, pw))
            {
                Console.WriteLine("You are logged in.");
            }
            else
            {
                Console.WriteLine("Wrong login info.");
            }
            
        }

        private void StudentLogin()
        {
            string un = Console.ReadLine();
            string pw = Console.ReadLine();

            

        }
    }
}
