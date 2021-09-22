using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClassRoom math = new ClassRoom("Math");
            //Console.Write(math);

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
                        LowestGrades(grades);
                        break;
                    case 5:
                        HighestGrades(grades);
                        break;
                    case 6:
                        ClassAverage(grades);
                        break;
                    case 7:
                        DeleteGrade(grades);
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
            Console.WriteLine("Press any button to return to menu.");
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
                catch (Exception )
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
                catch (Exception )
                {
                    Console.WriteLine("Please enter in a grade.");
                    continue;
                }
            }


        }

        static void EditGrades(List<double> grades)
        {
            if (IsGradeEmpty(grades))
            {
                return;
            }
            ShowGrades(grades);
            Console.WriteLine("Edit Grades Type and Use a comma to separate the student ID and  grade ");
            Console.WriteLine("Ex. 1, 88");
            Console.WriteLine("Press e to exit");
            
            while (true)
            {
                string edit = Console.ReadLine();
                if (edit == "e") break;
                try
                {
                    string[] editSplit = edit.Split(",");
                    string student = editSplit[0];
                    string grade = editSplit[1];
                    int studentId = int.Parse(student);
                    double gradeDouble = double.Parse(grade);
                    grades[studentId] = gradeDouble;
                    Console.WriteLine("Your Grade has been updated");
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Student or grade is not valid");
                    continue;
                }
            }
        }

        static void ShowGrades(List<double> grades)
        {
            if (IsGradeEmpty(grades))
            {
                return;
            }
            int i = 1;
            foreach (var grade in grades)
            {
                string message = "Student " + i.ToString() + " : " + grade;
                Console.WriteLine($"Student {i} :  {grade}");
                i++;
            }
        }

        static void LowestGrades(List<double> grades)
        {
            if (IsGradeEmpty(grades))
            {
                return;
            }
            Console.WriteLine($"Lowest Grade:  {grades.Min()}");
        }

        static void HighestGrades(List<double> grades)
        {
            if (IsGradeEmpty(grades))
            {
                return;
            }
            Console.WriteLine($"Highest Grade:  {grades.Max()}");
        }

        static void ClassAverage(List<double> grades)
        {
            if (IsGradeEmpty(grades))
            {
                return;
            }
            Console.WriteLine($"Class average: {grades.Average()}");
        }   
        

        static void DeleteGrade(List<double> grades)
        {
            if (IsGradeEmpty(grades))
            {
                return;
            }
            ShowGrades(grades);
            Console.WriteLine("Select the grade you would like to remove by typing the student id # or press e to exit");
            Console.WriteLine("Ex. remove student by pressing 1 and enter");

            while (true)
            {
                string student = Console.ReadLine();
                if (student == "e") break;
                try
                {
                    int studentId = int.Parse(student);
                    grades.RemoveAt(studentId);
                    Console.WriteLine("Student has been removed");
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter a valid student");
                    continue; 
                }
            }
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
