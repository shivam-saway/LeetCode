namespace LeetCode.DataStructure
{
    public class TwoSumSolution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    var result = nums[i];
                    result = result + nums[j];
                    if (result == target)
                    {
                        return new int[] { i, j };
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return Array.Empty<int>();
        }
    }
}
