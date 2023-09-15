using System;

namespace Unit02_06_StudentGradingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalAssignments = 5;

            int[] sophiaGrades = {90,86,87,98,100,94,90};
            int[] andrewGrades = {92,89,81,96,90,89};
            int[] emmaGrades = {90,85,87,98,68,89,89,89};
            int[] loganGrades = {90,95,87,88,96,96};
            string[] students = { "Sophia", "Andrew", "Emma", "Logan" };
            int[][] grades = {sophiaGrades,andrewGrades,emmaGrades,loganGrades};

            Console.WriteLine("Student\t\tGrade\n");

            foreach(string student in students)
            {
                //int ender = Array.IndexOf(students, student);
                int[] currentStudentGrades = grades[Array.IndexOf(students, student)];
                double gradeTotal = 0;
                string letterGrade = "";
                int assignmentCounter = 0;
                foreach(int grade in currentStudentGrades)
                {  
                    if(assignmentCounter < totalAssignments)
                        { 
                            gradeTotal+=grade;
                            //DEBUG Console.WriteLine("Regular Assignment!");
                        }
                    else { 
                            //DEBUG Console.WriteLine("Extra Credit!");
                            gradeTotal+=(grade/10); 
                        }
                    assignmentCounter++;
                }
                double gradeAverage = gradeTotal / totalAssignments;

                if(gradeAverage > 97) { letterGrade = "A+"; }
                else if(gradeAverage > 93) { letterGrade = "A"; }
                else if(gradeAverage > 90) { letterGrade = "A-"; }
                else if(gradeAverage > 87) { letterGrade = "B+"; }
                else if(gradeAverage > 83) { letterGrade = "B"; }
                else if(gradeAverage > 80) { letterGrade = "B-"; }
                else if(gradeAverage > 77) { letterGrade = "C+"; }
                else if(gradeAverage > 73) { letterGrade = "C"; }
                else if(gradeAverage > 70) { letterGrade = "C-"; }
                else if(gradeAverage > 67) { letterGrade = "D+"; }
                else if(gradeAverage > 63) { letterGrade = "D"; }
                else if(gradeAverage > 60) { letterGrade = "D-"; }
                else { letterGrade = "F"; }

                Console.WriteLine($"{student}:\t\t{gradeAverage}\t{letterGrade}");


            }
        }
    }
}
