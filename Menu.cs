using System;
namespace taxChallenge
{
    class Menu
    {
        public Menu()
        {
            PrintMenu();
        }

        public void PrintMenu()
        {
            Console.WriteLine("Press the corrisponding number to the action you would like to take\n1. add employee\n2. view employees\n3. Quit");
    
        }
        public int GetInput()
        {
            int choice;
            Console.Write("Enter your selection: ");
            while(!int.TryParse(Console.ReadLine(),out choice)||choice<1||choice>3)
            {
                Console.WriteLine("invalid selection");
                Console.Write("Selection: ");
            }
            Console.WriteLine("");
            return choice;
        }
    }
}