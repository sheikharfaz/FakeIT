using System;
namespace FakeIT.Repo
{
    public interface IMath
    {
        float Add(float a, float b);
        float Substract(float a, float b);
        float Multiply(float a, float b, float c);
        float Divide(float a, float b);
    }
}
