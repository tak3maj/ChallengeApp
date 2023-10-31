using Employee;

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void CompareInteger()
        {
            //arrange
            int number1 = 10101;
            int number2 = 10201;

            //act

            //assert
            Assert.Less(number1, number2);
        }

        [Test]
        public void FloatAreEqual()
        {
            //arrange
            float number1 = 910.9101f;
            float number2 = 910.9101f;

            //act

            //assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void StringAreEqual()
        {
            //arrange
            string verb1 = "run";
            string verb2 = "run";

            //act

            //assert
            Assert.AreEqual(verb1, verb2);
        }

        [Test]
        public void CompareLengthTwoWords()
        {
            //arrange
            string word1 = "storm";
            string word2 = "thunder";
            int len1 = word1.Length;
            int len2 = word2.Length;

            //act

            //assert
            Assert.AreNotEqual(len1, len2);
        }

        [Test]
        public void GetEmpShouldReturnDifferentObject()
        {
            //arrange
            var emp1 = GetEmp("Adam", "Grzyb");
            var emp2 = GetEmp("Adam", "Grzyb");

            //act

            //assert
            Assert.AreNotEqual(emp1, emp2);  
        }

        private Emp GetEmp(string name, string surname)
        {
            return new Emp(name, surname);
        }
    }
}
