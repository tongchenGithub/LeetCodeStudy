namespace ClimbingStairs
{
    public class Solution
    {
        public int ClimbStairs(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            // 记录走到第n阶具有多少走法
            var arrStep = new int[n];
            arrStep[0] = 1; // 1
            arrStep[1] = arrStep[0] + 1; // 2
            for (var i = 2; i < n; i++)
            {
                arrStep[i] = arrStep[i - 1] + arrStep[i - 2];
            }

            return arrStep[n - 1];
        }
    }
}