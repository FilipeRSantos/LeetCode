namespace Solutions;

//https://leetcode.com/problems/minimum-number-of-operations-to-make-array-empty
public static class MinimumNumberOperationsArrayEmpty {
    public static int Run(int[] nums)
    {
        Dictionary<int, int> repetitions = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (repetitions.TryGetValue(num, out var count))
            {
                repetitions[num] += 1;    
            }
            else
            {
                repetitions.Add(num,  1);
            }
        }

        var acc = 0;
        foreach (var num in repetitions)
        {
            var timesBy3 = Math.DivRem(num.Value, 3, out var remainderBy3);
            if (remainderBy3 == 0)
            {
                acc += timesBy3;
                continue;
            }

            var remainder = num.Value;
            if (timesBy3 > 1 || remainderBy3 == 2)
            {
                if (remainderBy3 == 2)
                {
                    acc += timesBy3 + 1;
                    continue;
                }
                
                acc += timesBy3 - 1;
                remainder = remainderBy3 + 3;
            }            
            
            var timesBy2 = Math.DivRem(remainder, 2, out var remainderBy2);
            if (remainderBy2 == 0)
            {
                acc += timesBy2;
                continue;
            }
            
            return -1;
        }
        
        return acc;
    }
}
