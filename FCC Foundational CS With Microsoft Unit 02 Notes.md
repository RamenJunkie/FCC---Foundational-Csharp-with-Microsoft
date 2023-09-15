# Foundational C# with Microsoft

## Unit 2 - Create and Run Simple C# Console Applications

### Section 1 - Setup VC Code and Create Simple Sample Project

Several simple steps.

* Install DotNet
* Install VS Code
* Install C# Dev Extension
* Create First App with these commands

```Terminal
//Create new project and folder (name as desired)
dotnet new console -o ./CsharpProjects/TestProject
// This creates a folder with basic structure, can edit the cs file as needed.

// Create binaries
dotnet build

// Run File
dotnet run
```

### Section 2 - Call methods from the .NET Class Library

A basic 1d6 Dice Roll

```C#
            //Console.WriteLine("Hello C#!");
            //Create new Random Object
            Random dice = new Random();
            //Next is used to refresh the random seed
            int roll = dice.Next(1, 7);
            //Write out the Roll
            Console.WriteLine(roll);
```

Some other Dice Roll ways

```C#
Random dice = new Random();
// First has boundary of 0 to 2,147,483,647
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
```

With Sample Output

```
First roll: 342585470
Second roll: 43
Third roll: 89
```

More Info on Microsoft Learn. <https://learn.microsoft.com/en-us/dotnet/api/system.random.next>

### Section 3 - If/Else Statements

An example given with some useful other stuff.

```C#
string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}
```

.Contains("Words") - super useful.
also a basic if statement.

Operators are as expected, ==, <=, >=, <, >

Logical operators as expected, && (and) || (or)

The chaining is:
if
else if
else

### Section 4 - Arrays and Loops

Initialize and array for 3 elements.

```C#
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");
```

Reassign like any variable

fraudulentOrderIDs[0] = "F000";

Can also be inilialized with values.

string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

Get the length of an array

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

FOR LOOPS

```C#
string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
    Console.WriteLine(name);
}
```

A Side Concept.  Check the first letter of a string, returns a bool.

String.StartsWith("B")

Example

```C#
string name = "Bob";
if (name.StartsWith("B"))
{
    Console.WriteLine("The name starts with 'B'!");
}
```

### Section 5 - Clean Code

This section is all about commenting and variable conventions.  No notes for this section.

### Section 6 - Student Grading Application

Starting to get a bit ambitious here, because I hate how it's handling things like, lists of grades with a bunch of numbered variables.  I'm sure it'll get to it eventually, but I'm researching ahead.  This meant figuring out how to make nested lists, and how to get the index of things in lists.  And it's probably not perfect, because my research suggests there are lists AND arrays, for some dumb reasons, but it's still much closer to being elegant.

I wanted to do somethin clever with indexes and lists on the grades but the spacing is not regular so it would not work.

The desired result, with added Extra Credit section is:

```C#
Student         Grade

Sophia          95.8    A      
Andrew          91.2    A-     
Emma            90.4    A-     
Logan           93      A      
```

My end code is this:

```C#
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

```

### Section 6 - Student Grading Application V2

This section takes the previous exercise and updates the code to split regular scores from Extra Credit.

Desired Output:

```C#
Student         Exam Score      Overall Grade   Extra Credit

Sophia          92.2            95.88   A       92 (3.68 pts)
Andrew          89.6            91.38   A-      89 (1.78 pts)
Emma            85.6            90.94   A-      89 (5.34 pts)
Logan           91.2            93.12   A       96 (1.92 pts)
```

My Output, i am not sure why the calculations seem off, because they should not be based ont he described text.

```C#
Student         Exam Scored     Overall Grade   Extra Credit

Sophia:         92.2            95.8    A-      (3.6 pts)
Andrew:         89.6            91.2    B+      (1.6 pts)
Emma:           85.6            90.4    B       (4.8 pts)
Logan:          91.2            93      A-      (1.8 pts)
```

My completed Code:

```C#
int totalAssignments = 5;

int[] sophiaGrades = {90,86,87,98,100,94,90};
int[] andrewGrades = {92,89,81,96,90,89};
int[] emmaGrades = {90,85,87,98,68,89,89,89};
int[] loganGrades = {90,95,87,88,96,96};
string[] students = { "Sophia", "Andrew", "Emma", "Logan" };
int[][] grades = {sophiaGrades,andrewGrades,emmaGrades,loganGrades};

Console.WriteLine("Student\t\tExam Scored\tOverall Grade\tExtra Credit\n");

foreach(string student in students)
{
    //int ender = Array.IndexOf(students, student);
    int[] currentStudentGrades = grades[Array.IndexOf(students, student)];
    double gradeTotal = 0;
    double extraCreditTotal = 0;
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
                extraCreditTotal+=(grade/10); 
            }
        assignmentCounter++;
    }
    double gradeAverage = gradeTotal / totalAssignments;
    double extraCreditAverage = (gradeTotal+extraCreditTotal) / totalAssignments;

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

    Console.WriteLine($"{student}:\t\t{gradeAverage}\t\t{extraCreditAverage}\t{letterGrade}\t({extraCreditTotal/totalAssignments} pts)");


}
```
