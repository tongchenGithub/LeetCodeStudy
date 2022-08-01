using System.Security.Cryptography;

namespace BinarySearch
{
    public class Solution
    {
        bool IsBadVersion(int version)
        {
            return false;
        }

        public int FirstBadVersion(int n)
        {
            var begin = 0;
            var end = n - 1;
            while (begin <= end)
            {
                var index = (end - begin) / 2 + begin;
                if (IsBadVersion(index + 1))
                {
                    if ((index) == 0 || !IsBadVersion(index))
                    {
                        return index + 1;
                    }

                    end = index - 1;
                }
                else
                {
                    begin = index + 1;
                }
            }

            return end;
        }

        //--------------------------------------------------------------------------------------------
        public int Search(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return -1;
            }

            return MergeCombine(target, nums, 0, nums.Length - 1);
        }

        private int MergeCombine(int target, int[] nums, int begin, int end)
        {
            while (begin <= end)
            {
                var index = (end - begin) / 2 + begin;
                if (nums[index] > target)
                {
                    end = index - 1;
                }
                else if (nums[index] == target)
                {
                    return index;
                }
                else
                {
                    begin = index + 1;
                }
            }

            return -1;
        }
    }
}