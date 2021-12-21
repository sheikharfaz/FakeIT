using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FakeIT.Repo;
using FakeItEasy;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FakeIT.Controllers
{
    [Route("api/[controller]")]
    public class SimpleInterestlass : Controller
    {

        //float resultOfMultiplication;
        //float resultOfDivision;

        // GET: api/values
        [HttpGet]
        public float SI(float P, float R, float N)
        {
            
            //var fakeMath = A.Fake<IMath>();
            //var arithmatic = new Arithmetic();

            //A.
            //    CallTo(() => fakeMath.Add(P, R)).Returns(P + R);

            //A.
            //    CallTo(() => fakeMath.Substract(P, R)).Returns(P - R);
            //A.
            //    CallTo(() => fakeMath.Multiply(A<float>._, A<float>._)).Invokes(
            //    (float a, float b) => this.resultOfMultiplication = arithmatic.Multiply(a, b)
            //    );

            //A.
            //    CallTo(() => fakeMath.Divide(A<float>._, A<float>._)).Invokes(
            //    (float a, float b) => this.resultOfDivision = arithmatic.Divide(a, b)
            //    );
            //fakeMath.Multiply(P, R);
            //fakeMath.Multiply(this.resultOfMultiplication, N);

            //fakeMath.Divide(this.resultOfMultiplication, 100);

            //return this.resultOfDivision;

            return (P * R * N) / 100;
        }
    }     
}
