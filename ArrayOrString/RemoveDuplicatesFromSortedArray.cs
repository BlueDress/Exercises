namespace Exercises.ArrayOrString
{
    public static class RemoveDuplicatesFromSortedArray
    {
        public static int Solution(int[] nums)
        {
            int uniqueNumbers = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[uniqueNumbers - 1])
                {
                    int temp = nums[i];
                    nums[i] = nums[uniqueNumbers];
                    nums[uniqueNumbers] = temp;
                    uniqueNumbers++;
                }
            }

            return uniqueNumbers;
        }
    }
}
