namespace Exercises.ArrayOrString
{
    public static class MergeSortedArray
    {
        public static void Solution(int[] nums1, int m, int[] nums2, int n)
        {
            if (n == 0) return;

            int i = 0;
            int j = 0;
            int[] temp = new int[nums1.Length];


            for (int t = 0; t < temp.Length; t++)
            {
                if (j >= n || nums1[i] <= nums2[j] && i < m)
                {
                    temp[t] = nums1[i++];
                }
                else
                {
                    temp[t] = nums2[j++];
                }
            }

            for (int t = 0; t < temp.Length; t++)
            {
                nums1[t] = temp[t];
            }
        }
    }
}
