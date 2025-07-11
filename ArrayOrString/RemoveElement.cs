namespace Exercises.ArrayOrString
{
    public static class RemoveElement
    {
        public static int Solution(int[] nums, int val)
        {
            int k = 0;

            for (int i = nums.Length - 1; i > -1; i--)
            {
                if (nums[i] != val)
                {
                    for (int j = i - 1; j > -1; j--)
                    {
                        if (nums[j] == val)
                        {
                            int temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                            k++;
                            break;
                        }
                    }
                }
                else
                {
                    k++;
                }
            }

            return nums.Length - k;
        }
    }
}
