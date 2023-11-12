using ChallengeApp;
using System.Diagnostics;

namespace Empl.Tests
{
    public class Tests
    {
        [Test]
        public void TestValueOfMaximum()
        {
            //arrange
            var employee = new Employee();
            employee.AddGrade(20);
            employee.AddGrade(3);
            employee.AddGrade(8);
            employee.AddGrade('a');

            //act
            var stat = employee.GetStatistics();
            
            //assert
            Assert.AreEqual(100, stat.Max);
        }

        [Test]
        public void TestValueOfMinimum()
        {
            //arrange
            var employee = new Employee();
            employee.AddGrade(20);
            employee.AddGrade(3);
            employee.AddGrade(8);
            employee.AddGrade('a');

            //act
            var stat = employee.GetStatistics();

            //assert
            Assert.AreEqual(3, stat.Min);
        }

        [Test]
        public void TestValueOfAverage()
        {
            //arrange
            var employee = new Employee();
            employee.AddGrade(20);
            employee.AddGrade(3);
            employee.AddGrade(8);
            employee.AddGrade('a');

            //act
            var stat = employee.GetStatistics();

            //assert
            Assert.AreEqual(Math.Round(32.75,2),Math.Round(stat.Average,2));
        }
        [Test]
        public void TestValueOfEmployeeEvaluation()
        {
            //arrange
            var employee = new Employee();
            employee.AddGrade(20);
            employee.AddGrade(3);
            employee.AddGrade(8);
            employee.AddGrade('a');

            //act
            var stat = employee.GetStatistics();

            //assert
            Assert.AreEqual('D', stat.AverageLetter);
        }
    }
}