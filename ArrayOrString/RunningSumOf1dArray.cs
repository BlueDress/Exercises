namespace Exercises.ArrayOrString
{
    public static class RunningSumOf1dArray
    {
        public static int[] Solution(int[] nums)
        {
            int currentSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                currentSum = nums[i] + currentSum;
                nums[i] = currentSum;
            }

            return nums;
        }
    }
}
