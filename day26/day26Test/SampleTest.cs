using day26;

namespace day26Test;

public class SampleTest
{
    [Fact]
    public void AtgrieztList_lielaksB()
    {
        int a = 3;
        int b = 9;

        List<int> exp = new List<int>
        {
            3,
            4,
            5,
            6,
            7,
            8,
            9
        };

        List<int> result = Uzdevums.AtgrieztList(a, b);

        Assert.Equal(exp, result);
        
    }

    [Fact]
    public void AtgrieztList_lielaksA()
    {
        int a = 9;
        int b = 3;

        List<int> exp = new List<int>
        {
            3,
            4,
            5,
            6,
            7,
            8,
            9
        };

        List<int> result = Uzdevums.AtgrieztList(a, b);

        Assert.Equal(exp, result);

    }

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
