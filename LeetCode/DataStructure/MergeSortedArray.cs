namespace LeetCode.DataStructure
{
    public class MergeSortedArray
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var d = nums1.Length - n;
            for (int i = nums1.Length - 1; i>=0 ; i--)
            {
                if (nums1[i] == 0)
                {
                    nums1[i] = (i-d < 0) ? nums1[i] : nums2[i-d];
                }
                else
                {
                    break;
                }
            }
            for (int i = 0; i < nums1.Length - 1; i++)
            {
                for (int j = i + 1; j < nums1.Length; j++)
                {
                    if (nums1[j] < nums1[i])
                    {
                        var temp = nums1[i];
                        nums1[i] = nums1[j];
                        nums1[j] = temp;
                    }
                }
            }
        }
    }
}
