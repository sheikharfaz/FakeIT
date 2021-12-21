using NUnit.Framework;
using FakeItEasy;
using FakeIT.Repo;
using FakeIT.Controllers;

namespace FakeitTests
{
    public class Tests
    {
        float resultOfMultiplication;
        float resultOfDivision;

        [Test]
        [TestCase(1000,9,10)]
        public void Test1(float P, float R, float N)
        {
            var fakeMath = A.Fake<IMath>();

            
            var arithmatic = new Arithmetic();

            A.
                CallTo(() => fakeMath.Add(A<float>._, A<float>._)).Invokes(
                (float a, float b) => this.resultOfMultiplication = arithmatic.Add(a, b)
                );

            A.
                CallTo(() => fakeMath.Substract(A<float>._, A<float>._)).Invokes(
                (float a, float b) => this.resultOfMultiplication = arithmatic.Substract(a, b)
                );
            A.
                CallTo(() => fakeMath.Multiply(A<float>._, A<float>._)).Invokes(
                (float a, float b) => this.resultOfMultiplication = arithmatic.Multiply(a, b)
                );

            A.
                CallTo(() => fakeMath.Divide(A<float>._, A<float>._)).Invokes(
                (float a, float b) => this.resultOfDivision = arithmatic.Divide(a, b)
                );



            //Act
            var math = new SimpleInterestlass();

            fakeMath.Multiply(P, R);
            fakeMath.Multiply(this.resultOfMultiplication, N);

            fakeMath.Divide(this.resultOfMultiplication, 100);

            var SI = math.SI(P, R, N);


            //Assert

            Assert.AreEqual(this.resultOfDivision, SI);

            // A.
            //    CallTo(() => fakeMath.Add(A<float>._, A<float>._)).Returns(1009);

            //A.
            //    CallTo(() => fakeMath.Substract(A<float>._, A<float>._)).Returns(991);

            //A.
            //    CallTo(() => fakeMath.Multiply(A<float>._, A<float>._)).Returns(9000);

            //A.
            //    CallTo(() => fakeMath.Divide(A<float>._, A<float>._)).Returns(10);


            //
            //var addResult = math.Add(2, 2);
            //var substractResult = math.Substract(4, 2);
            //var multiplyResult = math.Multiply(2, 2);
            //var divideResult = math.Divide(4, 2);

            ////Assert
            //Assert.AreEqual(fakeMath.Add(2, 2), addResult);
            //Assert.AreEqual(fakeMath.Substract(2, 2), substractResult);
            //Assert.AreEqual(fakeMath.Multiply(2, 2), multiplyResult);
            //Assert.AreEqual(fakeMath.Divide(2, 2), divideResult);



        }
    }
}
