using Day28;

namespace Day28Test;

public class UnitTest1
{
    [Fact]
    public void TestLielako()
    {
        List<String> listTest = new List<String>();
        listTest.Add("a");
        listTest.Add("bb");
        listTest.Add("ccc");

        AtgrieztGarakoIsako atgrieztGarakoIsako = new AtgrieztGarakoIsako();

        int expected = 3;
        int result = atgrieztGarakoIsako.AtgrieztLielako(listTest);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestMazako()
    {
        List<String> listTest = new List<String>();
        listTest.Add("a");
        listTest.Add("bb");
        listTest.Add("ccc");

        AtgrieztGarakoIsako atgrieztGarakoIsako = new AtgrieztGarakoIsako();

        int expected = 1;
        int result = atgrieztGarakoIsako.AtgrieztMazako(listTest);

        Assert.Equal(expected, result);
    }
}
