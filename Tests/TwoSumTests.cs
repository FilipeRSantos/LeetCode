using Solutions;

namespace Tests;

public class TwoSumTests
{
    [Theory]
    [InlineData(new []{ 2,7,11,15 }, 9, new []{ 0,1 })]
    [InlineData(new []{ 3,2,4 }, 6, new []{ 1,2 })]
    [InlineData(new []{ 3,3 }, 6, new []{ 0,1 })]
    [InlineData(new []{ -3,4,3,90 }, 0, new []{ 0,2 })]
    public void Test1(int[] nums, int target, int[] expected)
    {
        var received = TwoSum.Run(nums, target);
        Assert.Equal(received.Order(), expected.Order());
    }
}