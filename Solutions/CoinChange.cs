public static class CoinChange
{

    //https://leetcode.com/problems/coin-change/
    public static int Run(int[] coins, int amount)
    {
        var minimumCoins = new Dictionary<int, int>();
        minimumCoins.Add(0, 0);

        for (var i = 1; i <= amount; i++)
        {
            var currentMin = int.MaxValue;
            foreach (var coin in coins)
            {
                if (coin > i) continue;

                var difference = i - coin;
                if (minimumCoins.TryGetValue(difference, out var coinDiff))
                {
                    if (coinDiff == -1) continue;

                    currentMin = Math.Min(currentMin, coinDiff + 1);
                }
            }
            if (currentMin == int.MaxValue) currentMin = -1;
            minimumCoins.Add(i, currentMin);
        }

        return minimumCoins.Last().Value;
    }
}
