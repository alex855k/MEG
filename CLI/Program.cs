using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI
{
    public class Program
    {
        public bool running;

        static void Main(string[] args)
        {
            Application app = new Application();

        }

        public void Run() {
            running = true;
            while (running) {
                Menu();

            }
        }

        public void Menu() {
            Console.WriteLine("Options:");
            Console.WriteLine("1. CreateTeacher()");
            Console.WriteLine("1. CreateStudent()");

            int option = int.TryParse(Console.ReadLine(), out);

            switch (option) {
                case 1: CreateTeacher()
                    break;
                case 2: CreateStudent()
                    break;
                case 3: Login()
                    break;
                case 4: 
                    break;


            }
        }

        private void CreateTeacher()
        {
            
        }

        private void CreateStudent()
        {
            throw new NotImplementedException();
        }
    }
}
