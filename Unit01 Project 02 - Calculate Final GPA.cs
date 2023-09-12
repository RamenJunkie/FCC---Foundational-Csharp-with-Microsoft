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
