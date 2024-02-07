using Solutions;

namespace Tests;

public class CoinChangeTests
{
    [Theory]
    [InlineData(new int[]{ 1, 2, 5}, 11, 3)]
    [InlineData(new int[]{2}, 3, -1)]
    [InlineData(new int[]{1}, 0, 0)]
    public void Sample(int[] coins, int amount, int expected)
    {
        var output = CoinChange.Run(coins, amount);
        Assert.Equal(expected, output);
    }    
}
