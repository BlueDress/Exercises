namespace Exercises.ArrayOrString
{
    public static class RotateArray
    {
        public static void Solution(int[] nums, int k)
        {
            var rotatedNums = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (i + k % nums.Length < nums.Length)
                {
                    rotatedNums[i + k % nums.Length] = nums[i];
                }
                else
                {
                    rotatedNums[i + k % nums.Length - nums.Length] = nums[i];
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rotatedNums[i];
            }
        }
    }
}
