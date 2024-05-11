using day27;

namespace day27Test;

public class UnitTest1
{
    [Fact]
    public void SearchArray()
    {
        int a = 2;
        int[] b = { 0,1,2,3,4,5,6 };

        ArrayTools arrayTools = new ArrayTools();

        int expected = 2;
        int result = arrayTools.SearchArray(a, b);

        Assert.Equal(expected, result);
    }
}
