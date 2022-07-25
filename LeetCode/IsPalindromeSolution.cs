namespace LeetCode
{
    public class IsPalindromeSolution
    {
        public static bool IsPalindrome(int x)
        {
            var a = new List<int>();
            var flag = true;

            if (x == 0)
            {
                return true;
            }

            while (x > 0)
            {
                var y = x % 10;
                a.Add(y);
                x = x / 10;
            }

            if (a.Count == 1)
            {
                return true;
            }

            if (a.Count == 2)
            {
                if (a[0] == a[1])
                {
                    return true;
                }
                return false;
            }
            for (int i = 0; i < (a.Count); i++)
            {
                if (flag == false)
                {
                    break;
                }
                for (int j = a.Count - 1 - i; j >= 0; j--)
                {
                    if (a[i] == a[j])
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                    break;
                }
            }
            return flag;
        }
    }
}
