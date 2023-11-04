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
            var employee = new Employee("Adam", "Grzyb");
            employee.AddGrade(20);
            employee.AddGrade(2);
            employee.AddGrade(8);

            //act
            var stat = employee.GetStatistics();
            
            //assert
            Assert.AreEqual(20, stat.Max);
        }

        [Test]
        public void TestValueOfMinimum()
        {
            //arrange
            var employee = new Employee("Adam", "Grzyb");
            employee.AddGrade(20);
            employee.AddGrade(2);
            employee.AddGrade(8);

            //act
            var stat = employee.GetStatistics();

            //assert
            Assert.AreEqual(2, stat.Min);
        }

        [Test]
        public void TestValueOfAverage()
        {
            //arrange
            var employee = new Employee("Adam", "Grzyb");
            employee.AddGrade(20);
            employee.AddGrade(3);
            employee.AddGrade(8);

            //act
            var stat = employee.GetStatistics();

            //assert
            Assert.AreEqual(Math.Round(10.33,2),Math.Round(stat.Average,2));
        }

    }
}