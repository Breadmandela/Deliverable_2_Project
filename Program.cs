/*
 * Author: Christian Nielsen
 * Date: 1/28/19
 * Comments: This is an app which will ask for a user input and give a defined output to 
 * demonstrate conditional statements.
 */

using System;

namespace Deliverable_2_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instuct the user to make an input
            Console.WriteLine("What grade do you expect to achieve in ISM 4300?");
            Console.WriteLine("Please enter a grade from 1-100 percent below...");

            //Use a try catch statement to handle any user errors.
            try
            {
                //This variable will take the user input
                string input = Console.ReadLine();

                //This variable will store the percentgrade and parse it to an integer
                int PercentGrade = int.Parse(input);

                //This variable will be used to display the corresponding letter grade
                string LetterGrade = ("F");

                //The following if else statements will display the corresponding lettergrade.
                if (PercentGrade >= 98 && PercentGrade <= 100)
                {
                    LetterGrade = ("A+");
                    Console.WriteLine("This grade would give you an" + " " + (LetterGrade));
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (PercentGrade >= 92 && PercentGrade <= 97)
                {
                    LetterGrade = ("A");
                    Console.WriteLine("This grade would give you an" + " " + (LetterGrade));
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (PercentGrade >= 90 && PercentGrade <= 91)
                {
                    LetterGrade = ("A-");
                    Console.WriteLine("This grade would give you an" + " " + (LetterGrade));
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (PercentGrade >= 88 && PercentGrade <= 89)
                {
                    LetterGrade = ("B+");
                    Console.WriteLine("This grade would give you an" + " " + (LetterGrade));
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (PercentGrade >= 82 && PercentGrade <= 87)
                {
                    LetterGrade = ("B");
                    Console.WriteLine("This grade would give you an" + " " + (LetterGrade));
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (PercentGrade >= 80 && PercentGrade <= 81)
                {
                    LetterGrade = ("B-");
                    Console.WriteLine("This grade would give you an" + " " + (LetterGrade));
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (PercentGrade >= 78 && PercentGrade <= 79)
                {
                    LetterGrade = ("C+");
                    Console.WriteLine("This grade would give you an" + " " + (LetterGrade));
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (PercentGrade >= 72 && PercentGrade <= 77)
                {
                    LetterGrade = ("C");
                    Console.WriteLine("This grade would give you an" + " " + (LetterGrade));
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (PercentGrade >= 70 && PercentGrade <= 71)
                {
                    LetterGrade = ("C-");
                    Console.WriteLine("This grade would give you an" + " " + (LetterGrade));
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (PercentGrade >= 68 && PercentGrade <= 69)
                {
                    LetterGrade = ("D+");
                    Console.WriteLine("This grade would give you an" + " " + (LetterGrade));
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (PercentGrade >= 62 && PercentGrade <= 67)
                {
                    LetterGrade = ("D");
                    Console.WriteLine("This grade would give you an" + " " + (LetterGrade));
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (PercentGrade >= 60 && PercentGrade <= 61)
                {
                    LetterGrade = ("D");
                    Console.WriteLine("This grade would give you an" + " " + (LetterGrade));
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (PercentGrade >= 1 && PercentGrade <= 60)
                {
                    LetterGrade = ("F");
                    Console.WriteLine("This grade would give you an" + " " + (LetterGrade));
                    Console.WriteLine("Try Harder next time...");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (PercentGrade >= 200)
                {
                    Console.WriteLine("Please use an integer value (1-100) for the grade you expect to receive");
                    Console.WriteLine("Press any key to exit the program and try again.");
                    Console.ReadKey(true);
                }
                else if (PercentGrade <= 0)
                {
                    Console.WriteLine("Please use an integer value (1-100) for the grade you expect to receive");
                    Console.WriteLine("Press any key to exit the program and try again.");
                    Console.ReadKey(true);
                }
            }
            //The catch statement will catch any user errors and give users instructions on how
            //to correct their error.
            catch
            {
                //User instuctions and error message
                Console.WriteLine("Please use an integer value (1-100) for the grade you expect to receive");
                Console.WriteLine("Press any key to exit the program and try again.");
                Console.ReadKey(true);
            }//End of catch Statement
        }
    }
}
