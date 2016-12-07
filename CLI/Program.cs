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
        private string username;
        private string usertype;
        private bool isLoggedIn = false;
        private bool running;

        private MEGController MEGC;
        private string email;

        static void Main(string[] args)
        {
            Program pr = new Program();
            pr.Run();    
        }

        public void Run() {
            MEGC = new MEGController();
            running = true;
            
            while (running) {
                ShowMenu();
            }
        }

        public void PrintMenuText(){
            Console.Clear();
            if (isLoggedIn) {
                Console.WriteLine("You are logged in as: " + this.username  +"(" + this.usertype+ ")");
            }
            Console.WriteLine("MEG Menu:");
            Console.WriteLine("1. CreateTeacher()");
            Console.WriteLine("2. GetTeacherinfo()");
            if (isLoggedIn)
            {
                Console.WriteLine("3. Logout");
            }
            else { 
                Console.WriteLine("3. Login");
            }
            if (isLoggedIn)
            {
                if (usertype == "Teacher")
                {
                    Console.WriteLine("4. CreateStudent()");
                    Console.WriteLine("5. ViewStudents()");
                    Console.WriteLine("6. CreateTask()");
                }
                if (usertype == "Student")
                {
                    Console.WriteLine("5. ViewTasks()");
                }

            }
            else {
                    Console.WriteLine("11. Quick login with premade teacher credentials");
            }
            
            Console.WriteLine("0. Close");
        }

        public void ShowMenu() {
            PrintMenuText();
            int option;
            int.TryParse(Console.ReadLine(), out option);
            MenuSelectOption(option);
        }

        private void MenuSelectOption(int opt)
        {
            switch (opt)
            {
                default:
                    Console.WriteLine("Wrong input, try again.");
                    break;
                case 11:
                    if (!isLoggedIn)
                    {
                        LoginWithTeacher();
                    }
                    else {
                        Console.WriteLine("You are already logged in.");
                    }
                    
                    break;
                case 12:
                    Console.WriteLine("Not implemented");
                    break;
                case 0:
                    running = false;
                    break;
                case 1:
                    CreateTeacher();
                    break;
                case 2:
                    GetTeacherinfo();
                    break;
                case 3:
                    if (isLoggedIn)
                    {
                        Console.Clear();
                        Logout();
                    }
                    else {
                        Console.Clear();
                        Login();
                    }
                    break;
                case 4:
                    if (isLoggedIn) {
                        if (usertype == "Teacher") {
                            Console.Clear();
                            CreateStudent();
                        }
                        if (usertype == "Student")
                        {
                            Console.Clear(); 
                        }
                    }
                    break;
                case 5:
                    if (isLoggedIn)
                    {
                        if (usertype == "Teacher")
                        {
                            Console.Clear();
                            ViewStudents();
                        }
                        if (usertype == "Student")
                        {
                            Console.Clear();
                        }
                    }
                    break;
            }
        }


        private void GetTeacherinfo()
        {
            foreach (string s in MEGC.GetTeacherInfo()) {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }

        private void Logout()
        {
            isLoggedIn = false;
            usertype = "";
            username = "";
            email = "";
        }

        public void CreateTeacher()
        {
            string email = "";
            Console.Clear();
            bool cantCreateTeacher = true;
            while (cantCreateTeacher) { 
                Console.WriteLine("Create a teacher:");
                Console.WriteLine("Type a username: ");
                string un = Console.ReadLine();
                Console.WriteLine("Type a password: ");
                string pw = Console.ReadLine();
                Console.WriteLine("Type your first name: ");
                string fn = Console.ReadLine();
                Console.WriteLine("Type your last name: ");
                string ln = Console.ReadLine();
                Console.WriteLine("Type your email: ");
                email = Console.ReadLine();
                cantCreateTeacher = !MEGC.CreateTeacher(un, pw, fn, ln, email);
            }
            Console.WriteLine("How many classes are you teaching?");
            int nb;
            int.TryParse(Console.ReadLine(), out nb);
            for(int k = 0; k < nb; k++) {
                AssignTeacher(email);
            }
            Console.Clear();
        }
        


        private void AssignTeacher(string email)
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
            while (!canAssignTeacher)
            {
                classRoomName = Console.ReadLine();
                canAssignTeacher = MEGC.AssignTeacher(email, classRoomName);
                if(!canAssignTeacher) Console.WriteLine("Error: Either the teacher is already assigned to the class or the class doesn't exist try again.");

            }
            Console.WriteLine("Teacher assigned to class");
        }

        private string SelectClass() {

            string classSelection = "";
            List<string> _classRooms = MEGC.GetClassRoomsTeacher(username);
            Console.WriteLine("Select a class:");
            foreach (string c in _classRooms)
            {
                Console.WriteLine(c);
            }

            classSelection = Console.ReadLine();
            return classSelection; 
        }

        public void ViewStudents() {
            Console.WriteLine(MEGC.ViewStudents(this.SelectClass()));
            Console.ReadKey();
            Console.Clear();
        }

        private void CreateStudent()
        {
            bool couldntCreateStudent = true;
            while (couldntCreateStudent) {
                Console.Clear();
                Console.WriteLine("Create a student");
                Console.WriteLine("Type the first name");
                string fn = Console.ReadLine();
                Console.WriteLine("Type the last name");
                string ln = Console.ReadLine();
                Console.WriteLine("Type in the name of the class:");
                string classRoom = SelectClass();
                if (MEGC.CreateStudent(fn, ln, classRoom))
                {
                    Console.WriteLine("Student created");
                    couldntCreateStudent = false;
                }
                else {
                    Console.WriteLine("Student wasn't created, try again.");
                }
                Console.WriteLine("Press enter to continue");
                Console.ReadKey();
            }

        }

        private void Login()
        {
            Console.WriteLine("--- Login ---");
            Console.WriteLine("Type your username: ");
            string un = Console.ReadLine();
            Console.WriteLine("Type your password: ");
            string pw = Console.ReadLine();
            if (!(MEGC.Login(un, pw) == ""))
            {
                isLoggedIn = true;
                username = un;
                this.usertype = MEGC.GetUserType(username);
                Console.WriteLine(username +" have been logged in.");
                Console.ReadKey();
            }
            else {
                Console.Clear();
                Console.WriteLine("Either the password or username was incorrect.\n");
                this.Login();
            }
        }

        private void LoginWithTeacher()
        {
            this.username = "alex01";
            this.email = "alexander2341@gmail.com";
            this.usertype = "Teacher";
            isLoggedIn = true;
        }

        private void ViewTasks()
        {
            foreach(string Task in MEGC.ViewTasks()) {

            }
        }
    }
}
