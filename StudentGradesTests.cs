using NUnit.Framework;

namespace GradesCalculator.nUnitTests
{
    public class StudentGradesTests
    {
        private StudentGrades _studentGrades { get; set; } = null!;
        [SetUp]
        public void Setup()
        {
            _studentGrades = new StudentGrades();
        }

        [Test]
        public void GetGradeByPercentage_EqualTest()
        {
            //Assign
            var p = 99;
            //act
            var g = _studentGrades.CalculateGrade(p);
            //assert
            Assert.AreEqual("A", g);
        }
    }
}
