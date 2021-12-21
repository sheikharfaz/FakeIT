using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FakeIT.Repo;
using FakeIT.Services;
using FakeItEasy;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FakeIT.Controllers
{
    [Route("api/[controller]")]
    public class SimpleInterestlass : Controller
    {
        private readonly IFakeIt _fakeitService;

        public SimpleInterestlass(IFakeIt fakeitService)
        {
            this._fakeitService = fakeitService;
        }
        
        [HttpGet]
        public float SI(float P, float R, float N)
        {
            IMath math = _fakeitService.FakeMathClass();

            return math.Divide(math.Multiply(P, R, N), 100);
        }
    }     
}
