using System;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace Student_GPA
{
    class Program
    {
        static void Main(string[] args)
        {

            // student information
            string studentName = "Jane Doe";

            string[] courseName = { "English 101", "Algebra 101", "Biology 101", "Computer Science I", "Psychology 101" };

            int[] courseCredit = { 3, 3, 4, 4, 3 };

            int gradeA = 4;
            int gradeB = 3;

            int[] courseGrade = { gradeA, gradeB, gradeB, gradeB, gradeA };

            int totalCreditHours = 0;

            foreach (int credit in courseCredit)
            {
                totalCreditHours += credit;
            }

            int totalGradePoints = 0;
            
            //checks arrays, it then mulptiply each term then add them all
            if (courseCredit.Length == courseGrade.Length)
            {
                int sum = 0;
                for (int i = 0; i < courseCredit.Length; i++)
                {
                    int gradePoints = courseCredit[i] * courseGrade[i];
                    sum += gradePoints;
                    totalGradePoints = sum;
                }

            }
            else
            {
                Console.WriteLine($" due to missing information {studentName} please see advisdor");
            }

            decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

            int leadingDigit = (int)gradePointAverage;
            int firstDigit = (int)(gradePointAverage * 10) % 10;
            int secondDigit = (int)(gradePointAverage * 100) % 10;

            Console.WriteLine($"Strudent: {studentName}\n");
            Console.WriteLine("Course\t\t\t\t\tGrade\tCredit Hours");

            for (int i = 0; i < courseName.Length; i++)
            {
                string formattedCourseName = courseName[i].PadRight(20);
                Console.WriteLine($"{formattedCourseName}\t\t\t{courseGrade[i]}\t{courseCredit[i]}");
            }

            Console.WriteLine($"Final GPA: {leadingDigit}.{firstDigit}{secondDigit}");
    



        }
    }
}