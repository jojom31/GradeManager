using System;

namespace GradeManager
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<double> grades = new List<double>();
            Console.WriteLine("Welcome to the Grade Manager");
            while (true)
            {
                ShowMainMenu();
                int menuItem = GetMenuSelection();
                Console.Clear();
                switch (menuItem)
                {
                    case "1":
                        AddGrades();
                        break;
                    case "2":
                        EditGrades();
                        break;
                    case "3":
                        ShowGrades();
                        break;
                    case "4":
                        LowestGrades();
                        break;
                    case "5":
                        HighestGrades();
                        break;
                    case "6":
                        Exit();
                        break;

                }
                Pause();


                //
                //MainMenu();

            }


            //Console.WriteLine("Grade Manager");

            //Console.Write("Please Select a Number 1-8: ");
            //Console.ReadLine();
            //MainMenu();
        }
        static void Pause()
        {
            Console.WriteLine("Press an button to return to menu.");
            Console.ReadKey();
            Console.Clear();
        }

        static void ShowMainMenu()
        {
            string mainMenu = @"
            
            1. Add Grades
            2. Edit Grades
            3. Show Grades
            4. Lowest Grade
            5. Highest Grade
            6. Exit
Please choose a number 1-8: ";
            Console.WriteLine(mainMenu);

        }

        static int GetMenuSelection()
        {
            bool invalidEntry = true;
            int menuSelection = 0;

            do
            {
                try
                {
                    string selection = Console.ReadLine();
                    menuSelection = int.Parse(selection);
                    if (menuSelection < 0 || menuSelection > 8)
                    {
                        throw new Exception("Nope");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Entry. Please choose a number between 1-8: ");
                    invalidEntry = true;
                }
            }
            while (invalidEntry == true);
            return menuSelection;
        }

        static void AddGrades()
        {
            Console.WriteLine("Please add grade as decimal, ex.88.6 or whole number, ex 100");
            while (true)
            {
                string grade = Console.ReadLine();
            }
            

        }

        static void EditGrades()
        {
            Console.WriteLine("edit grades");
            Console.ReadLine();

        }

        static void ShowGrades()
        {
            Console.WriteLine("show grades"h);
            Console.ReadLine();
        }

        static void LowestGrades()
        {
            Console.WriteLine("highest grades");
            Console.ReadLine();
        }

        static void HighestGrades()
        {
            Console.WriteLine("Highest grades");
            Console.ReadLine();
        }

        static void Exit()
        {
            Console.WriteLine("exit");
            Console.ReadLine();
        }

        

    }
}
