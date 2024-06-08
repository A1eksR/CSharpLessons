using Day27Md;

namespace Day27MdTest;

public class UnitTest1
{
    [Fact]
    public void TestLielako()
    {
        List<String> listTest = new List<String>();

        listTest.Add("a");
        listTest.Add("bb");
        listTest.Add("ccc");

        int expected = 3;
        int result = MD.AtgrieztGarakaGarumu(listTest);

        Assert.Equal(expected, result);
    }
}
