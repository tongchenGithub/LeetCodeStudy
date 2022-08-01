namespace LongestSubstringWithoutRepeatingCharacters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            var list = new List<char>();
            var rawList = s.ToArray();
            var maxLen = 0;
            var bLoop = false;
            var rawListLength = rawList.Length;
            for (var index = 0; index < rawListLength; index++)
            {
                bLoop = true;
                for (var i = index; i < rawListLength && bLoop; i++)
                {
                    var str = rawList[i];
                    if (list.Contains(str))
                    {
                        if (list.Count > maxLen)
                        {
                            maxLen = list.Count;
                        }

                        list.Clear();
                        bLoop = false;
                    }
                    else
                    {
                        list.Add(str);
                        if (i + 1 == rawListLength && list.Count > maxLen)
                        {
                            maxLen = list.Count;
                        }
                    }
                }
            }

            return maxLen;
        }
    }
}