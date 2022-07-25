namespace LeetCode.DataStructure
{
    public class GetIndexOfArrayElement
    {
        public static int[] indexArrayOfElementOf(int[] descendingSortedArray, int[] arrayToSearchIn)
        {
            bool byPassFirstZeroCheck = false;
            int[] result = new int[descendingSortedArray.Length];
            for (int i = 0; i < descendingSortedArray.Length; i++)
            {
                for (int j = 0; j < arrayToSearchIn.Length; j++)
                {
                    if (descendingSortedArray[i] == arrayToSearchIn[j])
                    {
                        if (CheckElementExistInArray.isElementExist(result, j))
                        {
                            if (j == 0 && !byPassFirstZeroCheck)
                            {
                                byPassFirstZeroCheck = true;
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            result[i] = j;
                            break;
                        }
                    }
                }
            }
            return result;
        }
    }
}
