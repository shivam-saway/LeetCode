namespace LeetCode.DataStructure
{
    public class MaximumSubarray
    {
        public static int MaxSubArray(int[] nums)
        {
            int MaxSubArraySum = 0;
            List<int> MaxSubArraySums = new List<int>();
            if (nums.Length == 1)
            {
                return nums[0];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (MaxSubArraySums.Count > 1)
                {
                    var max = MaxSubArraySums.Max();
                    MaxSubArraySums.RemoveAll(item => item < max);
                }
                MaxSubArraySums.Add(nums[i]);
                for (int j = i + 1; j < nums.Length; j++)
                {
                    MaxSubArraySum = j == i + 1 ? nums[i] + nums[j] : MaxSubArraySum + nums[j];
                    MaxSubArraySums.Add(MaxSubArraySum);
                }
            }
            return MaxSubArraySums.Max();
        }
    }
}
