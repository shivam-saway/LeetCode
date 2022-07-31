namespace LeetCode.DataStructure
{
    public class MaximumSubarray
    {
        public static int MaxSubArray(int[] nums)
        {
            int len = nums.Length;
            int maxsum = int.MinValue,
                lastmaxval = 0;

            for (int i = 0; i < len; i++)
            {
                lastmaxval = lastmaxval + nums[i];

                if (maxsum < lastmaxval)
                    maxsum = lastmaxval;

                if (lastmaxval < 0)
                    lastmaxval = 0;
            }

            return maxsum;
        }
    }
}
