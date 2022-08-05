namespace SearchInsertPosition
{
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            var result = nums.Length;
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var mid = (right - left) / 2 + left;
                if (target <= nums[mid])
                {
                    right = mid - 1;
                    result = mid;
                }
                else if (target > nums[mid])
                {
                    left = mid + 1;
                }
            }

            return result;
        }
    }
}