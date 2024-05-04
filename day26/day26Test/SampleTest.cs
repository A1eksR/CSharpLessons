using day26;

namespace day26Test;

public class SampleTest
{
    [Fact]
    public void AtgrieztList()
    {
        int a = 3;
        int b = 9;

        List<int> exp = new List<int>();
        exp.Add(3);
        exp.Add(4);
        exp.Add(5);
        exp.Add(6);
        exp.Add(7);
        exp.Add(8);
        exp.Add(9);

        List<int> expected = new List<int>(exp);
        List<int> result = Uzdevums.AtgrieztList(a, b);

        Assert.Equal(expected, result);
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
