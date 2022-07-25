namespace LeetCode
{
    public class LongestCommonPrefixSolution
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            string prefix = "";
            if(strs.Length == 1)
            {
                return strs[0];
            }
            else
            {
                for (int i = 0; i < strs.Length; i++)
                {
                    if((i <= strs.Length - 2))
                    {
                        var tempCharArrayOne = (i == 0) ? strs[i].ToCharArray() : prefix.ToCharArray();
                        var tempCharArrayTwo = strs[i+1].ToCharArray();
                        prefix = CommonPrefixBetweem(tempCharArrayOne, tempCharArrayTwo);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            
            return prefix;
        }
        public static string CommonPrefixBetweem(char[] listone, char[] listtwo)
        {
            string localPrefix = "";
            bool abortOperation = false;
            for (int i = 0; i < listone.Length; i++)
            {
                if (abortOperation)
                {
                    break;
                }
                for (int j = i; j < listtwo.Length; j++)
                {
                    if (listone[i] == listtwo[j])
                    {
                        localPrefix = localPrefix + $"{listone[i]}";
                    }
                    else
                    {
                        abortOperation = true;
                    }
                    break;
                }
            }
            return localPrefix;
        }
    }
}
