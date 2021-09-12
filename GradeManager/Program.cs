using System;

namespace GradeManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Grade Manager");

            //Console.Write("Please Select a Number 1-8: ");
            //Console.ReadLine();
            MainMenu();
        }
        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to My Grade Manager!");
            Console.WriteLine("1. Add Grades");
            Console.WriteLine("2. Edit Grades");
            Console.WriteLine("3. Show Grades");
            Console.WriteLine("4. Lowest Grade");
            Console.WriteLine("5. Highest Grade");
            Console.WriteLine("6. Exit");

            string myMenu = Console.ReadLine();

            switch (myMenu)
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


            //
            MainMenu();
        }

        static void AddGrades()
        {
            Console.WriteLine("Please add grade");
            int grade = int.Parse(Console.ReadLine());
            Console.WriteLine(grade);
            Console.ReadLine();

        }

        static void EditGrades()
        {
            Console.WriteLine("edit grades");
            Console.ReadLine();

        }

        static void ShowGrades()
        {
            Console.WriteLine("show grades");
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
