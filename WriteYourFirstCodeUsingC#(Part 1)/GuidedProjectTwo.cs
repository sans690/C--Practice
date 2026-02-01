using System.Runtime.ConstrainedExecution;

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

int grade1 = 4;
int grade2 = 3;
int grade3 = 3;
int grade4 = 3;
int grade5 = 4;

int gradeValue = (grade1 * course1Credit) + (grade2 * course2Credit) + (grade3 * course3Credit) + (grade4 * course4Credit) + (grade5 * course5Credit);
int creditSum = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;
decimal finalGPA = (decimal)gradeValue / creditSum;

int leadingDigit = (int)finalGPA;
int firstDigit = (int)(finalGPA * 10) % 10;
int secondDigit = (int)(finalGPA * 100) % 10;


List<int> grades = new List<int> { { grade1 }, { grade2 }, { grade3 }, { grade4 }, { grade5 } };
List<int> courseCredits = new List<int> { { course1Credit }, { course2Credit }, { course3Credit }, { course4Credit }, { course5Credit } };
List<string> courseNames = new List<string> { { course1Name }, { course2Name }, { course3Name }, { course4Name }, { course5Name } };

Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course \t\t\tGrade\t\tCredit Hours");

for (int i = 0; i < courseNames.Count; i++)
{
    Console.WriteLine($"{courseNames[i]}\t\t{grades[i]}\t\t{courseCredits[i]}");
}
Console.WriteLine($"\nFinal GPA: {leadingDigit}.{firstDigit}{secondDigit}");


