using Solutions;

namespace Tests;

public class MinimumNumberOperationsArrayEmptyTests
{
    [Theory]
    [InlineData(new []{ 2,3,3,2,2,4,2,3,4 }, 4)]
    [InlineData(new []{ 2,1,2,2,3,3 }, -1)]
    [InlineData(new []{ 14,12,14,14,12,14,14,12,12,12,12,14,14,12,14,14,14,12,12 }, 7)]
    [InlineData(new []{ 13,7,13,7,13,7,13,13,7 }, 4)]
    public void Test1(int[] nums, int expected)
    {
        var output = MinimumNumberOperationsArrayEmpty.Run(nums);
        Assert.Equal(expected, output);
    }
}
