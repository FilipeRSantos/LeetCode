namespace Solutions;

//https://leetcode.com/problems/candy/
public static class Candy {    
    public static int Run(int[] ratings)
    {
        var lastAmmount = 1;
        var candies = new int [ratings.Length];
        
        for (var i = 0; i < ratings.Length; i++)
        {
            var greatherThanLeft = i > 0 ? ratings[i] > ratings[i - 1] : false;

            if (greatherThanLeft)
                lastAmmount++;
            else
                lastAmmount = 1;

            candies[i] = lastAmmount;
        }
        
        for (var i = ratings.Length - 1; i >= 0; i--)
        {
            var greatherThanRight = i < ratings.Length - 1 ? ratings[i] > ratings[i + 1] : false;

            if (!greatherThanRight) 
                continue;
            
            if (candies[i] <= candies[i + 1])
                candies[i] = candies[i + 1] + 1;
        }
        
        return candies.Sum();
    }
}