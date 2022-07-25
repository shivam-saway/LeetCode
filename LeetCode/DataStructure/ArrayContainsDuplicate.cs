namespace LeetCode.DataStructure
{
    public class ArrayContainsDuplicate
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            bool containsDuplicate = false;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (containsDuplicate)
                {
                    break;
                }
                for (int j = i+1; j < nums.Length; j++)
                {
                    if(nums[j] == nums[i])
                    {
                        containsDuplicate = true;
                        break;
                    }
                }
            }
            return containsDuplicate;
        }
    }
}
