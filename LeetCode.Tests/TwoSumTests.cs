using LeetCode.Solutions;

namespace LeetCode;

public class UnitTest1
{
    [Theory]
    [InlineData(new int[]{ 2,7,11,15 }, 9, new int[]{ 0,1 })]
    [InlineData(new int[]{ 3,2,4 }, 6, new int[]{ 1,2 })]
    [InlineData(new int[]{ 3,3 }, 6, new int[]{ 0,1 })]
    [InlineData(new int[]{ -3,4,3,90 }, 0, new int[]{ 0,2 })]
    public void Test1(int[] nums, int target, int[] expected)
    {
        var received = TwoSum.Run(nums, target);
        Assert.Equal(received.Order(), expected.Order());
    }
}