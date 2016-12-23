using System;
using System.Collections.Generic;
using MEG;
using System.Globalization;
using MEGAltSolution;

namespace CLI
{
    public class Program
    {
        private string username;
        private string usertype;
        private bool isLoggedIn = false;
        private bool running;
        private string email = "";
        private MEGController MEGC  = new MEGController();

        static void Main(string[] args)
        {
            Program pr = new Program();
            pr.Run();    
        }

        public void Run() {
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
                    Console.WriteLine("7. ViewTasks()");
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
            Console.Clear();
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
                case -1:
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
                            CreateStudent();
                        }
                        if (usertype == "Student")
                        {
  
                        }
                    }
                    break;
                case 5:
                    if (isLoggedIn)
                    {
                        if (usertype == "Teacher")
                        {
                            ViewStudents();
                        }
                        if (usertype == "Student")
                        {
                            ViewTasks();
                        }
                    }
                    break;
                case 6:
                    if (isLoggedIn)
                    {
                        if (usertype == "Teacher")
                        {
                            CreateTask();
                        }
                        if (usertype == "Student")
                        {
                        }
                    }
                    break;
                case 7:
                    ViewTasks();
                        //database.FetchTeachers();      
                        break;

            }
            Console.ReadLine();
        }

        private void PrintHeadline(string headline) {
            Console.WriteLine("*-------------- "+ headline + " ---------------*");

        }

        private DateTime SetDate() {
            string dateString= Console.ReadLine();
            DateTime dDate;
            if (DateTime.TryParse(dateString, out dDate) && (DateTime.Compare(dDate, DateTime.Today) <0))
            {
                return dDate;
            }
            else
            {
                Console.WriteLine("Invalid date format or the date is before todays date, try again");
                return SetDate();
            }
        }

        private void CreateTask()
        {
            int sp;
            string description;
            string classroom;
            string type;
            string name;
            DateTime endTime;

            Console.Clear();

            Console.WriteLine("Write a name for the task:");
            name = Console.ReadLine();
            PrintHeadline("Create an assignment for the students");
            classroom = this.SelectClass();
            sp = this.SelectStudentPointValue();
            type = this.SelectTypeOfAssignment();

            Console.WriteLine("Write a description of the assignment: ");
            description = Console.ReadLine();

            Console.WriteLine("Write an enddate format: YYYY/MM/DD");
            endTime = SetDate();

            if (!MEGC.CreateTask(name, description, type, username, sp, classroom, endTime))
            {
                Console.WriteLine("Wrong input try again from the beginning");
                Console.ReadKey();
                CreateTask();
            }

        }

        private string ToTitleCase(string str)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }

        private string SelectTypeOfAssignment()
        {
            string assignmentType = "";
            Console.WriteLine("The three different types of assignments are homework, questionaire:");
            Console.WriteLine("What type of assignment are you creating?");
            do {
                assignmentType = Console.ReadLine();
                assignmentType.ToLower();
                assignmentType = this.ToTitleCase(assignmentType);             
            }
            while (("Handin" != assignmentType)
                && ("Homework" != assignmentType)
                && ("Questionnaire" != assignmentType));
            
            
            return assignmentType;
        }

        private void TaskTypes() {
            Console.WriteLine();
        }

        private int SelectStudentPointValue() {
            bool validInput = false;
            int input = 0;
      
            Console.WriteLine("Select a fixed student point value, by entering the numerial value on the left of the option: ");
            Console.WriteLine("1. 10");
            Console.WriteLine("2. 20");
            Console.WriteLine("3. 30");
            Console.WriteLine("4. 40");
            Console.WriteLine("5. 50");

            while (!validInput) {   
                int.TryParse(Console.ReadLine(), out input);
                if ((input > 0) && (input <= 5)) {
                    validInput = true;
                } else {
                    Console.WriteLine("Invalid input try again.");
                }
            }
            return input*10;

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
                PrintHeadline("Create a teacher");
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
            PrintHeadline("View tasks for a specific class");
            this.SelectClass();
        }
    }
}
