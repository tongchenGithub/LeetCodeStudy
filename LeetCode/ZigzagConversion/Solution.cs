namespace DepthFirstSearch.ZigzagConversion
{
    public class Solution
    {
        public string Convert(string s, int numRows)
        {
            var ans = new char[s.Length];

            var arr = s.ToCharArray();
            var n = arr.Length / numRows;
            var charList = new char[numRows, 2 * n - 1];
            ans[0] = arr[0];
            ans[1] = arr[2 * numRows - 2];
            ans[2] = arr[2 * (2 * numRows - 2)];
            ans[3] = arr[3 * (2 * numRows - 2)];
            ans[4] = arr[4 * (2 * numRows - 2)];
            ans[5] = arr[1 + 0 * numRows];
            ans[6] = arr[1 + 1 * numRows];
            return ans.ToString();
        }
    }
}