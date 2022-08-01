using System;
using System.Collections.Generic;
using System.Linq;

namespace DepthFirstSearch._3Sum
{
    public class Solution
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            var list = new List<IList<int>>();
            if (nums == null || nums.Length < 3)
            {
                return list;
            }

            Array.Sort(nums);
            var numsLength = nums.Length;
            for (int i = 0; i < numsLength-2; i++)
            {
                if (nums[i] > 0)
                {
                    break;
                }
                
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                int left = i + 1;
                int right = numsLength - 1;
                while (right > left) {
                    // 去重复逻辑如果放在这里，0，0，0 的情况，可能直接导致 right<=left 了，从而漏掉了 0,0,0 这种三元组
                    /*
                    while (right > left && nums[right] == nums[right - 1]) right--;
                    while (right > left && nums[left] == nums[left + 1]) left++;
                    */
                    if (nums[i] + nums[left] + nums[right] > 0) {
                        right--;
                    } else if (nums[i] + nums[left] + nums[right] < 0) {
                        left++;
                    } else {
                        list.Add(new List<int>{nums[i], nums[left], nums[right]});
                        // 去重逻辑应该放在找到一个三元组之后
                        while (right > left && nums[right] == nums[right - 1]) right--;
                        while (right > left && nums[left] == nums[left + 1]) left++;

                        // 找到答案时，双指针同时收缩
                        right--;
                        left++;
                    }
                }
            }

            return list;
        }
    }
}