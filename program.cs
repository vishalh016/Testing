
using GradesCalculator;

//Console.WriteLine("Hello, World!");
var s = new StudentGrades();
Console.WriteLine("Enter Percentage");
var p=Convert.ToInt32(Console.ReadLine());
var g=s.CalculateGrade(p);
Console.WriteLine("Student's Grade: "+g);
