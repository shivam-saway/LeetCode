namespace LeetCode.DataStructure
{
    public class CheckElementExistInArray
    {
        public static bool isElementExist(int[] sourceForSearch, int elementToSearch)
        {
            bool isExist = false;
            foreach (var item in sourceForSearch)
            {
                if (item == elementToSearch)
                {
                    isExist = true;
                    break;
                }
            }
            return isExist;
        }
    }
}
