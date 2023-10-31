//using Emp;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectScores_ShouldCorrectSum1()
        {
            //arrange
            var emp1 = new Emp("Adam", "Grzyb");
            emp1.AddScore(15);
            emp1.AddScore(2);
            emp1.AddScore(1);

            //act
            var result = emp1.Result;

            //assert
            Assert.AreEqual(18, result);
        }

        [Test]
        public void WhenUserCollectScores_ShouldCorrectSum2()
        {
            //arrange
            var emp2 = new Emp("Monika", "Woda");
            emp2.AddScore(2);
            emp2.AddScore(5);
            emp2.AddScore(-9);

            //act
            var result = emp2.Result;

            //assert
            Assert.AreEqual(-2, result);
        }

        [Test]
        public void WhenUserCollectScoress_ShouldCorrectSum3()
        {
            //arrange
            var emp3 = new Emp("Zuzia", "Trawa");
            emp3.AddScore(11);
            emp3.AddScore(15);
            emp3.AddScore(1);

            //act
            var result = emp3.Result;

            //assert
            Assert.AreEqual(27, result);
        }
    }
}
