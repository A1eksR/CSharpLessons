using Day25Md;
using Day25MdTest;

namespace Day25MdTest;

public class CalculationsTest
{
    [Fact]
    public void FaktorialsTest()
    {
        int a = 3;

        int expected = 6;
        int result = Calculations.Faktorials(a);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void KapinasanasTest()
    {
        int a = 3;
        int b = 3;

        int expected = 27;
        int result = Calculations.Kapinasana(a, b);

        Assert.Equal(expected, result);
    }
}
