using FakeIT.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeIT.Services
{
    public interface IFakeIt
    {
        IMath FakeMathClass();
    }
}
