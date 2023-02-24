namespace LeetCode.Solutions;

public readonly record struct DataArray(int Value, int Index);

public static class TwoSum
{
    //https://leetcode.com/problems/two-sum/
    //Better solution cortesy of https://leetcode.com/problems/two-sum/solutions/2909584/c-faster-than-99-87-simple-solution/?languageTags=csharp
    public static int[] Run(int[] nums, int target)
    {
        var knownValues = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var expected = target - nums[i];
            if (knownValues.ContainsKey(expected))
            {
                return new[] { knownValues[expected], i };
            }
            else
            {
                knownValues.Add(nums[i], i);
            }
        }

        throw new Exception("Not supposed to happen");
    }
}