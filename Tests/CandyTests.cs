using Solutions;

namespace Tests;

public class CandyTests
{
    [Theory]
    [InlineData(new []{ 1,0,2 }, 5)]
    [InlineData(new []{ 1,2,2 }, 4)]
    [InlineData(new []{ 1,3,3,4 }, 6)]
    [InlineData(new []{ 29,51,87,87,72,12 }, 12)]
    [InlineData(new []{ 1,3,4,5,2 }, 11)]
    public void Test1(int[] ratings, int expected)
    {
        var output = Candy.Run(ratings);
        Assert.Equal(expected, output);
    }
}