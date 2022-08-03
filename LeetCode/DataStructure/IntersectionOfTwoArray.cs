using System.Collections;

namespace LeetCode.DataStructure
{
    public class IntersectionOfTwoArray
    {
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            Hashtable table = new Hashtable();
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j])
                    {
                        if (table.ContainsKey(i) || table.ContainsValue(j))
                        {
                            continue;
                        }
                        else
                        {
                            table.Add(i, j);
                        }
                    }
                }
            }
            int[] result = new int[table.Keys.Count];
            int[] temp = new int[table.Keys.Count];
            table.Keys.CopyTo(temp, 0);
            for (int m = 0; m < table.Keys.Count; m++)
            {
                result[m] = nums1[temp[m]];
            }
            return result;
        }
    }
}
