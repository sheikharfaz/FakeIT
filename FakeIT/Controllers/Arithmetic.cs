using System;
using FakeIT.Repo;

namespace FakeIT.Controllers
{
    public class Arithmetic: IMath
    {
        public float Add(float a, float b)
        {
            return a + b;
        }

        public float Substract(float a, float b)
        {
            return a - b;
        }

        public float Multiply(float a, float b)
        {
            return a * b;
        }

        public float Divide(float a, float b)
        {
            return a / b;
        }

        
    }
}
