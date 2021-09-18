using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeManager
{
    class Program
    {
        static void Main(string[] args)
        {

            List<double> grades = new List<double>();
            Console.WriteLine("Welcome to the Grade Manager");
            while (true)
            {
                ShowMainMenu();
                int menuItem = GetMenuSelection();
                Console.Clear();
                switch (menuItem)
                {
                    case 1:
                        Console.Clear();
                        grades.Add(AddGrades());
                        Console.WriteLine("Your Grade is added");
                        break;
                    case 2:
                        EditGrades(grades);
                        break;
                    case 3:
                        ShowGrades(grades);
                        break;
                    case 4:
                        LowestGrades();
                        break;
                    case 5:
                        HighestGrades();
                        break;
                    case 6:
                        ClassAverage();
                        break;
                    case 7:
                        DeleteGrade();
                        break;
                    case 8:
                        return;
                    default:
                        continue;
                        

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
6. Class Average
7. Delete Grade
8. Exit
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
                catch (Exception)
                {
                    Console.WriteLine("Invalid Entry. Please choose a number between 1-8: ");
                    invalidEntry = true;
                }
            }
            while (invalidEntry == true);
            return menuSelection;
        }

        static double AddGrades()
        {
            Console.WriteLine("Please add grade as decimal, ex.88.6 or whole number, ex 100");
            while (true)
            {
                string grade = Console.ReadLine();
                try
                {
                    return double.Parse(grade);
                }
                catch(Exception)
                {
                    Console.WriteLine("Please enter in a grade.");
                    continue;
                }
            }
            

        }

        static void EditGrades(List<double> grades)
        {
            Console.WriteLine("edit grades");
            Console.ReadLine();

        }

        static void ShowGrades(List<double> grades)
        {
            if (IsGradeEmpty(grades))
            {
                return;
            }
            int i = 0;
            foreach(var grade in grades)
            {
                string message = "Student " + i.ToString() + " : " + grade;
                Console.WriteLine($"Student {i} :  {grade}");
                i++;
            }
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

        static void ClassAverage()
        {
            Console.WriteLine("exit");
            Console.ReadLine();
        }

        static void DeleteGrade()
        {
            Console.WriteLine("exit");
            Console.ReadLine();
        }

        static bool IsGradeEmpty(List<double> grades)
        {
            if (grades.Count == 0)
            {
                Console.WriteLine("No Grades, please add a grade");
                return true;
            }
            return false;
        }



    }
}
