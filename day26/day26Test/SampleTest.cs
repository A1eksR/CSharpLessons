using day26;

namespace day26Test;

public class SampleTest
{
    [Fact]
    public void GetSum()
    {
        int a = 3;
        int b = 4;

        int expected = a+b;
        int result = Sample.Sum(a, b);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void GetCombineTest()
    {
        String result = Sample.Combine("aaa", "bbb", "vvv");
        Assert.Equal("aaabbbvvv", result);
    }
}
