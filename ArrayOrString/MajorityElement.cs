namespace Exercises.ArrayOrString
{
    public static class MajorityElement
    {
        public static int Solution(int[] nums)
        {
            var elementsCount = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (elementsCount.ContainsKey(nums[i]))
                {
                    elementsCount[nums[i]]++;
                }
                else
                {
                    elementsCount[nums[i]] = 1;
                }

                if (elementsCount[nums[i]] > nums.Length / 2)
                {
                    return nums[i];
                }
            }

            return elementsCount.OrderByDescending(e => e.Value).First().Key; 
        }
    }
}
