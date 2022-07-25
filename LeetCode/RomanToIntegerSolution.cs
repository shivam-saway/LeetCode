namespace LeetCode
{
    public class RomanToIntegerSolution
    {
        public static int RomanToInt(string s)
        {
            Dictionary<char, int> romanToIntDictionary = new Dictionary<char, int>();
            int romanToInt = 0;
            romanToIntDictionary.Add('I', 1);
            romanToIntDictionary.Add('V', 5);
            romanToIntDictionary.Add('X', 10);
            romanToIntDictionary.Add('L', 50);
            romanToIntDictionary.Add('C', 100);
            romanToIntDictionary.Add('D', 500);
            romanToIntDictionary.Add('M', 1000);
            var romanArray = s.ToCharArray();
            for (int i = 0; i < romanArray.Length; i++)
            {
                if ((i <= romanArray.Length - 2) &&
                    (((romanArray[i] == 'I') &&
                    (romanArray[i + 1] == 'V' || romanArray[i + 1] == 'X')) ||
                    ((romanArray[i] == 'X') &&
                    (romanArray[i + 1] == 'C' || romanArray[i + 1] == 'L')) ||
                    ((romanArray[i] == 'C') &&
                    (romanArray[i + 1] == 'D' || romanArray[i + 1] == 'M'))))
                {
                    romanToInt = romanToInt - romanToIntDictionary.GetValueOrDefault(romanArray[i]);
                }
                else
                {
                    romanToInt = romanToInt + romanToIntDictionary.GetValueOrDefault(romanArray[i]);
                }
            }

            return romanToInt;
        }
    }
}
