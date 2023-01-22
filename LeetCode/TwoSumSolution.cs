namespace LeetCode
{
    public class TwoSumSolution
    {
        public int[]? result;

        public TwoSumSolution(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                throw new ArgumentNullException(nameof(nums));
            }
            result = TwoSumOptimized(nums, target);
        }

        public int[] TwoSumBruteForce(int[] nums, int target)
        {
            var arraySize = nums.Length;
            for (int i = 0; i < arraySize; i++)
            {
                for (int k = i + 1; k < arraySize; k++)
                {
                    if (nums[i] + nums[k] == target)
                    {
                        result = new int[] { i, k };
                        break;
                    }
                }
            }
            return result ?? (new int[] { 0, 0 });
        }

        public int[] TwoSumOptimized(int[] nums, int target)
        {
            Dictionary<int, int> Seen = new();

            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if (Seen.TryGetValue(diff, out int value))
                {
                    result = new int[] { value, i };
                    break;
                }
                else
                {
                    _ = Seen.TryAdd(nums[i], i);
                }
            }

            return result ?? (new int[] { 0, 0 });
        }
    }
}
