using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesCalculator
{
    public class StudentGrades
    {
        public string CalculateGrade(int a)
        {
            if (a >= 90 && a < 101)
                return "A";
            else if (a >= 75 && a < 90)
                return "B";
            else if (a >= 60 && a < 75)
                return "C";
            else if (a >= 45 && a < 60)
                return "D";
            else if (a >= 0 && a < 45)
                return "F";
            else
                return "Invalid";
        }
    }
}
