namespace Solutions;

public static class TwoSum {    
    public static int[] Run(int[] nums, int target) {
        var knownValues = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var expected = target - nums[i];
            if (knownValues.TryGetValue(expected, out var value))
            {
                return new[] { value, i };
            }
            
            knownValues.Add(nums[i], i);
        }

        throw new Exception("Not supposed to happen");
    }
}