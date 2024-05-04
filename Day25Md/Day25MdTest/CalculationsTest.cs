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
        int result = Calculations.Faktorials(skaitlis);

        Assert.Equal(result, result);
    }
}
