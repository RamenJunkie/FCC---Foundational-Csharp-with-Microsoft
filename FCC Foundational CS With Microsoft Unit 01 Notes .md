# Foundational C# with Microsoft

## Unit 1 - Write Your First Code Using C#

### Section 1 - Hello World

```C#
Console.WriteLine("Hello World!");
// Console.WriteLine("Hello World!");
// This is a Comment

Console.Write("Congratulations!");
Console.Write(" ");
Console.WriteLine("You wrote your first lines of code.");
Console.Write("Congratulations!");
Console.Write(" ");
Console.WriteLine("You wrote your first lines of code.");
// New Line happens after the line with WriteLine


Console.WriteLine("This is the first line.");
Console.WriteLine("This is the second line.");
```

### Section 2 - Variables and Data Types

```c#
// Double Quotes for Strings
Console.WriteLine("Hello World");
// Single quotes for single char
Console.WriteLine('b');
// no quotes for numbers
Console.WriteLine(123);
// Float - Fixed Fraftional Values
Console.WriteLine(0.25F);
// Double Literal
Console.WriteLine(2.625);
// Decimal Literal - Decimal Numbers
Console.WriteLine(12.39816m);
// Bools
Console.WriteLine(true);
Console.WriteLine(false);
```

```
Float Type    Precision
----------------------------
float         ~6-9 digits
double        ~15-17 digits
decimal        28-29 digits
```

Here are some coding conventions for variables:

- Variable names should use **camel case**, which is a  style of writing that uses a lower-case letter at the beginning of the  first word and an upper-case letter at the beginning of each subsequent  word. For example, `string thisIsCamelCase;`.
- Variable names should begin with an alphabetical letter. Developers  use the underscore for a special purpose, so try to not use that for  now.
- Variable names should be descriptive and meaningful in your app.  Choose a name for your variable that represents the kind of data it will hold.
- Variable names should be one or more entire words appended together. Don't use contractions or abbreviations because the name of the  variable (and therefore, its purpose) may be unclear to others who are  reading your code.
- Variable names shouldn't include the data type of the variable. You might see some advice to use a style like `string strValue;`. That advice is no longer current.

More Classic Style 

```c#
string firstName = "Bob";
Console.WriteLine(firstName);
firstName = "Liem";
Console.WriteLine(firstName);
firstName = "Isabella";
Console.WriteLine(firstName);
firstName = "Yasmin";
Console.WriteLine(firstName);
```

Implicit Variables

```c#
var message = "Hello world!";
```

Detect Type but can't be changes afterwards.   Must be initialized upon declaration.

Exercise code:

```c#
string name = "Bob";
int messages = 3;
double temperature = 34.4;

Console.Write("Hello, ");
Console.Write(name);
Console.Write("! You have ");
Console.Write(messages);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(temperature);
Console.WriteLine(" celsius.");
```

### Section 3 - Basic String Formatting

```c#
// New Line
Console.WriteLine("Hello\nWorld!");
// Tab
Console.WriteLine("Hello\tWorld!");
// Escape Quotes
Console.WriteLine("Hello \"World\"!");
// Escape slashes
Console.WriteLine("c:\\source\\repos");
```

Example:

```c#
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");	
```

Verbatim String Example, add @

```C#
Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");
```

```C#
Console.Write(@"c:\invoices");
```

Escaped Unicode Example:

```C#
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");
```

String Concatenation uses + like other languages.

```C#
string firstName = "Bob";
string message = "Hello " + firstName;
Console.WriteLine(message);

string firstName = "Bob";
string greeting = "Hello";
string message = greeting + " " + firstName + "!";
Console.WriteLine(message);

string firstName = "Bob";
string greeting = "Hello";
Console.WriteLine(greeting + " " + firstName + "!");
```

You can also use String Interpolation	$ before the quotes (like f strings) and {} for Variables

```C#
string firstName = "Bob";
string greeting = "Hello";
string message = $"{greeting} {firstName}!";
Console.WriteLine(message);

int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}!");

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");
```

Challenge Exercise:

```C#
string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine("View English output:");
Console.WriteLine($@"  c:\Exercise\{projectName}\data.txt");
Console.WriteLine("");
Console.WriteLine(russianMessage);
Console.WriteLine($@"  c:\Exercise\{projectName}\ru-RU\data.txt");
```

### Section 4 - Basic Mathematical Operations

Addition vs Cancatonating

```C#
// Addtion
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);
// Versus Concatonation
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");
// Or 
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
// Use Parenthesis to make them add
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

// Outputs
// 19
// Bob sold 7 widgets.
// Bob sold 77 widgets.
// Bob sold 14 widgets.
```

Other Operators are expected

```C#
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);
```

If inputs are both ints, the division is rounded,

```C#
// Ints
int quotient = 7 / 5;
Console.WriteLine("Quotient: " + quotient);
// Versus Decimals
decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");
```

