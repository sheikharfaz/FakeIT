using NUnit.Framework;
using FakeItEasy;
using FakeIT.Repo;
using FakeIT.Controllers;
using FakeIT.Services;

namespace FakeitTests
{
    public class Tests
    {

        [Test]
        [TestCase(1000,9,10)]
        public void Test1(float P, float R, float N)
        {
            //Arrange
            IFakeIt fakeitService = new FakeitService();
            IMath math = fakeitService.FakeMathClass();


            //Act
            var simpleInterest = new SimpleInterestlass(fakeitService);
            var actualResult = simpleInterest.SI(P, R, N);
            var expectedResult = math.Divide(math.Multiply(P, R, N), 100);
            
            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
