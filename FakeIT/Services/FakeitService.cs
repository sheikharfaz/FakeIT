using FakeIT.Repo;
using FakeIT.Services;
using FakeItEasy;

public class FakeitService: IFakeIt
{
    public IMath FakeMathClass()
    {
        IMath fakeMathClass = A.Fake<IMath>();

        A
            .CallTo(() => fakeMathClass.Multiply(A<float>._, A<float>._, A<float>._)).Returns(9000);

        A
            .CallTo(() => fakeMathClass.Divide(9000, 100)).Returns(90);

        return fakeMathClass;
    }
    
}
