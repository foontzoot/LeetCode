namespace LeetCode
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 2, 4 };
            const int target = 6;

            var result = new TwoSumSolution(nums, target);

            Console.WriteLine("[{0}]", string.Join(", ", result));
        }
    }
}