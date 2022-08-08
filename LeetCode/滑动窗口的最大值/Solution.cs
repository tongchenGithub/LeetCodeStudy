using System.Collections.Generic;

namespace 滑动窗口的最大值
{
    public class Solution
    {
        /**
     * 代码中的类名、方法名、参数名已经指定，请勿修改，直接返回方法规定的值即可
     *
     * 
     * @param num int整型一维数组 
     * @param size int整型 
     * @return int整型一维数组
     */
        public List<int> maxInWindows(List<int> num, int size)
        {
            // write code here
            var len = num.Count;
            var array = new List<int>(len - (size - 1));
            var queue = new Queue<int>();

            for (int i = 0; i < size; i++)
            {
                queue.Enqueue(num[i]);
            }

            var maxFirst = 0;
            foreach (var val in queue)
            {
                if (val > maxFirst)
                {
                    maxFirst = val;
                }
            }

            array.Add(maxFirst);

            for (int i = size; i < len; i++)
            {
                queue.Dequeue();
                queue.Enqueue(num[i]);

                var max = 0;
                foreach (var val in queue)
                {
                    if (val > max)
                    {
                        max = val;
                    }
                }

                array.Add(max);
            }

            return array;
        }
    }
}