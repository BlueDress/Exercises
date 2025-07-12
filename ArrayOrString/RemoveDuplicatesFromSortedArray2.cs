namespace Exercises.ArrayOrString
{
    public static class RemoveDuplicatesFromSortedArray2
    {
        public static int Solution(int[] nums)
        {
            int uniqueNumbers = 1;
            bool test = false;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[uniqueNumbers - 1] || (nums[i] == nums[uniqueNumbers - 1] && !test))
                {
                    if (nums[i] == nums[uniqueNumbers - 1])
                    {
                        test = true;
                    }
                    else
                    {
                        test = false;
                    }

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
