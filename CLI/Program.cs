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
        private string username = "";
        private string usertype = "";
        private bool loggedIn = false;

        private bool running;
        private MEG.MEG MEGC;
        static void Main(string[] args)
        {
            Program pr = new Program();
            pr.Run();
        }

        public void Run() {
            MEGC = new MEG.MEG();
            running = true;
            while (running) {
                Menu();
            }
        }

        public void PrintMenuText()
        {
            Console.Clear();
            Console.WriteLine("MEG Menu Default Options:");
            Console.WriteLine("1. CreateTeacher()");
            Console.WriteLine("2. CreateStudent()");
            Console.WriteLine("3. Login()");
            Console.WriteLine("4. GetTeacherNames()");
            if (loggedIn == true)
            {
                if (this.usertype == "Student")
                {
                    Console.WriteLine("5. blablabla");

                }
                if (this.usertype == "Student")
                {
                    Console.WriteLine("5. blablabla2");
                }
                Console.WriteLine("0. Close");
            }
        }

        private void MenuOptions(int opt) {

            switch (opt)
            {
                case 0:
                    running = false;
                    break;
                case 1:
                    CreateTeacher();
                    break;
                case 2:
                    Login();
                    break;
                case 3:
                    CreateTask();
                    break;
                case 4:
                    break;
               /* case 5:
                    if (loggedIn == true)
                    {
                        if (this.usertype == "Student")
                        {
                        }
                        if (this.usertype == "Teacher")
                        {
                        }
                
                    }
                break;
                */
            }
            }

        
            

        public void Menu() {
            PrintMenuText();
            int option;
            int.TryParse(Console.ReadLine(), out option);
            MenuOptions(option);
           
        }

        private void CreateTask()
        {
        }

        public void CreateTeacher()
        {
            string un = "";
            Console.Clear();
    
            Console.WriteLine("Create a teacher:");
            Console.WriteLine("Type a username: ");
            un = Console.ReadLine();
            Console.WriteLine("Type a password: ");
            string pw = Console.ReadLine();
            Console.WriteLine("Type your first name: ");
            string fn = Console.ReadLine();
            Console.WriteLine("Type your last name: ");
            string ln = Console.ReadLine();
            Console.WriteLine("Type your email: ");
            string email = Console.ReadLine();

            if(MEGC.CreateTeacher(un, pw, fn, ln, email))
            {

            }
            
            Console.WriteLine("How many classes are you teaching?");
            int nb;
            int.TryParse(Console.ReadLine(), out nb);

            for(int k = 0; k < nb; k++) {
                AssignTeacher(un);
            }
            Console.Clear();
        }

        private void AssignTeacher(string teacherUN)
        {
            Console.Clear();
            Console.WriteLine("Classes: \n");
            foreach (string s in MEGC.GetClassRoomNames())
            {
                Console.WriteLine("\n" + s);
            }
            Console.WriteLine("Type the name of the class:");
            bool canAssignTeacher = false;
            string classRoomName = "";
            while (!canAssignTeacher) {
                    classRoomName = Console.ReadLine();
                    if (MEGC.AssignTeacher(teacherUN, classRoomName)) 
                    if(!canAssignTeacher) Console.WriteLine("Error: Either the teacher is already assigned to the class or the class doesn't exist try again.");
            }
            Console.WriteLine("Teacher assigned to class");
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
            MEGC.CreateStudent("1.B", fn, ln);

        }

        private void Login()
        {
            Console.Clear();
            Console.WriteLine("--- Login ---");
            Console.WriteLine("Type your username: ");
            string un = Console.ReadLine();
            Console.WriteLine("Type your password: ");
            string pw = Console.ReadLine();
            if (MEGC.Login(un, pw))
            {
                
                this.username = un;
                this.usertype = MEGC.GetUserType(username); ;
                Console.WriteLine("You have been logged in.");
            }
            else {
                this.Login();
            }
        }
    }
}