Variables can also be cast to different types. For example:

```C# 
int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);
```

C# Supports the Modulus Operator

```C#
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");
```

C# follows the same order as PEMDAS except for exponents. While there's no exponent operator in C#, you can use the [System.Math.Pow](https://learn.microsoft.com/en-us/dotnet/api/system.math.pow) method. The module "Call methods from the .NET Class Library using C#" will feature this method and others.

Example

```C#
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);
```

Incrementing Values Works as expected (and like C/C++)

```C#
int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);

// First increment: 2
// Second increment: 3
// Third increment: 4
// First decrement: 3
// Second decrement: 2
// Third decrement: 1
```

This can also be done before and after the values for order of display vs operation

```C#
int value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine("Second: " + value++);
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));

// First: 2
// Second: 2
// Third: 3
// Fourth: 4
```

Challenge Exercise, Fahrenheit to Celsius

```C#
int fahrenheit = 94;
var celsius = ((float)fahrenheit - 32)*(5.0/9);
Console.WriteLine($@"The temperature is {celsius} Celsius");
```

###  Guided Project - Calculate and Print Student Grades 

## Project overview

You're developing a Student Grading application that automates the  calculation of current grades for each student in a class. The  parameters for your application are:

- You're given a short list of four students and their five assignment grades.
- Each assignment grade is expressed as an integer value, 0-100, where 100 represents 100% correct.
- Final scores are calculated as an average of the five assignment scores.
- Your application needs to perform basic math operations to calculate the final grades for each student.
- Your application needs to output/display each student’s name and final score.

Currently, the teachers grade book shows the graded assignments for each student as follows:

``` 
Sophia: 93, 87, 98, 95, 100
Nicolas: 80, 83, 82, 88, 85
Zahirah:   84, 96, 73, 85, 79
Jeong:  90, 92, 98, 100, 97
```

```
Student     Grade
Sophia      94.6  A
Nicolas     83.6  B
Zahirah     83.4  B
Jeong       95.4  A
```

My Solution, which is super ugly because no loops or if/else going on.  Hardcode the letters?  Really?

```C#
// initialize variables - graded assignments 
var currentAssignments = 5.0;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

var sophiaAverage = (sophia1 + sophia2 + sophia3 + sophia4 + sophia5)/currentAssignments;
var nicolasAverage = (nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5)/currentAssignments;
var zahirahAverage = (zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5)/currentAssignments;
var jeongAverage = (jeong1 + jeong2 + jeong3 + jeong4 + jeong5)/currentAssignments;

Console.WriteLine("Student\t\tGrade");
Console.WriteLine($"Sophia\t\t{sophiaAverage}\tA");
Console.WriteLine($"Nicolas\t\t{nicolasAverage}\tB");
Console.WriteLine($"Zahirah\t\t{zahirahAverage}\tB");
Console.WriteLine($"Jeong\t\t{jeongAverage}\tA");
```

### Guided Project - Calculate Final GPA

## Project overview

You're developing a Student GPA Calculator that will help calculate  students' overall Grade Point Average. The parameters for your  application are:

- You're given the student's name and class information.
- Each class has a name, the student's grade, and the number of credit hours for that class.
- Your application needs to perform basic math operations to calculate the GPA for the given student.
- Your application needs to output/display the student’s name, class information, and GPA.

To calculate the GPA:

- Multiply the grade value for a course by the number of credit hours for that course.
- Do this for each course, then add these results together.
- Divide the resulting sum by the total number of credit hours.

You're provided with the following sample of a student's course information and GPA:

```C#
Student: Sophia Johnson

Course          Grade   Credit Hours	
English 101         4       3
Algebra 101         3       3
Biology 101         3       4
Computer Science I  3       4
Psychology 101      4       3

Final GPA:          3.35
```

Setup Vars

```C#
string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;
```

This result is slightly more guided and less self done than the previous, and it's just as janky without proper code mechanics.

```C#
// WTF Is this method, surely there is a formatting method
// There was some nonsense about using ints for format a float
// It's just adding :0.00 tot he flaot ie {myfloat:0.00}

string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4;
int gradeB = 3;
//int gradeC = 2;
//int gradeD = 1;
//int gradeF = 0;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

var totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

var totalGradePoints = course1Grade*course1Credit;
totalGradePoints += course2Grade*course2Credit;
totalGradePoints += course3Grade*course3Credit;
totalGradePoints += course4Grade*course4Credit;
totalGradePoints += course5Grade*course5Credit;

var finalGPA = (float)totalGradePoints/totalCreditHours;
// DEBUG Console.WriteLine($"{totalGradePoints} {totalCreditHours}");

Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course          Grade   Credit Hours");
Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");
Console.WriteLine($"\nFinal GPA:\t\t\t{finalGPA:0.00}");

```

End of Notes for Unit 1





















 















