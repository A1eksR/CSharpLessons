﻿using day27;

namespace day27Test;

public class UnitTest1
{
    [Fact]
    public void SearchArray()
    {
        int a = 25;
        int[] b = { 1, 3, 25, 36, 41, 51, 62 };

        ArrayTools arrayTools = new ArrayTools();

        int expected = 2;
        int result = arrayTools.SearchArray(a, b);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void FailedSearchArray()
    {
        int a = 29;
        int[] b = { 1, 3, 25, 36, 41, 51, 62 };

        ArrayTools arrayTools = new ArrayTools();

        int expected = -1;
        int result = arrayTools.SearchArray(a, b);

        Assert.Equal(expected, result);
    }
}
